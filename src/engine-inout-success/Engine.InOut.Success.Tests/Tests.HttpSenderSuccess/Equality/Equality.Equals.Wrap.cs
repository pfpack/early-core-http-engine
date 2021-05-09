#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Success.Tests
{
    partial class HttpSenderSuccessTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightSuccessPairTestData))]
        public void EqualsWrap_SourceSuccessIsEqualToOtherSuccess_ExpectTrue(HttpSenderSuccess<RecordType> source, object? other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightSuccessPairTestData))]
        public void EqualsWrap_SourceSuccessIsNotEqualToOtherSuccess_ExpectFalse(HttpSenderSuccess<RefType?> source, object? other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }

        [Fact]
        public void EqualsWrap_ObjectIsNull_ExpectFalse()
        {
            var source = default(HttpSenderSuccess<RefType>);
            var actual = source.Equals(null);

            Assert.False(actual);
        }

        [Fact]
        public void EqualsWrap_ObjectHasAnotherType_ExpectFalse()
        {
            var source = new HttpSenderSuccess<StructType?>(HttpSenderSuccessCode.OK, SomeTextStructType);
            object obj = new HttpSenderSuccess<StructType>(HttpSenderSuccessCode.OK, SomeTextStructType);

            var actual = source.Equals(obj);
            Assert.False(actual);
        }
    }
}