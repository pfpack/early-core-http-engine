#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Moq;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace PrimeFuncPack.Http.Engine.InOut.Failure.Tests
{
    internal sealed class StubContentProider : IContentProvider
    {
        private readonly IContentGetFunc contentGetFunc;

        private readonly int value;

        private readonly string? toStringValue;

        public StubContentProider(int value)
        {
            this.contentGetFunc = Mock.Of<IContentGetFunc>();
            this.value = value;
        }

        public StubContentProider(IContentGetFunc contentGetFunc)
        {
            this.contentGetFunc = contentGetFunc;
        }

        public StubContentProider(string? toStringValue)
        {
            this.contentGetFunc = Mock.Of<IContentGetFunc>();
            this.toStringValue = toStringValue;
        }

        public TContent? GetContent<TContent>()
            =>
            contentGetFunc.GetContent<TContent>();

        public bool Equals(IContentProvider? other)
            =>
            other is StubContentProider stub && ValueComparer.Equals(value, stub.value);

        public static bool operator ==(StubContentProider left, StubContentProider right)
            =>
            left.Equals(right);

        public static bool operator !=(StubContentProider left, StubContentProider right)
            =>
            left.Equals(right) is false;

        public override bool Equals(object? obj)
            =>
            obj is IContentProvider other && Equals(other);

        public override int GetHashCode()
            =>
            HashCode.Combine(EqualityContract, ValueComparer.GetHashCode(value));

        public override string? ToString()
            =>
            toStringValue;

        private static Type EqualityContract => typeof(StubContentProider);

        private static IEqualityComparer<int> ValueComparer => EqualityComparer<int>.Default;
    }
}