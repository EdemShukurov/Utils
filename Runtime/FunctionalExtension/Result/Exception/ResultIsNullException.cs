using System;

namespace FunctionalExtension.Common
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
