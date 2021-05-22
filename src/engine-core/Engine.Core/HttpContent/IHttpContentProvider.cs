#nullable enable

using System.Net.Http;

namespace PrimeFuncPack
{
    public interface IHttpContentProvider
    {
        HttpContent? Get<T>(T content);
    }
}