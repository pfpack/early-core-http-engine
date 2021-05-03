#nullable enable

using Xunit;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        [Theory]
        [MemberData(nameof(GetEqualLeftRightVerbPairTestData))]
        public void GetHashCode_SourceVerbIsEqualToOtherVerb_ExpectHashCodesAreEqual(HttpSenderVerb source, object? other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other?.GetHashCode();

            Assert.Equal(hashCode, otherHashCode);
        }

        [Theory]
        [MemberData(nameof(GetNotEqualLeftRightVerbPairTestData))]
        public void GetHashCode_SourceVerbIsNotEqualToOtherVerb_ExpectHashCodesAreNotEqual(HttpSenderVerb source, object? other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other?.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }

        [Theory]
        [MemberData(nameof(GetVerbObjectPairTestData))]
        public void GetHashCode_ObjectIsNotVerb_ExpectHashCodesAreNotEqual(HttpSenderVerb source, object? other)
        {
            var hashCode = source.GetHashCode();
            var otherHashCode = other?.GetHashCode();

            Assert.NotEqual(hashCode, otherHashCode);
        }
    }
}