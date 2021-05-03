#nullable enable

using System.Collections.Generic;

namespace PrimeFuncPack.Http.Engine.InOut.Request.Tests
{
    partial class HttpSenderVerbTest
    {
        private static IEnumerable<object[]> GetEqualLeftRightVerbPairTestData()
            =>
            new[]
            {
                new object[] { default(HttpSenderVerb), HttpSenderVerb.Get },
                new object[] { HttpSenderVerb.Get, new HttpSenderVerb() },
                new object[] { HttpSenderVerb.Get, HttpSenderVerb.From("get") },
                new object[] { HttpSenderVerb.From("post"), HttpSenderVerb.Post },
                new object[] { HttpSenderVerb.Delete, HttpSenderVerb.Delete },
                new object[] { HttpSenderVerb.From("some "), HttpSenderVerb.From("SOME ") }
            };

        private static IEnumerable<object[]> GetNotEqualLeftRightVerbPairTestData()
            =>
            new[]
            {
                new object[] { default(HttpSenderVerb), HttpSenderVerb.Post },
                new object[] { HttpSenderVerb.Put, new HttpSenderVerb() },
                new object[] { HttpSenderVerb.Head, HttpSenderVerb.Get },
                new object[] { HttpSenderVerb.Options, HttpSenderVerb.Trace },
                new object[] { HttpSenderVerb.From("Some "), HttpSenderVerb.From("Some") }
            };

        private static IEnumerable<object?[]> GetVerbObjectPairTestData()
            =>
            new[]
            {
                new object?[] { default(HttpSenderVerb), null },
                new object?[] { HttpSenderVerb.Put, new object() },
                new object?[] { HttpSenderVerb.Post, HttpSenderVerb.Post.Name }
            };
    }
}