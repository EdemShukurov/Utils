namespace FunctionalExtension.Common
{
    public static class ResultExtension
    {
        public static Result<T> ToResult<T>(this T self)
        {
            return self != null
                    ? new Result<T>(self)
                    : new Result<T>(new ResultIsNullException(nameof(self)));
        }
    }
}
