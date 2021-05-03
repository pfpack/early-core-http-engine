#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        public override bool Equals(object? obj)
            =>
            obj is HttpSenderRequest<T> other && Equals(other);
    }
}