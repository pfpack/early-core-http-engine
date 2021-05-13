#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        public TContent? GetContent<TContent>() => contentProvider is not null ? contentProvider.GetContent<TContent>() : default(TContent?);
    }
}