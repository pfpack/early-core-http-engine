#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        public override string ToString()
            =>
            Invariant($"An HTTP sender success response of {typeof(TContent).Name}: {{ StatusCode: {StatusCode}, Content: \"{ContentToString()}\" }}");

        private string ContentToString()
            =>
            Content is not null ? Invariant($"{Content}") : "null";
    }
}