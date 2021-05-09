#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    public readonly partial struct HttpSenderRequest<T> : IEquatable<HttpSenderRequest<T>>
    {
        private readonly string? uri;

        public HttpSenderRequest(HttpSenderVerb verb, [AllowNull] string uri, T content)
        {
            Verb = verb;
            this.uri = uri.OrEmpty();
            Content = content;
        }

        public HttpSenderVerb Verb { get; }

        public string Uri => uri.OrEmpty();

        [MaybeNull]
        public T Content { get; }
    }
}