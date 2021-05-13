#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightFailurePairTestData))]
        public void EqualsImpl_SourceFailureIsEqualToOther_ExpectTrue(HttpSenderFailure source, HttpSenderFailure other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightFailurePairTestData))]
        public void EqualsImpl_SourceFailureIsNotEqualToOther_ExpectFalse(HttpSenderFailure source, HttpSenderFailure other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }
    }
}