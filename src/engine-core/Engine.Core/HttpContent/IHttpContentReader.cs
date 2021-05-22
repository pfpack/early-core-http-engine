#nullable enable

namespace PrimeFuncPack
{
    public interface IHttpContentReader
    {
        T? Read<T>(string? httpContent, HttpContentMediaTypeValue? httpContentMediaTypeValue);
    }
}