#nullable enable

using System;

namespace PrimeFuncPack
{
    public readonly partial struct HttpSenderSuccess<T> : IEquatable<HttpSenderSuccess<T>>
    {
        public HttpSenderSuccess(HttpSenderSuccessCode statusCode, T? content)
        {
            StatusCode = statusCode;
            Content = content;
        }

        public HttpSenderSuccessCode StatusCode { get; }

        public T? Content { get; }
    }
}