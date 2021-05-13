#nullable enable

using System;

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        public override int GetHashCode()
            =>
            Content is not null
            ? HashCode.Combine(EqualityContract, StatusCodeComparer.GetHashCode(StatusCode), ContentComparer.GetHashCode(Content))
            : HashCode.Combine(EqualityContract, StatusCodeComparer.GetHashCode(StatusCode));
    }
}