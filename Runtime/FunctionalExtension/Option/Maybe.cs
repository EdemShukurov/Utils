using FunctionalExtension.Common;

namespace FunctionalExtension.Option
{
    public class Maybe<T>
        where T : class
    {
        public T Value { get; private set; }

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

        public Maybe() { }

        public static Maybe<T> None => new Maybe<T>();


        public static implicit operator Maybe<T>(T value)
        {
            if (value == null)
            {
                return new Maybe<T>();
            }

            return new Maybe<T>(value);
        }

        internal Result<T> ToResult()
        {
            return HasValue
                    ? new Result<T>(Value)
                    : new Result<T>(new ValueIsNullException(nameof(Value)));
        }
    }
}
