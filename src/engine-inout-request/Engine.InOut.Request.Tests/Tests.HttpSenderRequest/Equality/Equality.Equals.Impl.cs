#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderRequestTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightRequestPairTestData))]
        public void EqualsImpl_SourceRequestIsEqualToOther_ExpectTrue(HttpSenderRequest<RecordType> source, HttpSenderRequest<RecordType> other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightRequestPairTestData))]
        public void EqualsImpl_SourceRequestIsNotEqualToOther_ExpectFalse(HttpSenderRequest<RefType?> source, HttpSenderRequest<RefType?> other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }
    }
}