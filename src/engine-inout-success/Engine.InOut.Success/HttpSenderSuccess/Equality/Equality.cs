#nullable enable

using System;
using System.Collections.Generic;

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<T>
    {
        private static Type EqualityContract => typeof(HttpSenderSuccess<T>);

        private static IEqualityComparer<HttpSenderSuccessCode> StatusCodeComparer => EqualityComparer<HttpSenderSuccessCode>.Default;

        private static IEqualityComparer<T?> ContentComparer => EqualityComparer<T?>.Default;
    }
}