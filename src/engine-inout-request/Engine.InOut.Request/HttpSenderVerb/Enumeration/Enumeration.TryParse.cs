#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public static bool TryParse([AllowNull] string value, out HttpSenderVerb result) => VerbEnumeration.TryParse(value.OrEmpty(), out result);
    }
}