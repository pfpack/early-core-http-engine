#nullable enable

using Moq;
using PrimeFuncPack.UnitTest;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        [Theory]
        [MemberData(nameof(GetUnknwonAndCanceledFailureTestData))]
        public void GetContent_RefType_SourceIsUnknownOrCanceledFailure_ExpectNull(HttpSenderFailure source)
        {
            var actual = source.GetContent<RefType>();
            Assert.Null(actual);
        }

        [Theory]
        [MemberData(nameof(GetUnknwonAndCanceledFailureTestData))]
        public void GetContent_NullableStructType_SourceIsUnknownOrCanceledFailure_ExpectNull(HttpSenderFailure source)
        {
            var actual = source.GetContent<int?>();
            Assert.Null(actual);
        }

        [Theory]
        [MemberData(nameof(GetUnknwonAndCanceledFailureTestData))]
        public void GetContent_StructType_SourceIsUnknownOrCanceledFailure_ExpectDefault(HttpSenderFailure source)
        {
            var actual = source.GetContent<StructType>();
            var expected = default(StructType);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetContent_RefType_SourceIsNotPredefinedValue_ExpectCallGetContentOnce()
        {
            var mockContentGetFunc = CreateMockContentGetFunc(MinusFifteenIdNullNameRecord);
            var contentProvider = new StubContentProider(mockContentGetFunc.Object);

            var source = new HttpSenderFailure(HttpSenderFailureCode.Continue, null, contentProvider);
            _ = source.GetContent<RecordType?>();

            mockContentGetFunc.Verify(f => f.GetContent<RecordType?>(), Times.Once);
        }

        [Fact]
        public void GetContent_StructType_SourceIsNotPredefinedValue_ExpectCallGetContentOnce()
        {
            var mockContentGetFunc = CreateMockContentGetFunc(SomeTextStructType);
            var contentProvider = new StubContentProider(mockContentGetFunc.Object);

            var source = new HttpSenderFailure(HttpSenderFailureCode.Continue, null, contentProvider);
            _ = source.GetContent<StructType>();

            mockContentGetFunc.Verify(f => f.GetContent<StructType>(), Times.Once);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(EmptyString)]
        [InlineData(SomeString)]
        public void GetContent_SourceIsNotPredefinedValue_ExpectResultOfGetContent(string? content)
        {
            var mockContentGetFunc = CreateMockContentGetFunc(content);
            var contentProvider = new StubContentProider(mockContentGetFunc.Object);

            var source = new HttpSenderFailure(HttpSenderFailureCode.Continue, "text/xml", contentProvider);
            var actual = source.GetContent<string>();

            Assert.Equal(content, actual);
        }
    }
}