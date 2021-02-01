using System;

namespace FunctionalExtension.Result
{
    /// <summary>
    /// Result is null
    /// </summary>
    [Serializable]
    public class ResultIsNullException : Exception
    {
        public ResultIsNullException()
            : base("Result is null.")
        {
        }

        public ResultIsNullException(string message) : base(message)
        {
        }

        public ResultIsNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
