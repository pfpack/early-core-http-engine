#nullable enable

using System.Collections.Generic;
using System.Linq;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetVerbTestData))]
        public void ToString_ExpectValueIsEqualToName(HttpSenderVerb verb)
        {
            var actual = verb.ToString();
            var expected = verb.Name;

            Assert.Equal(expected, actual);
        }

        private static IEnumerable<object[]> GetVerbTestData()
            =>
            new[]
            {
                default(HttpSenderVerb),
                HttpSenderVerb.Get,
                HttpSenderVerb.Post,
                HttpSenderVerb.Put,
                HttpSenderVerb.Delete,
                HttpSenderVerb.Head,
                HttpSenderVerb.Options,
                HttpSenderVerb.Patch,
                HttpSenderVerb.Trace,
                HttpSenderVerb.From(SomeString)
            }
            .Select(
                verb => new object[] { verb });
    }
}