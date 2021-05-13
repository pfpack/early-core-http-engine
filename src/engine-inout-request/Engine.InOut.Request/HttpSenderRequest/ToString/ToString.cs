#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<TContent>
    {
        public override string ToString()
            =>
            Invariant($"An HTTP sender request of {typeof(TContent).Name}: {{ Verb: {Verb}, Uri: \"{Uri}\", Content: \"{ContentToString()}\" }}");

        private string ContentToString()
            =>
            Content is not null ? Invariant($"{Content}") : "null";
    }
}