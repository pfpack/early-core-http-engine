#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderRequestTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightRequestPairTestData))]
        public void Equality_LeftRequestIsEqualToRight_ExpectTrue(HttpSenderRequest<RecordType?> left, HttpSenderRequest<RecordType?> right)
        {
            var actual = left == right;
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightRequestPairTestData))]
        public void Equality_LeftRequestIsNotEqualToRight_ExpectFalse(HttpSenderRequest<RefType> left, HttpSenderRequest<RefType> right)
        {
            var actual = left == right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetEqualLeftRightRequestPairTestData))]
        public void Inequality_LeftRequestIsEqualToRight_ExpectFalse(HttpSenderRequest<RecordType?> left, HttpSenderRequest<RecordType?> right)
        {
            var actual = left != right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightRequestPairTestData))]
        public void Inequality_LeftRequestIsNotEqualToRight_ExpectTrue(HttpSenderRequest<RefType> left, HttpSenderRequest<RefType> right)
        {
            var actual = left != right;
            Assert.True(actual);
        }
    }
}