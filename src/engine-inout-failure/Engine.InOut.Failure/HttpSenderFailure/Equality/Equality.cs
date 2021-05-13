#nullable enable

using System;
using System.Collections.Generic;

namespace PrimeFuncPack
{
    partial struct HttpSenderFailure
    {
        private static Type EqualityContract => typeof(HttpSenderFailure);

        private static IEqualityComparer<HttpSenderFailureCode> StatusCodeComparer => EqualityComparer<HttpSenderFailureCode>.Default;

        private static IEqualityComparer<string> ContentMediaTypeComparer => StringComparer.InvariantCultureIgnoreCase;

        private static IEqualityComparer<IContentProvider?> ContentProviderComparer => EqualityComparer<IContentProvider?>.Default;
    }
}