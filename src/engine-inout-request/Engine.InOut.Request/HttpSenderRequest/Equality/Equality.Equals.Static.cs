#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        public static bool Equals(HttpSenderRequest<T> left, HttpSenderRequest<T> right)
            =>
            left.Equals(right);
    }
}