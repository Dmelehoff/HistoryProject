using System;


namespace HistoryProjectAPI.Exceptions
{
    public class BadOperationException : Exception
    {
        public BadOperationException(string message)
            : base(message)
        {
        }
    }
}
