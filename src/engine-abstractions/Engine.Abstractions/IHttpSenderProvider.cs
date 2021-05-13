#nullable enable

namespace PrimeFuncPack
{
    public interface IHttpSenderProvider
    {
        IHttpSender<TRequest, TResponse> GetSender<TRequest, TResponse>();
    }
}