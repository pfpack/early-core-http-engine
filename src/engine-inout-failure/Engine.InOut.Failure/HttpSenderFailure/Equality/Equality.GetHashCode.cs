#nullable enable

using System;

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        public override int GetHashCode()
            =>
            contentProvider is not null
            ? HashCode.Combine(
                EqualityContract,
                StatusCodeComparer.GetHashCode(StatusCode),
                ContentMediaTypeComparer.GetHashCode(ContentMediaType),
                ContentProviderComparer.GetHashCode(contentProvider))
            : HashCode.Combine(
                EqualityContract,
                StatusCodeComparer.GetHashCode(StatusCode),
                ContentMediaTypeComparer.GetHashCode(ContentMediaType));
    }
}