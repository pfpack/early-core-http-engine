#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    public readonly partial struct HttpSenderFailure : IEquatable<HttpSenderFailure>
    {
        public static HttpSenderFailure CanceledFailure { get; }

        public static HttpSenderFailure UnknownFailure { get; }

        static HttpSenderFailure()
        {
            CanceledFailure = new(HttpSenderFailureCode.Canceled);
            UnknownFailure = new(HttpSenderFailureCode.Unknown);
        }

        private readonly string? contentMediaType;

        private readonly IContentProvider? contentProvider;

        public HttpSenderFailure(HttpSenderFailureCode statusCode, [AllowNull] string contentMediaType, [DisallowNull] IContentProvider contentProvider)
        {
            StatusCode = statusCode;
            this.contentMediaType = contentMediaType ?? string.Empty;
            this.contentProvider = contentProvider ?? throw new ArgumentNullException(nameof(contentProvider));
        }

        private HttpSenderFailure(HttpSenderFailureCode statusCode)
        {
            StatusCode = statusCode;
            this.contentMediaType = string.Empty;
            this.contentProvider = null;
        }

        public HttpSenderFailureCode StatusCode { get; }

        public string ContentMediaType => contentMediaType ?? string.Empty;
    }
}