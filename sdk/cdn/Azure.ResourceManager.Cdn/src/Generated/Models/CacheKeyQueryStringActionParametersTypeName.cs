// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The CacheKeyQueryStringActionParametersTypeName. </summary>
    public readonly partial struct CacheKeyQueryStringActionParametersTypeName : IEquatable<CacheKeyQueryStringActionParametersTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CacheKeyQueryStringActionParametersTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CacheKeyQueryStringActionParametersTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeliveryRuleCacheKeyQueryStringBehaviorActionParametersValue = "DeliveryRuleCacheKeyQueryStringBehaviorActionParameters";

        /// <summary> DeliveryRuleCacheKeyQueryStringBehaviorActionParameters. </summary>
        public static CacheKeyQueryStringActionParametersTypeName DeliveryRuleCacheKeyQueryStringBehaviorActionParameters { get; } = new CacheKeyQueryStringActionParametersTypeName(DeliveryRuleCacheKeyQueryStringBehaviorActionParametersValue);
        /// <summary> Determines if two <see cref="CacheKeyQueryStringActionParametersTypeName"/> values are the same. </summary>
        public static bool operator ==(CacheKeyQueryStringActionParametersTypeName left, CacheKeyQueryStringActionParametersTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CacheKeyQueryStringActionParametersTypeName"/> values are not the same. </summary>
        public static bool operator !=(CacheKeyQueryStringActionParametersTypeName left, CacheKeyQueryStringActionParametersTypeName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CacheKeyQueryStringActionParametersTypeName"/>. </summary>
        public static implicit operator CacheKeyQueryStringActionParametersTypeName(string value) => new CacheKeyQueryStringActionParametersTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CacheKeyQueryStringActionParametersTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CacheKeyQueryStringActionParametersTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
