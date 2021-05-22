#nullable enable

using System;
using System.Net.Http;

namespace PrimeFuncPack
{
    public sealed partial class HttpSenderProvider : IHttpSenderProvider
    {
        public static HttpSenderProvider Create(HttpMessageInvoker httpClient, IHttpContentProvider httpContentProvider, IHttpContentReader httpContentReader)
            =>
            new(
                httpClient ?? throw new ArgumentNullException(nameof(httpClient)),
                httpContentProvider ?? throw new ArgumentNullException(nameof(httpContentProvider)),
                httpContentReader ?? throw new ArgumentNullException(nameof(httpContentReader)));
        
        internal HttpSenderProvider(HttpMessageInvoker httpClient, IHttpContentProvider httpContentProvider, IHttpContentReader httpContentReader)
        {
            this.httpClient = httpClient;
            this.httpContentProvider = httpContentProvider;
            this.httpContentReader = httpContentReader;
        }

        private readonly HttpMessageInvoker httpClient;

        private readonly IHttpContentProvider httpContentProvider;

        private readonly IHttpContentReader httpContentReader;
    }
}