using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Exception
{
    internal class ZeroInputException : ApplicationException
    {
        public ZeroInputException(string message) : base(message)//pass the message to the base class
        {
        }
    }
}
