#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        public static bool operator ==(HttpSenderRequest<T> left, HttpSenderRequest<T> right)
            =>
            left.Equals(right);

        public static bool operator !=(HttpSenderRequest<T> left, HttpSenderRequest<T> right)
            =>
            left.Equals(right) is false;
    }
}