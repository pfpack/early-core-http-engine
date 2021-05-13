#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        public static bool operator ==(HttpSenderSuccess<TContent> left, HttpSenderSuccess<TContent> right)
            =>
            left.Equals(right);

        public static bool operator !=(HttpSenderSuccess<TContent> left, HttpSenderSuccess<TContent> right)
            =>
            left.Equals(right) is false;
    }
}