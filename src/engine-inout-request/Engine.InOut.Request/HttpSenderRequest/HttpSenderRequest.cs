#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    public readonly partial struct HttpSenderRequest<TContent> : IEquatable<HttpSenderRequest<TContent>>
    {
        private readonly string? uri;

        public HttpSenderRequest(HttpSenderVerb verb, [AllowNull] string uri, TContent content)
        {
            Verb = verb;
            this.uri = uri.OrEmpty();
            Content = content;
        }

        public HttpSenderVerb Verb { get; }

        public string Uri => uri.OrEmpty();

        [MaybeNull]
        public TContent Content { get; }
    }
}