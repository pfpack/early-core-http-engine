#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public override bool Equals(object? obj) => obj is HttpSenderVerb other && Equals(other);
    }
}