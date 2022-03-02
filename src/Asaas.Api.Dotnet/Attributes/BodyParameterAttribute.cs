namespace Asaas.Api.Dotnet.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public sealed class BodyParameterAttribute : Attribute
{
    public string Key { get; }

    public BodyParameterAttribute(string key)
    {
        Key = key;
    }
}
