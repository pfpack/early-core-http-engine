#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        public bool Equals(HttpSenderSuccess<TContent> other)
            =>
            StatusCodeComparer.Equals(StatusCode, other.StatusCode) && ContentComparer.Equals(Content, other.Content);
    }
}