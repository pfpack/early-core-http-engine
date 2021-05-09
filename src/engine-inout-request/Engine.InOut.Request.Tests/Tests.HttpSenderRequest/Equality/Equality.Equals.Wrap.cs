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
        public void EqualsWrap_SourceRequestIsEqualToOtherRequest_ExpectTrue(HttpSenderRequest<RecordType> source, object? other)
        {
            var actual = source.Equals(other);
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightRequestPairTestData))]
        public void EqualsWrap_SourceRequestIsNotEqualToOtherRequest_ExpectFalse(HttpSenderRequest<RefType?> source, object? other)
        {
            var actual = source.Equals(other);
            Assert.False(actual);
        }

        [Fact]
        public void EqualsWrap_ObjectIsNull_ExpectFalse()
        {
            var source = default(HttpSenderRequest<RefType>);
            var actual = source.Equals(null);

            Assert.False(actual);
        }

        [Fact]
        public void EqualsWrap_ObjectHasAnotherType_ExpectFalse()
        {
            var source = new HttpSenderRequest<StructType>(HttpSenderVerb.Get, SomeString, SomeTextStructType);
            object obj = new HttpSenderRequest<StructType?>(HttpSenderVerb.Get, SomeString, SomeTextStructType);

            var actual = source.Equals(obj);
            Assert.False(actual);
        }
    }
}