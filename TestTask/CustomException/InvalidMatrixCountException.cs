using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.CustomException
{
    [Serializable]
    public class InvalidMatrixCountException : Exception
    {
        public InvalidMatrixCountException()
        {
        }

        public InvalidMatrixCountException(string message) : base(message)
        {
        }

        public InvalidMatrixCountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidMatrixCountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
