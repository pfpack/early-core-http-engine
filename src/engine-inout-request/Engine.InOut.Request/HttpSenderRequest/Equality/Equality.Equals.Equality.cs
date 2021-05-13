#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<TContent>
    {
        public static bool operator ==(HttpSenderRequest<TContent> left, HttpSenderRequest<TContent> right)
            =>
            left.Equals(right);

        public static bool operator !=(HttpSenderRequest<TContent> left, HttpSenderRequest<TContent> right)
            =>
            left.Equals(right) is false;
    }
}