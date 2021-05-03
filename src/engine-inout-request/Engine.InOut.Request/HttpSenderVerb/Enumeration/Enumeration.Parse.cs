#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public static Optional<HttpSenderVerb> Parse([AllowNull] string value) => value.ToStringOrEmpty().Pipe(VerbEnumeration.Parse);
    }
}