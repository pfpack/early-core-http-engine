#nullable enable

using System.Collections.Generic;
using System.Linq;
using PrimeFuncPack.UnitTest;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Success.Tests
{
    partial class HttpSenderSuccessTest
    {
        private static IEnumerable<object[]> GetEqualLeftRightSuccessPairTestData()
            =>
            new[]
            {
                new HttpSenderSuccess<RecordType?>[]
                {
                    new(),
                    new(default, default)
                },

                new HttpSenderSuccess<RecordType?>[]
                {
                    new(HttpSenderSuccessCode.OK, null),
                    new(HttpSenderSuccessCode.OK, null)
                },

                new HttpSenderSuccess<RecordType?>[]
                {
                    new(HttpSenderSuccessCode.Created, new() { Id = PlusFifteen, Name = SomeString }),
                    new(HttpSenderSuccessCode.Created, new() { Id = PlusFifteen, Name = SomeString })
                },

                new HttpSenderSuccess<RecordType?>[]
                {
                    new(HttpSenderSuccessCode.NoContent, new() { Id = MinusFifteen, Name = null }),
                    new(HttpSenderSuccessCode.NoContent, new() { Id = MinusFifteen, Name = null })
                }
            }
            .Select(
                arr => new object[] { arr[0], arr[1] });

        private static IEnumerable<object[]> GetNotEqualLeftRightSuccessPairTestData()
            =>
            new[]
            {
                new HttpSenderSuccess<RefType?>[]
                {
                    new(default, new()),
                    new(default, new())
                },

                new HttpSenderSuccess<RefType?>[]
                {
                    new(HttpSenderSuccessCode.OK, PlusFifteenIdRefType),
                    new(HttpSenderSuccessCode.Created, PlusFifteenIdRefType)
                },

                new HttpSenderSuccess<RefType?>[]
                {
                    new(HttpSenderSuccessCode.NoContent, PlusFifteenIdRefType),
                    new(HttpSenderSuccessCode.NoContent, null)
                }
            }
            .Select(
                arr => new object[] { arr[0], arr[1] });
    }
}