#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<TContent>
    {
        public static bool Equals(HttpSenderRequest<TContent> left, HttpSenderRequest<TContent> right)
            =>
            left.Equals(right);
    }
}