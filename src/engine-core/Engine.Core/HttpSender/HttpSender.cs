#nullable enable

using System.Net.Http;

namespace PrimeFuncPack
{
    internal sealed partial class HttpSender<TRequest, TResponse> : IHttpSender<TRequest, TResponse>
    {
        private readonly HttpMessageInvoker httpClient;

        private readonly IHttpContentProvider httpContentProvider;

        private readonly IHttpContentReader httpContentReader;

        internal HttpSender(HttpMessageInvoker httpClient, IHttpContentProvider httpContentProvider, IHttpContentReader httpContentReader)
        {
            this.httpClient = httpClient;
            this.httpContentProvider = httpContentProvider;
            this.httpContentReader = httpContentReader;
        }
    }
}