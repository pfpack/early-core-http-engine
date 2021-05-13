#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightFailurePairTestData))]
        public void EqualsStatic_LeftFailureIsEqualToRight_ExpectTrue(HttpSenderFailure left, HttpSenderFailure right)
        {
            var actual = HttpSenderFailure.Equals(left, right);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightFailurePairTestData))]
        public void EqualsStatic_LeftFailureIsNotEqualToRight_ExpectFalse(HttpSenderFailure left, HttpSenderFailure right)
        {
            var actual = HttpSenderFailure.Equals(left, right);
            Assert.False(actual);
        }
    }
}