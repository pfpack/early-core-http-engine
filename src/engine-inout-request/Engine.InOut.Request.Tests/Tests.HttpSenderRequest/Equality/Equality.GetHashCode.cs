#nullable enable

using PrimeFuncPack.UnitTest;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderRequestTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightRequestPairTestData))]
        public void GetHashCode_SourceRequestIsEqualToOther_ExpectHashCodesAreEqual(HttpSenderRequest<RecordType?> source, HttpSenderRequest<RecordType?> other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.Equal(hashCode, otherHashCode);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightRequestPairTestData))]
        public void GetHashCode_SourceRequestIsNotEqualToOtherRequest_ExpectHashCodesAreEqual(HttpSenderRequest<RefType> source, HttpSenderRequest<RefType> other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }

        [Fact]
        public void GetHashCode_TypesAreNotEqual_ExpectHashCodesAreEqual()
        {
            var source = new HttpSenderRequest<StructType?>(HttpSenderVerb.Post, SomeString, SomeTextStructType);
            var other = new HttpSenderRequest<StructType>(HttpSenderVerb.Post, SomeString, SomeTextStructType);

            var hashCode = source.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }
    }
}