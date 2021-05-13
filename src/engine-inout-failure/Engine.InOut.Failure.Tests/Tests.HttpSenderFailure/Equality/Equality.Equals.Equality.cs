#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightFailurePairTestData))]
        public void Equality_LeftFailureIsEqualToRight_ExpectTrue(HttpSenderFailure left, HttpSenderFailure right)
        {
            var actual = left == right;
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightFailurePairTestData))]
        public void Equality_LeftFailureIsNotEqualToRight_ExpectFalse(HttpSenderFailure left, HttpSenderFailure right)
        {
            var actual = left == right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetEqualLeftRightFailurePairTestData))]
        public void Inequality_LeftFailureIsEqualToRight_ExpectFalse(HttpSenderFailure left, HttpSenderFailure right)
        {
            var actual = left != right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightFailurePairTestData))]
        public void Inequality_LeftFailureIsNotEqualToRight_ExpectTrue(HttpSenderFailure left, HttpSenderFailure right)
        {
            var actual = left != right;
            Assert.True(actual);
        }
    }
}