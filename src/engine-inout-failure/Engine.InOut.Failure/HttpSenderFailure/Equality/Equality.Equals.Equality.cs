#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        public static bool operator ==(HttpSenderFailure left, HttpSenderFailure right)
            =>
            left.Equals(right);

        public static bool operator !=(HttpSenderFailure left, HttpSenderFailure right)
            =>
            left.Equals(right) is false;
    }
}