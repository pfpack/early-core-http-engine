#nullable enable

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    internal interface IContentGetFunc
    {
        TContent? GetContent<TContent>();
    }
}