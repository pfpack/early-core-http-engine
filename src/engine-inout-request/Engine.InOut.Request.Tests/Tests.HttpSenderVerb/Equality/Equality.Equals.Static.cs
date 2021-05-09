#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightVerbPairTestData))]
        public void EqualsStatic_LeftVerbIsEqualToRight_ExpectTrue(HttpSenderVerb left, HttpSenderVerb right)
        {
            var actual = HttpSenderVerb.Equals(left, right);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightVerbPairTestData))]
        public void EqualsStatic_LeftVerbIsNotEqualToRight_ExpectFalse(HttpSenderVerb left, HttpSenderVerb right)
        {
            var actual = HttpSenderVerb.Equals(left, right);
            Assert.False(actual);
        }
    }
}