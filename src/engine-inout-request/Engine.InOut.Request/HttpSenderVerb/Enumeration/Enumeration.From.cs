#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public static HttpSenderVerb From([AllowNull] string value) => value.OrEmpty().Pipe(VerbEnumeration.From);
    }
}