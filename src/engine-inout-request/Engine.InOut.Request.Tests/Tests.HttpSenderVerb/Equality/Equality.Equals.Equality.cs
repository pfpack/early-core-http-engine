#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightVerbPairTestData))]
        public void Equality_LeftVerbIsEqualToRight_ExpectTrue(HttpSenderVerb left, HttpSenderVerb right)
        {
            var actual = left == right;
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightVerbPairTestData))]
        public void Equality_LeftVerbIsNotEqualToRight_ExpectFalse(HttpSenderVerb left, HttpSenderVerb right)
        {
            var actual = left == right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetEqualLeftRightVerbPairTestData))]
        public void Inequality_LeftVerbIsEqualToRight_ExpectFalse(HttpSenderVerb left, HttpSenderVerb right)
        {
            var actual = left != right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightVerbPairTestData))]
        public void Inequality_LeftVerbIsNotEqualToRight_ExpectTrue(HttpSenderVerb left, HttpSenderVerb right)
        {
            var actual = left != right;
            Assert.True(actual);
        }
    }
}