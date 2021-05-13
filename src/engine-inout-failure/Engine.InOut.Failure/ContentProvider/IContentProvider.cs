#nullable enable

using System;

namespace PrimeFuncPack
{
    public interface IContentProvider : IEquatable<IContentProvider>
    {
        TContent? GetContent<TContent>();
    }
}