#nullable enable

using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        private static IEnumerable<object[]> GetValueAndExpectedVerbTestData()
            =>
            new[]
            {
                new object[] { null!, HttpSenderVerb.Get },
                new object[] { string.Empty, HttpSenderVerb.Get },
                new object[] { "get", HttpSenderVerb.Get },
                new object[] { "Get", HttpSenderVerb.Get },
                new object[] { "GET", HttpSenderVerb.Get },
                new object[] { "post", HttpSenderVerb.Post },
                new object[] { "pOst", HttpSenderVerb.Post },
                new object[] { "POST", HttpSenderVerb.Post },
                new object[] { "put", HttpSenderVerb.Put },
                new object[] { "Put", HttpSenderVerb.Put },
                new object[] { "PUT", HttpSenderVerb.Put },
                new object[] { "delete", HttpSenderVerb.Delete },
                new object[] { "DeLETe", HttpSenderVerb.Delete },
                new object[] { "DELETE", HttpSenderVerb.Delete },
                new object[] { "head", HttpSenderVerb.Head },
                new object[] { "Head", HttpSenderVerb.Head },
                new object[] { "HEAD", HttpSenderVerb.Head },
                new object[] { "options", HttpSenderVerb.Options },
                new object[] { "optionS", HttpSenderVerb.Options },
                new object[] { "OPTIONS", HttpSenderVerb.Options },
                new object[] { "patch", HttpSenderVerb.Patch },
                new object[] { "Patch", HttpSenderVerb.Patch },
                new object[] { "PATCH", HttpSenderVerb.Patch },
                new object[] { "trace", HttpSenderVerb.Trace },
                new object[] { "Trace", HttpSenderVerb.Trace },
                new object[] { "TRACE", HttpSenderVerb.Trace }
            };
    }
}