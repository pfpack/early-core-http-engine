#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        public override bool Equals(object? obj)
            =>
            obj is HttpSenderFailure other && Equals(other);
    }
}