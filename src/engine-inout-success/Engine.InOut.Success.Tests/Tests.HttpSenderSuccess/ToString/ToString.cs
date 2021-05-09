#nullable enable

using System;
using PrimeFuncPack.UnitTest;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Success.Tests
{
    partial class HttpSenderSuccessTest
    {
        [Fact]
        public void ToString_SourceIsDefault_ExpectValueContainsResultOfStatusCodeToString()
        {
            var Success = default(HttpSenderSuccess<RecordType>);

            var actual = Success.ToString();
            Assert.Contains((default(HttpSenderSuccessCode)).ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_SourceIsDefault_ExpectValueContainsNullText()
        {
            var Success = default(HttpSenderSuccess<RecordType>);

            var actual = Success.ToString();
            Assert.Contains("\"null\"", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Theory]
        [InlineData(HttpSenderSuccessCode.OK)]
        [InlineData(HttpSenderSuccessCode.Created)]
        [InlineData(HttpSenderSuccessCode.NoContent)]
        [InlineData(HttpSenderSuccessCode.AlreadyReported)]
        [InlineData(HttpSenderSuccessCode.Accepted)]
        public void ToString_SourceIsNotDefault_ExpectValueContainsResultOfStatusCodeToString(HttpSenderSuccessCode statusCode)
        {
            var Success = new HttpSenderSuccess<RefType>(statusCode, MinusFifteenIdRefType);

            var actual = Success.ToString();
            Assert.Contains(statusCode.ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_SourceIsNotDefaultAndContentIsNull_ExpectValueContainsNullText()
        {
            var Success = new HttpSenderSuccess<RecordType?>(HttpSenderSuccessCode.ResetContent, null);

            var actual = Success.ToString();
            Assert.Contains("\"null\"", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_SourceIsNotDefault_ExpectValueContainsResultOfContentToString()
        {
            var content = SomeTextStructType;
            var Success = new HttpSenderSuccess<StructType>(HttpSenderSuccessCode.OK, content);

            var actual = Success.ToString();
            Assert.Contains(content.ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}