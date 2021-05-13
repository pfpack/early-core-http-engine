#nullable enable

using System;
using System.Collections.Generic;

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        private static Type EqualityContract => typeof(HttpSenderSuccess<TContent>);

        private static IEqualityComparer<HttpSenderSuccessCode> StatusCodeComparer => EqualityComparer<HttpSenderSuccessCode>.Default;

        private static IEqualityComparer<TContent?> ContentComparer => EqualityComparer<TContent?>.Default;
    }
}