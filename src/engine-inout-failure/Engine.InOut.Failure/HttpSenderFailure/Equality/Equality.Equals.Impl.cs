#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        public bool Equals(HttpSenderFailure other)
            =>
            StatusCodeComparer.Equals(StatusCode, other.StatusCode)
            && ContentMediaTypeComparer.Equals(ContentMediaType, other.ContentMediaType)
            && ContentProviderComparer.Equals(contentProvider, other.contentProvider);
    }
}