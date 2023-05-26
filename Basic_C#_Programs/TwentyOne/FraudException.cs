using System;
using System.Runtime.Serialization;

namespace TwentyOne
{
    [Serializable]
    internal class FraudException : Exception
    {
        public FraudException()
        {
        }

        public FraudException(string message) : base(message)
        {
        }

        public FraudException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FraudException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}