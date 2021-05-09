#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<T>
    {
        public override bool Equals(object? obj)
            =>
            obj is HttpSenderSuccess<T> other && Equals(other);
    }
}