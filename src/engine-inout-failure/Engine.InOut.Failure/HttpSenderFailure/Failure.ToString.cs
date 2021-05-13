#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        public override string ToString()
            =>
            Invariant($"An HTTP sender failure: {{ StatusCode: {StatusCode}, ContentMediaType: \"{ContentMediaType}\", ContentProvider: \"{ContentProviderToString()}\" }}");

        private string ContentProviderToString()
            =>
            contentProvider?.ToString() ?? "null";
    }
}