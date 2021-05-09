#nullable enable

using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetValueAndExpectedVerbTestData))]
        public void TryParse_ValueIsInPredefinedValuesOrNullOrEmpty_ExpectTrueAndExpectedVerb(string value, HttpSenderVerb expectedVerb)
        {
            var actual = HttpSenderVerb.TryParse(value, out var actualVerb);

            Assert.True(actual);
            Assert.Equal(expectedVerb, actualVerb);
        }

        [Theory]
        [InlineData(WhiteSpaceString)]
        [InlineData("POST ")]
        [InlineData(SomeString)]
        public void TryParse_ValueIsNotInPredefinedValues_ExpectFalse(string value)
        {
            var actual = HttpSenderVerb.TryParse(value, out _);
            Assert.False(actual);
        }
    }
}