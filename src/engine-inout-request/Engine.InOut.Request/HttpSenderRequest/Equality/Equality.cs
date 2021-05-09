#nullable enable

using System;
using System.Collections.Generic;

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        private static Type EqualityContract => typeof(HttpSenderRequest<T>);

        private static IEqualityComparer<HttpSenderVerb> VerbComparer => EqualityComparer<HttpSenderVerb>.Default;

        private static StringComparer UriComparer => StringComparer.InvariantCultureIgnoreCase;

        private static IEqualityComparer<T> ContentComparer => EqualityComparer<T>.Default;
    }
}