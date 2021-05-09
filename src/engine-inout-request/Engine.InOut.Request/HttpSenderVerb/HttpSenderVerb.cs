#nullable enable

using System;

namespace PrimeFuncPack
{
    public readonly partial struct HttpSenderVerb : IEquatable<HttpSenderVerb>
    {
        private static readonly Enumeration<HttpSenderVerb> VerbEnumeration;

        static HttpSenderVerb()
        {
            Get = new(DefaultHttpVerbGet);
            Post = new("POST");
            Put = new("PUT");
            Delete = new("DELETE");
            Head = new("HEAD");
            Options = new("OPTIONS");
            Patch = new("PATCH");
            Trace = new("TRACE");
            VerbEnumeration = Enumeration.With<HttpSenderVerb>(name => new(name));
        }

        private const string DefaultHttpVerbGet = "GET";

        private readonly string? name;

        private HttpSenderVerb(string name) => this.name = name;

        public string Name => name.IsNotNullOrEmpty() ? name : DefaultHttpVerbGet;
    }
}