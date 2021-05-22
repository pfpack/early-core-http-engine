#nullable enable

namespace PrimeFuncPack
{
    partial class HttpSenderProvider
    {
        public IHttpSender<TRequest, TResponse> GetSender<TRequest, TResponse>()
            =>
            new HttpSender<TRequest, TResponse>(
                httpClient: httpClient,
                httpContentProvider: httpContentProvider,
                httpContentReader: httpContentReader);
    }
}