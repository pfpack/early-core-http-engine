#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightVerbPairTestData))]
        public void EqualsWrap_SourceVerbIsEqualToOtherVerb_ExpectTrue(HttpSenderVerb source, object? obj)
        {
            var actual = source.Equals(obj);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightVerbPairTestData))]
        public void EqualsWrap_SourceVerbIsNotEqualToOtherVerb_ExpectFalse(HttpSenderVerb source, object? obj)
        {
            var actual = source.Equals(obj);
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetVerbObjectPairTestData))]
        public void EqualsWrap_ObjectIsNotVerb_ExpectFalse(HttpSenderVerb source, object? obj)
        {
            var actual = source.Equals(obj);
            Assert.False(actual);
        }
    }
}