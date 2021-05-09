#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Success.Tests
{
    partial class HttpSenderSuccessTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightSuccessPairTestData))]
        public void EqualsImpl_SourceSuccessIsEqualToOther_ExpectTrue(HttpSenderSuccess<RecordType> source, HttpSenderSuccess<RecordType> other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightSuccessPairTestData))]
        public void EqualsImpl_SourceSuccessIsNotEqualToOther_ExpectFalse(HttpSenderSuccess<RefType?> source, HttpSenderSuccess<RefType?> other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }
    }
}