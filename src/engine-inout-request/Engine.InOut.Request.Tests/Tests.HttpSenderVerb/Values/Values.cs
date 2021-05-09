#nullable enable

using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetVerbExpectedNamePairTestData))]
        public void PredefinedValue_ExpectNameIsEqualToGet(HttpSenderVerb verb, string expected)
        {
            var actual = verb.Name;
            Assert.Equal(expected, actual);
        }

        private static IEnumerable<object[]> GetVerbExpectedNamePairTestData()
            =>
            new[]
            {
                new object[] { default(HttpSenderVerb), "GET" },
                new object[] { HttpSenderVerb.Get, "GET" },
                new object[] { HttpSenderVerb.Post, "POST" },
                new object[] { HttpSenderVerb.Put, "PUT" },
                new object[] { HttpSenderVerb.Delete, "DELETE" },
                new object[] { HttpSenderVerb.Head, "HEAD" },
                new object[] { HttpSenderVerb.Options, "OPTIONS" },
                new object[] { HttpSenderVerb.Patch, "PATCH" },
                new object[] { HttpSenderVerb.Trace, "TRACE" }
            };
    }
}