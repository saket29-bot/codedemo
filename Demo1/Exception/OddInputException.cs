using System;
using System.Runtime.Serialization;

namespace Demo1.BusinessLayer
{
    [Serializable]
    internal class OddInputException : System.Exception
    {
        public OddInputException()
        {
        }

        public OddInputException(string message) : base(message)
        {
        }

        public OddInputException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected OddInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}