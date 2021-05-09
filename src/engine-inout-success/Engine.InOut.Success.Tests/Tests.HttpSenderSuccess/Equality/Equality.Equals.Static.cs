#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Success.Tests
{
    partial class HttpSenderSuccessTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightSuccessPairTestData))]
        public void EqualsStatic_LeftSuccessIsEqualToRight_ExpectTrue(HttpSenderSuccess<RecordType?> left, HttpSenderSuccess<RecordType?> right)
        {
            var actual = HttpSenderSuccess<RecordType?>.Equals(left, right);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightSuccessPairTestData))]
        public void EqualsStatic_LeftSuccessIsNotEqualToRight_ExpectFalse(HttpSenderSuccess<RefType?> left, HttpSenderSuccess<RefType?> right)
        {
            var actual = HttpSenderSuccess<RefType?>.Equals(left, right);
            Assert.False(actual);
        }
    }
}