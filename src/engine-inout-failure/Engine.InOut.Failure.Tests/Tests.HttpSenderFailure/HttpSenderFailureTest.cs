#nullable enable

using System.Collections.Generic;
using System.Linq;
using Moq;

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    public sealed partial class HttpSenderFailureTest
    {
        private static IEnumerable<object[]> GetUnknwonAndCanceledFailureTestData()
            =>
            new[]
            {
                new HttpSenderFailure(), HttpSenderFailure.CanceledFailure, HttpSenderFailure.UnknownFailure
            }
            .Select(
                failure => new object[] { failure });

        private static Mock<IContentGetFunc> CreateMockContentGetFunc<T>(T result)
        {
            var mock = new Mock<IContentGetFunc>();
            _ = mock.Setup(f => f.GetContent<T>()).Returns(result);
            return mock;
        }
    }
}