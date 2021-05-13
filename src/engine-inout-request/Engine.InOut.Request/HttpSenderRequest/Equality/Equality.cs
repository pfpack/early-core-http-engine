#nullable enable

using System;
using System.Collections.Generic;

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<TContent>
    {
        private static Type EqualityContract => typeof(HttpSenderRequest<TContent>);

        private static IEqualityComparer<HttpSenderVerb> VerbComparer => EqualityComparer<HttpSenderVerb>.Default;

        private static StringComparer UriComparer => StringComparer.InvariantCultureIgnoreCase;

        private static IEqualityComparer<TContent> ContentComparer => EqualityComparer<TContent>.Default;
    }
}