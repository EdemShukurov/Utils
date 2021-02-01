﻿using FunctionalExtension.Common;
using FunctionalExtension.Option;
using System;

namespace FunctionalExtension
{
    public static class BindExtension
    {
        public static R Bind<T,R>(Func<T, R> nextFunction, T input)
        {
            return input == null
                        ? default
                        : nextFunction(input);
        }

        public static Result<R> Bind<T, R>(Func<Result<T>, Result<R>> nextFunction, Result<T> input)
        {
            return input.IsSuccess 
                        ? nextFunction(input)
                        : Result<R>.Fail(input.Error);
        }

        public static Maybe<R> Bind<T, R>(this Maybe<T> input, Func<Maybe<T>, Maybe<R>> nextFunction)
            where T : class
            where R : class
        {
            return input.HasValue
                        ? nextFunction(input)
                        : Maybe<R>.None;
        }

        public static R? Bind<T, R>(this T? self, Func<T, R?> binder)
            where T : struct
            where R : struct
        {
            return self.HasValue
                        ? binder(self.Value)
                        : default(R);
        }


        public static R? Bind<T, R>(this T? self, Func<T, R?> Some, Func<R?> None)
            where T : struct
            where R : struct
        {
            return self.HasValue
                        ? Some(self.Value)
                        : None();
        }
    }
}
