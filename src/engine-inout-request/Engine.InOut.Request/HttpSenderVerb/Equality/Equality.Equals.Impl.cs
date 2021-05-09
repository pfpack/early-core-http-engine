#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public bool Equals(HttpSenderVerb other) => NameComparer.Equals(Name, other.Name);
    }
}