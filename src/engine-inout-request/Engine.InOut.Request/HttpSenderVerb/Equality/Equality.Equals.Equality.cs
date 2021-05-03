#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderVerb
    {
        public static bool operator ==(HttpSenderVerb left, HttpSenderVerb right) => left.Equals(right);

        public static bool operator !=(HttpSenderVerb left, HttpSenderVerb right) => left.Equals(right) is false;
    }
}