#nullable enable

using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetValueAndExpectedVerbTestData))]
        public void From_ValueIsInPredefinedValuesOrNullOrEmpty_ExpectPredefinedVerb(string value, HttpSenderVerb expected)
        {
            var actual = HttpSenderVerb.From(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(WhiteSpaceString)]
        [InlineData(" Get")]
        [InlineData(SomeString)]
        public void From_ValueIsNotInPredefinedValues_ExpectNameIsEqualToSourceValue(string value)
        {
            var actual = HttpSenderVerb.From(value);
            var actualName = actual.Name;

            Assert.Equal(value, actualName);
        }
    }
}