#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Success.Tests
{
    partial class HttpSenderSuccessTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightSuccessPairTestData))]
        public void Equality_LeftSuccessIsEqualToRight_ExpectTrue(HttpSenderSuccess<RecordType?> left, HttpSenderSuccess<RecordType?> right)
        {
            var actual = left == right;
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightSuccessPairTestData))]
        public void Equality_LeftSuccessIsNotEqualToRight_ExpectFalse(HttpSenderSuccess<RefType> left, HttpSenderSuccess<RefType> right)
        {
            var actual = left == right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetEqualLeftRightSuccessPairTestData))]
        public void Inequality_LeftSuccessIsEqualToRight_ExpectFalse(HttpSenderSuccess<RecordType?> left, HttpSenderSuccess<RecordType?> right)
        {
            var actual = left != right;
            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightSuccessPairTestData))]
        public void Inequality_LeftSuccessIsNotEqualToRight_ExpectTrue(HttpSenderSuccess<RefType> left, HttpSenderSuccess<RefType> right)
        {
            var actual = left != right;
            Assert.True(actual);
        }
    }
}