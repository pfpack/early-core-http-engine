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
        public void GetHashCode_SourceSuccessIsEqualToOther_ExpectHashCodesAreEqual(HttpSenderSuccess<RecordType?> source, HttpSenderSuccess<RecordType?> other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.Equal(hashCode, otherHashCode);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightSuccessPairTestData))]
        public void GetHashCode_SourceSuccessIsNotEqualToOtherSuccess_ExpectHashCodesAreEqual(HttpSenderSuccess<RefType> source, HttpSenderSuccess<RefType> other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }

        [Fact]
        public void GetHashCode_TypesAreNotEqual_ExpectHashCodesAreEqual()
        {
            var source = new HttpSenderSuccess<StructType?>(HttpSenderSuccessCode.Created, SomeTextStructType);
            var other = new HttpSenderSuccess<StructType>(HttpSenderSuccessCode.Created, SomeTextStructType);

            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }
    }
}