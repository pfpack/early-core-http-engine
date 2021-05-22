#nullable enable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    public sealed partial class HttpContentMediaTypeValue : IEquatable<HttpContentMediaTypeValue>
    {
        public HttpContentMediaTypeValue(
            [AllowNull] IReadOnlyCollection<string> encoding,
            [AllowNull] string mediaType,
            [AllowNull] string charSet,
            [AllowNull] IReadOnlyDictionary<string, string> parameters)
        {
            Encoding = encoding ?? Array.Empty<string>();
            MediaType = mediaType.OrEmpty();
            CharSet = charSet.OrEmpty();
            Parameters = parameters ?? EmptyParameters.Value;
        }

        public IReadOnlyCollection<string> Encoding { get; }

        public string MediaType { get; }

        public string CharSet { get; }

        public IReadOnlyDictionary<string, string> Parameters { get; }

        // See the sources of MediaTypeHeaderValue to implement Equals
        public bool Equals(HttpContentMediaTypeValue? other)
        {
            throw new NotImplementedException();
        }

        private sealed class EmptyParameters
        {
            private static readonly Dictionary<string, string> EmptyDictionary = new();

            public static IReadOnlyDictionary<string, string> Value { get; } = new ReadOnlyDictionary<string, string>(EmptyDictionary);
        }
    }
}