#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        public bool Equals(HttpSenderRequest<T> other)
            =>
            VerbComparer.Equals(Verb, other.Verb) &&
            UriComparer.Equals(Uri, other.Uri) &&
            ContentComparer.Equals(Content, other.Content);
    }
}