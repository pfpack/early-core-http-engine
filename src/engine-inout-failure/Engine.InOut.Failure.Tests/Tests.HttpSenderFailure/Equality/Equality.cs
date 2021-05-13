#nullable enable

using System.Collections.Generic;
using System.Linq;
using Moq;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    partial class HttpSenderFailureTest
    {
        private static IEnumerable<object[]> GetEqualLeftRightFailurePairTestData()
            =>
            new[]
            {
                new HttpSenderFailure[]
                {
                    new(),
                    HttpSenderFailure.UnknownFailure
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.NotFound, null, new StubContentProider(PlusFifteen)),
                    new(HttpSenderFailureCode.NotFound, EmptyString, new StubContentProider(PlusFifteen))
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.NotImplemented, SomeString, new StubContentProider(MinusFifteen)),
                    new(HttpSenderFailureCode.NotImplemented, LowerSomeString, new StubContentProider(MinusFifteen))
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.Canceled, UpperSomeString, new StubContentProider(Zero)),
                    new(HttpSenderFailureCode.Canceled, UpperSomeString, new StubContentProider(Zero))
                }
            }
            .Select(
                arr => new object[] { arr[0], arr[1] });

        private static IEnumerable<object[]> GetNotEqualLeftRightFailurePairTestData()
            =>
            new[]
            {
                new HttpSenderFailure[]
                {
                    new(),
                    HttpSenderFailure.CanceledFailure
                },

                new HttpSenderFailure[]
                {
                    HttpSenderFailure.CanceledFailure,
                    HttpSenderFailure.UnknownFailure
                },

                new HttpSenderFailure[]
                {
                    HttpSenderFailure.CanceledFailure,
                    new(HttpSenderFailureCode.Canceled, EmptyString, new StubContentProider(Zero))
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.BadRequest, EmptyString, new StubContentProider(PlusFifteen)),
                    new(HttpSenderFailureCode.BadRequest, WhiteSpaceString, new StubContentProider(PlusFifteen))
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.Unauthorized, SomeString, new StubContentProider(Zero)),
                    new(HttpSenderFailureCode.Unauthorized, SomeString, new StubContentProider(PlusFifteen))
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.UnprocessableEntity, SomeString, Mock.Of<IContentProvider>()),
                    new(HttpSenderFailureCode.UnprocessableEntity, SomeString, new StubContentProider(Zero))
                },

                new HttpSenderFailure[]
                {
                    new(HttpSenderFailureCode.Unauthorized, UpperSomeString, new StubContentProider(PlusFifteen)),
                    new(HttpSenderFailureCode.NotFound, UpperSomeString, new StubContentProider(MinusFifteen))
                }
            }
            .Select(
                arr => new object[] { arr[0], arr[1] });
    }
}