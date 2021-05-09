#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderRequestTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightRequestPairTestData))]
        public void EqualsStatic_LeftRequestIsEqualToRight_ExpectTrue(HttpSenderRequest<RecordType?> left, HttpSenderRequest<RecordType?> right)
        {
            var actual = HttpSenderRequest<RecordType?>.Equals(left, right);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightRequestPairTestData))]
        public void EqualsStatic_LeftRequestIsNotEqualToRight_ExpectFalse(HttpSenderRequest<RefType?> left, HttpSenderRequest<RefType?> right)
        {
            var actual = HttpSenderRequest<RefType?>.Equals(left, right);
            Assert.False(actual);
        }
    }
}