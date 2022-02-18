using System.Globalization;
using System.Runtime.Serialization;
using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Exceptions
{
    [Serializable]
    public class ApiTooManyRequestsException : ApiException
    {
        public TimeSpan RetryAfter { get; }

        public ApiTooManyRequestsException(IResponse response) : base(response)
        {
            if (response.Headers.TryGetValue("Retry-After", out string? retryAfter))
            {
                RetryAfter = TimeSpan.FromSeconds(int.Parse(retryAfter, CultureInfo.InvariantCulture));
            }
        }

        public ApiTooManyRequestsException() { }

        public ApiTooManyRequestsException(string message) : base(message) { }

        public ApiTooManyRequestsException(string message, Exception innerException) : base(message, innerException) { }

        protected ApiTooManyRequestsException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}