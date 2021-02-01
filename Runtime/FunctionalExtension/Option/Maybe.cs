using FunctionalExtension.Common;
using System;
using System.Collections.Generic;

namespace FunctionalExtension.Option
{
    public readonly struct Maybe<T> : IEquatable<Maybe<T>>
        where T : class
    {
        public T Value { get; }

        public bool HasValue => Value != null;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="someValue">Value</param>
        /// <exception cref="ValueIsNullException"></exception>
        public Maybe(T someValue)
        {
            Value = someValue;
        }


        public static bool operator ==(Maybe<T> x, Maybe<T> y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Maybe<T> x, Maybe<T> y)
        {
            return !(x == y);
        }

        public static Maybe<T> None => default;


        public static implicit operator Maybe<T>(T value)
        {
            if (value == null)
            {
                return new Maybe<T>();
            }

            return new Maybe<T>(value);
        }

        public static implicit operator T(Maybe<T> maybe)
        {
            return maybe.Value;
        }

        internal Result<T> ToResult()
        {
            return HasValue
                    ? new Result<T>(Value)
                    : new Result<T>(new ValueIsNullException(nameof(Value)));
        }

        public bool Equals(Maybe<T> other)
        {
            return other.HasValue
                    ? other.Value == Value
                    : false;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<T>.Default.GetHashCode(Value);
        }
    }
}
