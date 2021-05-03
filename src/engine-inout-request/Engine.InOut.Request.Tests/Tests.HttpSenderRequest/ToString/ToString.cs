#nullable enable

using System;
using PrimeFuncPack.UnitTest;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderRequestTest
    {
        [Fact]
        public void ToString_RequestIsDefault_ValueContainsResultOfHttpVerbGetToString()
        {
            var request = default(HttpSenderRequest<RecordType>);

            var actual = request.ToString();
            Assert.Contains(HttpSenderVerb.Get.ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_RequestIsDefault_ValueContainsNullText()
        {
            var request = default(HttpSenderRequest<RecordType>);

            var actual = request.ToString();
            Assert.Contains("\"null\"", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_RequestIsNotDefault_ValueContainsResultOfHttpVerbToString()
        {
            var verb = HttpSenderVerb.From(SomeString);
            var request = new HttpSenderRequest<RefType>(verb, "/some", PlusFifteenIdRefType);

            var actual = request.ToString();
            Assert.Contains(verb.ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_RequestIsNotDefault_ValueContainsSourceUri()
        {
            var sourceUri = "http://some.ru/test";
            var request = new HttpSenderRequest<StructType?>(HttpSenderVerb.Head, sourceUri, null);

            var actual = request.ToString();
            Assert.Contains(sourceUri, actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_RequestIsNotDefaultAndContentIsNull_ValueContainsNullText()
        {
            var request = new HttpSenderRequest<RecordType?>(HttpSenderVerb.Put, "/some/15", null);

            var actual = request.ToString();
            Assert.Contains("\"null\"", actual, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void ToString_RequestIsNotDefault_ValueContainsResultOfContentToString()
        {
            var content = SomeTextStructType;
            var request = new HttpSenderRequest<StructType>(HttpSenderVerb.Delete, "test", content);

            var actual = request.ToString();
            Assert.Contains(content.ToString(), actual, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}