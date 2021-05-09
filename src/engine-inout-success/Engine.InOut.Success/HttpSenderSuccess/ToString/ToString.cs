#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<T>
    {
        public override string ToString()
            =>
            Invariant($"A HTTP sender success response of {typeof(T).Name}: {{ StatusCode: {StatusCode}, Content: \"{ContentToString()}\" }}");

        private string ContentToString()
            =>
            Content is not null ? Invariant($"{Content}") : "null";
    }
}