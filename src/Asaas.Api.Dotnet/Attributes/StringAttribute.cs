using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Asaas.Api.Dotnet.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class StringAttribute : Attribute
    {
        public StringAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static bool GetValue(Type enumType, Enum enumValue, [NotNullWhen(true)] out string? result)
        {
            if (enumType
              .GetMember(enumValue.ToString())[0]
              .GetCustomAttributes(typeof(StringAttribute))
              .FirstOrDefault() is StringAttribute stringAttr)
            {
                result = stringAttr.Value;
                return true;
            }
            result = null;
            return false;
        }
    }
}