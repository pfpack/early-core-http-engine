#nullable enable

using System;

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        private static Type EqualityContract => typeof(HttpSenderVerb);

        private static StringComparer NameComparer => StringComparer.InvariantCultureIgnoreCase;
    }
}