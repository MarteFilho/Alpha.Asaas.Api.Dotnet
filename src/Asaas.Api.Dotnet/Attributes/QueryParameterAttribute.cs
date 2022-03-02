namespace Asaas.Api.Dotnet.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public sealed class QueryParameterAttribute : Attribute
{
    public string Key { get; }

    public QueryParameterAttribute(string key)
    {
        Key = key;
    }
}