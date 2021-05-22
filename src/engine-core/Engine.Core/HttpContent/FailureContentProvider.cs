#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    internal sealed class FailureContentProvider : IContentProvider
    {
        private readonly IHttpContentReader httpContentReader;

        private readonly string? httpContent;
        
        private readonly HttpContentMediaTypeValue? httpContentMediaTypeValue;

        internal FailureContentProvider([DisallowNull] IHttpContentReader httpContentReader, string? httpContent, HttpContentMediaTypeValue? httpContentMediaTypeValue)
        {
            this.httpContentReader = httpContentReader ?? throw new ArgumentNullException(nameof(httpContentReader));
            this.httpContent = httpContent;
            this.httpContentMediaTypeValue = httpContentMediaTypeValue;
        }

        public TContent? GetContent<TContent>() => httpContentReader.Read<TContent>(httpContent, httpContentMediaTypeValue);

        public bool Equals(IContentProvider? other)
        {
            throw new System.NotImplementedException();
        }
    }
}