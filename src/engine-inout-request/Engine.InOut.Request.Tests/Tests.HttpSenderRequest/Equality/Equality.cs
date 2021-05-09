#nullable enable

using System.Collections.Generic;
using System.Linq;
using PrimeFuncPack.UnitTest;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderRequestTest
    {
        private static IEnumerable<object[]> GetEqualLeftRightRequestPairTestData()
            =>
            new[]
            {
                new HttpSenderRequest<RecordType?>[]
                {
                    new(),
                    new(default, default, default)
                },

                new HttpSenderRequest<RecordType?>[]
                {
                    new(HttpSenderVerb.Get, EmptyString, null),
                    default
                },

                new HttpSenderRequest<RecordType?>[]
                {
                    new(HttpSenderVerb.Put, LowerSomeString, PlusFifteenIdSomeStringNameRecord),
                    new(HttpSenderVerb.Put, UpperSomeString, PlusFifteenIdSomeStringNameRecord)
                },

                new HttpSenderRequest<RecordType?>[]
                {
                    new(HttpSenderVerb.Head, "/some", new() { Id = 781, Name = "Some Name" }),
                    new(HttpSenderVerb.From("head"), "/some", new() { Id = 781, Name = "Some Name" })
                }
            }
            .Select(
                arr => new object[] { arr[0], arr[1] });

        private static IEnumerable<object[]> GetNotEqualLeftRightRequestPairTestData()
            =>
            new[]
            {
                new HttpSenderRequest<RefType?>[]
                {
                    new(default, WhiteSpaceString, default),
                    new(default, default, default)
                },

                new HttpSenderRequest<RefType?>[]
                {
                    new(HttpSenderVerb.Get, EmptyString, null),
                    new(HttpSenderVerb.Post, EmptyString, null)
                },

                new HttpSenderRequest<RefType?>[]
                {
                    new(HttpSenderVerb.Put, SomeString, new()),
                    new(HttpSenderVerb.Put, SomeString, new())
                },

                new HttpSenderRequest<RefType?>[]
                {
                    new(HttpSenderVerb.Delete, "/some", PlusFifteenIdRefType),
                    new(HttpSenderVerb.Delete, "/some/", PlusFifteenIdRefType)
                }
            }
            .Select(
                arr => new object[] { arr[0], arr[1] });
    }
}