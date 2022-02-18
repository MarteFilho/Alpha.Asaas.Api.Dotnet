using System.Runtime.Serialization;
using Asaas.Api.Dotnet.Http.Interfaces;

namespace Asaas.Api.Dotnet.Exceptions
{
[Serializable]
  public class ApiUnauthorizedException : ApiException
  {
    public ApiUnauthorizedException(IResponse response) : base(response) { }

    public ApiUnauthorizedException() { }

    public ApiUnauthorizedException(string message) : base(message) { }

    public ApiUnauthorizedException(string message, Exception innerException) : base(message, innerException) { }

    protected ApiUnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }
}