#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<T>
    {
        public bool Equals(HttpSenderSuccess<T> other)
            =>
            StatusCodeComparer.Equals(StatusCode, other.StatusCode) && ContentComparer.Equals(Content, other.Content);
    }
}