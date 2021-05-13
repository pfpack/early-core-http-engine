#nullable enable

using System;

namespace PrimeFuncPack
{
    public readonly partial struct HttpSenderSuccess<TContent> : IEquatable<HttpSenderSuccess<TContent>>
    {
        public HttpSenderSuccess(HttpSenderSuccessCode statusCode, TContent? content)
        {
            StatusCode = statusCode;
            Content = content;
        }

        public HttpSenderSuccessCode StatusCode { get; }

        public TContent? Content { get; }
    }
}