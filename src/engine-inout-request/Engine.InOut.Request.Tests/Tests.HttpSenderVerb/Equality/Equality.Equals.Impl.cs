#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightVerbPairTestData))]
        public void EqualsImpl_SourceVerbIsEqualToOther_ExpectTrue(HttpSenderVerb source, HttpSenderVerb other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightVerbPairTestData))]
        public void EqualsImpl_SourceVerbIsNotEqualToOther_ExpectFalse(HttpSenderVerb source, HttpSenderVerb other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }
    }
}