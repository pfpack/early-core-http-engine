#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<TContent>
    {
        public bool Equals(HttpSenderRequest<TContent> other)
            =>
            VerbComparer.Equals(Verb, other.Verb) &&
            UriComparer.Equals(Uri, other.Uri) &&
            ContentComparer.Equals(Content, other.Content);
    }
}