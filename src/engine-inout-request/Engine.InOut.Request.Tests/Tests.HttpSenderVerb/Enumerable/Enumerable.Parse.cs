#nullable enable

using System;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetValueAndExpectedVerbTestData))]
        public void Parse_ValueIsInPredefinedValuesOrNullOrEmpty_ExpectPresentExpectedVerb(string value, HttpSenderVerb expectedVerb)
        {
            var actual = HttpSenderVerb.Parse(value);
            var expected = Optional.Present(expectedVerb);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(WhiteSpaceString)]
        [InlineData(" get")]
        [InlineData(SomeString)]
        public void Parse_ValueIsNotInPredefinedValues_ExpectAbsent(string value)
        {
            var actual = HttpSenderVerb.Parse(value);
            var expected = Optional<HttpSenderVerb>.Absent;

            Assert.Equal(expected, actual);
        }
    }
}