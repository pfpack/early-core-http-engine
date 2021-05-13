#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<TContent>
    {
        public override bool Equals(object? obj)
            =>
            obj is HttpSenderRequest<TContent> other && Equals(other);
    }
}