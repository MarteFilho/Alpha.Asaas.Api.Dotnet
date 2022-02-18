using System.Web;

namespace Asaas.Util
{
    public class UriParameterFormatProvider : IFormatProvider
    {
        private readonly URIParameterFormatter _formatter;

        public UriParameterFormatProvider()
        {
            _formatter = new URIParameterFormatter();
        }

        public object? GetFormat(Type? formatType)
        {
            return formatType == typeof(ICustomFormatter) ? _formatter : null;
        }

        private class URIParameterFormatter : ICustomFormatter
        {
            public string Format(string? format, object? arg, IFormatProvider? formatProvider)
            {
                return HttpUtility.UrlEncode(arg?.ToString()) ?? string.Empty;
            }
        }
    }
}