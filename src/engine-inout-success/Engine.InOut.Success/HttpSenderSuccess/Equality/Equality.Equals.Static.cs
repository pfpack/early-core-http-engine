#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        public static bool Equals(HttpSenderSuccess<TContent> left, HttpSenderSuccess<TContent> right)
            =>
            left.Equals(right);
    }
}