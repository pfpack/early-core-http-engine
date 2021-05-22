#nullable enable

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeFuncPack
{
    partial class HttpSender<TRequest, TResponse>
    {
        public async ValueTask<Result<HttpSenderSuccess<TResponse>, HttpSenderFailure>> InvokeAsync(
            HttpSenderRequest<TRequest> httpSenderRequest, CancellationToken cancellationToken = default)
        {
            try
            {
                return await InternalInvokeAsync(httpSenderRequest, cancellationToken).ConfigureAwait(false);
            }
            catch(OperationCanceledException)
            {
                return HttpSenderFailure.CanceledFailure;
            }
        }

        private async ValueTask<Result<HttpSenderSuccess<TResponse>, HttpSenderFailure>> InternalInvokeAsync(
            HttpSenderRequest<TRequest> httpSenderRequest, CancellationToken cancellationToken)
        {
            if(cancellationToken.IsCancellationRequested)
            {
                return HttpSenderFailure.CanceledFailure;
            }
            
            using var httpRequestMessage = MapToRequestMessage(httpSenderRequest);
            using var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);

            if(cancellationToken.IsCancellationRequested)
            {
                return HttpSenderFailure.CanceledFailure;
            }

            string? httpContent = null;
            if(httpResponseMessage.Content is not null)
            {
                httpContent = await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            }

            if(cancellationToken.IsCancellationRequested)
            {
                return HttpSenderFailure.CanceledFailure;
            }

            return httpResponseMessage.IsSuccessStatusCode ? MapToSuccess(httpResponseMessage, httpContent) : MapToFailure(httpResponseMessage, httpContent);
        }

        private HttpRequestMessage MapToRequestMessage(HttpSenderRequest<TRequest> httpSenderRequest)
        {
            var httpRequestMessage = new HttpRequestMessage(method: new(httpSenderRequest.Verb.Name), requestUri: httpSenderRequest.Uri);

            if((httpSenderRequest.Content is not null) && (httpSenderRequest.Content.GetType() != typeof(Unit)))
            {
                httpRequestMessage.Content = httpContentProvider.Get(httpSenderRequest.Content);
            }

            return httpRequestMessage;
        }

        private HttpSenderSuccess<TResponse> MapToSuccess(HttpResponseMessage httpResponseMessage, string? httpContent)
            =>
            new(
                statusCode: (HttpSenderSuccessCode)httpResponseMessage.StatusCode,
                content: ReadSuccess(httpContent, httpResponseMessage.Content?.Headers));
        
        private HttpSenderFailure MapToFailure(HttpResponseMessage httpResponseMessage, string? httpContent)
            =>
            new(
                statusCode: (HttpSenderFailureCode)httpResponseMessage.StatusCode,
                contentMediaType: httpResponseMessage.Content?.Headers?.ContentType?.MediaType,
                contentProvider: new FailureContentProvider(httpContentReader, httpContent, ToHttpContentMediaTypeValue(httpResponseMessage.Content?.Headers)));

        private TResponse? ReadSuccess(string? httpContent, HttpContentHeaders? httpContentHeaders)
            =>
            typeof(TResponse) != typeof(Unit) ? httpContentReader.Read<TResponse>(httpContent, ToHttpContentMediaTypeValue(httpContentHeaders)) : default;

        private static HttpContentMediaTypeValue? ToHttpContentMediaTypeValue(HttpContentHeaders? httpContentHeaders)
        {
            if(httpContentHeaders is null)
            {
                return null;
            }

            return new(
                encoding: httpContentHeaders.ContentEncoding?.ToArray(),
                mediaType: httpContentHeaders.ContentType?.MediaType,
                charSet: httpContentHeaders.ContentType?.CharSet,
                parameters: httpContentHeaders.ContentType?.Parameters?.ToDictionary(kv => kv.Name, kv => kv.Value.OrEmpty()));
        }
    }
}