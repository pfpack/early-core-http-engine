#nullable enable

using System;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Fact]
        public void ToString_SourceIsDefault_ExpectResultContainsUnknown()
        {
            var source = HttpSenderFailure.UnknownFailure;
            var actual = source.ToString();

            Assert.Contains("Unknown", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_SourceIsCanceledFailure_ExpectResultContainsCanceled()
        {
            var source = HttpSenderFailure.CanceledFailure;
            var actual = source.ToString();

            Assert.Contains("Canceled", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Theory]
        [MemberData(nameof(GetUnknwonAndCanceledFailureTestData))]
        public void ToString_SourceIsUnknownOrCanceledFailure_ExpectResultContainsNullContent(HttpSenderFailure source)
        {
            var actual = source.ToString();
            Assert.Contains("\"null\"", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Theory]
        [InlineData(HttpSenderFailureCode.Unknown)]
        [InlineData(HttpSenderFailureCode.Canceled)]
        [InlineData(HttpSenderFailureCode.NotFound)]
        [InlineData(HttpSenderFailureCode.Unauthorized)]
        [InlineData(HttpSenderFailureCode.UpgradeRequired)]
        public void ToString_ExpectResultContainsStatusCode(HttpSenderFailureCode statusCode)
        {
            var source = new HttpSenderFailure(statusCode, SomeString, new StubContentProider(SomeString));
            var actual = source.ToString();

            Assert.Contains(statusCode.ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(EmptyString)]
        [InlineData(WhiteSpaceString)]
        [InlineData(SomeString)]
        [InlineData("application/problem+json")]
        public void ToString_ExpectResultContainsContentMediaType(string? contentMediaType)
        {
            var source = new HttpSenderFailure(HttpSenderFailureCode.Continue, contentMediaType, new StubContentProider("Some content"));
            var actual = source.ToString();

            var expected = "\"" + contentMediaType ?? string.Empty + "\"";
            Assert.Contains(expected, actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(EmptyString)]
        [InlineData(WhiteSpaceString)]
        [InlineData(MixedWhiteSpacesString)]
        [InlineData(SomeString)]
        public void ToString_ExpectResultContainsContentProviderToString(string? contentToString)
        {
            var source = new HttpSenderFailure(HttpSenderFailureCode.Continue, "application/problem+json", new StubContentProider(contentToString));
            var actual = source.ToString();

            var expected = "\"" + contentToString ?? string.Empty + "\"";
            Assert.Contains(expected, actual, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}