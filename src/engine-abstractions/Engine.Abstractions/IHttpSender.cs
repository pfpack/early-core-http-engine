#nullable enable

using System;

namespace PrimeFuncPack
{
    public interface IHttpSender<TRequest, TResponse> : IAsyncValueFunc<HttpSenderRequest<TRequest>, Result<HttpSenderSuccess<TResponse>, HttpSenderFailure>>
    {
    }
}