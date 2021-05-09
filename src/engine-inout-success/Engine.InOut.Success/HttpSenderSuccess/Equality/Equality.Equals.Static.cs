#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<T>
    {
        public static bool Equals(HttpSenderSuccess<T> left, HttpSenderSuccess<T> right)
            =>
            left.Equals(right);
    }
}