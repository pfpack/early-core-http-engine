#nullable enable

using System;

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public override int GetHashCode() => HashCode.Combine(EqualityContract, NameComparer.GetHashCode(Name));
    }
}