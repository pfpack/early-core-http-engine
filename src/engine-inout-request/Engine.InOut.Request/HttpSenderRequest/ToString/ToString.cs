#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack
{
    partial struct HttpSenderRequest<T>
    {
        public override string ToString()
        =>
        Invariant($"A HTTP sender request of {typeof(T).Name}: {{ Verb: {Verb}, Uri: \"{Uri}\", Content: \"{ContentToString()}\" }}");

        private string ContentToString()
            =>
            Content is not null ? Invariant($"{Content}") : "null";
    }
}