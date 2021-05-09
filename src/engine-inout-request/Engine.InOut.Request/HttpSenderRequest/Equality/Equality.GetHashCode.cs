#nullable enable

using System;

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        public override int GetHashCode()
            =>
            Content is not null
            ? HashCode.Combine(EqualityContract, VerbComparer.GetHashCode(Verb), UriComparer.GetHashCode(Uri), ContentComparer.GetHashCode(Content))
            : HashCode.Combine(EqualityContract, VerbComparer.GetHashCode(Verb), UriComparer.GetHashCode(Uri));
    }
}