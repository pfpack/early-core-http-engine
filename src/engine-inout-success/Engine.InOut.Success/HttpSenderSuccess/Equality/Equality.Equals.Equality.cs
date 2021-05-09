#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<T>
    {
        public static bool operator ==(HttpSenderSuccess<T> left, HttpSenderSuccess<T> right)
            =>
            left.Equals(right);

        public static bool operator !=(HttpSenderSuccess<T> left, HttpSenderSuccess<T> right)
            =>
            left.Equals(right) is false;
    }
}