using System.Collections.Concurrent;
using System.Reflection;
using Asaas.Api.Dotnet.Attributes;
using Asaas.Api.Dotnet.Exceptions;
using Newtonsoft.Json.Linq;

namespace Asaas.Api.Dotnet.Models.Requests
{
    public abstract record RequestParams
    {
        private static readonly ConcurrentDictionary<Type, List<(PropertyInfo, BodyParameterAttribute)>> _bodyParamsCache =
          new();

        public JObject BuildBodyParameters()
        {
            // Make sure everything is okay before building body params
            CustomEnsure();

            var body = new JObject();
            var type = GetType();

            if (!_bodyParamsCache.IsEmpty && _bodyParamsCache.ContainsKey(type))
            {
                foreach (var (info, attribute) in _bodyParamsCache[type])
                {
                    AddBodyParameter(body, info, attribute);
                }
            }
            else
            {
                var bodyProps = GetType()
                  .GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
                  .Where(prop => prop.GetCustomAttributes(typeof(BodyParameterAttribute), true).Length > 0);

                var cachedParams = new List<(PropertyInfo, BodyParameterAttribute)>();
                foreach (var prop in bodyProps)
                {
                    var attribute = prop.GetCustomAttribute<BodyParameterAttribute>();
                    if (attribute != null)
                    {
                        cachedParams.Add((prop, attribute));
                        AddBodyParameter(body, prop, attribute);
                    }
                }
                _bodyParamsCache[type] = cachedParams;
            }

            return body;
        }

        private void AddBodyParameter(JObject body, PropertyInfo propertyInfo, BodyParameterAttribute attribute)
        {
            object? value = propertyInfo.GetValue(this);
            if (value != null)
            {
                body[attribute.Key ?? propertyInfo.Name] = JToken.FromObject(value);
            }
        }

        private static readonly ConcurrentDictionary<Type, List<(PropertyInfo, QueryParameterAttribute)>> _queryParamsCache =
          new();

        public Dictionary<string, string> BuildQueryParameters()
        {
            // Make sure everything is okay before building query params
            CustomEnsure();

            var queryParams = new Dictionary<string, string>();
            var type = GetType();

            if (!_queryParamsCache.IsEmpty && _queryParamsCache.ContainsKey(type))
            {
                foreach (var (info, attribute) in _queryParamsCache[type])
                {
                    AddQueryParameter(queryParams, info, attribute);
                }
            }
            else
            {
                var queryProps = GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
                .Where(prop => prop.GetCustomAttributes(typeof(QueryParameterAttribute), true).Length > 0);

                var cachedParams = new List<(PropertyInfo, QueryParameterAttribute)>();
                foreach (var prop in queryProps)
                {
                    var attribute = prop.GetCustomAttribute<QueryParameterAttribute>();
                    if (attribute != null)
                    {
                        cachedParams.Add((prop, attribute));
                        AddQueryParameter(queryParams, prop, attribute);
                    }
                }
                _queryParamsCache[type] = cachedParams;
            }

            AddCustomQueryParameters(queryParams);

            return queryParams;
        }

        private void AddQueryParameter(Dictionary<string, string> queryParams, PropertyInfo prop, QueryParameterAttribute attribute)
        {
            object? value = prop.GetValue(this);
            if (value != null)
            {
                if (value is IList<string> list)
                {
                    if (list.Count > 0)
                    {
                        var str = string.Join(",", list);
                        queryParams.Add(attribute.Key ?? prop.Name, str);
                    }
                }
                else if (value is bool valueAsBool)
                {
                    queryParams.Add(attribute.Key ?? prop.Name, valueAsBool ? "true" : "false");
                }
                else if (value is Enum valueAsEnum)
                {
                    var enumType = valueAsEnum.GetType();
                    var valueList = new List<string>();

                    if (enumType.IsDefined(typeof(FlagsAttribute), false))
                    {
                        foreach (Enum enumVal in Enum.GetValues(valueAsEnum.GetType()))
                        {
                            if (valueAsEnum.HasFlag(enumVal))
                            {
                                if (StringAttribute.GetValue(enumType, enumVal, out var stringVal))
                                {
                                    valueList.Add(stringVal!);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (StringAttribute.GetValue(enumType, valueAsEnum, out var stringVal))
                        {
                            // .netstandard2.0 requires !
                            valueList.Add(stringVal!);
                        }
                    }
                    queryParams.Add(attribute.Key ?? prop.Name, string.Join(",", valueList));
                }
                else
                {
                    queryParams.Add(attribute.Key ?? prop.Name, value.ToString() ?? throw new ApiException("ToString returned null for query parameter"));
                }
            }
        }

        protected virtual void CustomEnsure() { }
        protected virtual void AddCustomQueryParameters(Dictionary<string, string> queryParams) { }
    }
}