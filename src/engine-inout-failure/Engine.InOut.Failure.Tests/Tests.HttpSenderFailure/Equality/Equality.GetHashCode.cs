#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightFailurePairTestData))]
        public void GetHashCode_SourceFailureIsEqualToOther_ExpectHashCodesAreEqual(HttpSenderFailure source, HttpSenderFailure other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.Equal(hashCode, otherHashCode);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightFailurePairTestData))]
        public void GetHashCode_SourceFailureIsNotEqualToOtherFailure_ExpectHashCodesAreEqual(HttpSenderFailure source, HttpSenderFailure other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }

        [Fact]
        public void GetHashCode_TypesAreNotEqual_ExpectHashCodesAreEqual()
        {
            var source = HttpSenderFailure.UnknownFailure;
            var other = HttpSenderFailureCode.Canceled;

            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }
    }
}