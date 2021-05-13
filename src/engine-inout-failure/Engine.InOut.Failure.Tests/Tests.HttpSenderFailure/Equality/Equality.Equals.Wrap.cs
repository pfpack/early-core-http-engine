#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightFailurePairTestData))]
        public void EqualsWrap_SourceFailureIsEqualToOtherFailure_ExpectTrue(HttpSenderFailure source, object? other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightFailurePairTestData))]
        public void EqualsWrap_SourceFailureIsNotEqualToOtherFailure_ExpectFalse(HttpSenderFailure source, object? other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }

        [Fact]
        public void EqualsWrap_ObjectIsNull_ExpectFalse()
        {
            var source = default(HttpSenderFailure);
            var actual = source.Equals(null);

            Assert.False(actual);
        }

        [Fact]
        public void EqualsWrap_ObjectHasAnotherType_ExpectFalse()
        {
            var source = HttpSenderFailure.CanceledFailure;
            object obj = HttpSenderFailureCode.Canceled;

            var actual = source.Equals(obj);
            Assert.False(actual);
        }
    }
}