using System;

namespace FunctionalExtension.Option
{
    /// <summary>
    /// Value is null
    /// </summary>
    [Serializable]
    public class ValueIsNullException : Exception
    {
        public ValueIsNullException()
            : base("Value is null.")
        {
        }

        public ValueIsNullException(string message) : base(message)
        {
        }

        public ValueIsNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
