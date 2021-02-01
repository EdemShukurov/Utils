using System;

namespace FunctionalExtension.Option
{
    public class Maybe<T>
        where T : class
    {
        public T Value { get; private set; }

        public Maybe(T someValue)
        {
            if(someValue == null)
            {
                throw new ValueIsNullException(nameof(someValue));
            }

            Value = someValue;
        }

        public Maybe() { }

        public static Maybe<T> None => new Maybe<T>();
    }
}
