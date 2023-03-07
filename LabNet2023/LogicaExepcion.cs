using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public class LogicException : Exception
    {
        public LogicException() : base()
        {

        }

        public LogicException(string message) : base(message)
        {

        }

        public LogicException(string messege, Exception innerException) : base(messege, innerException)
        {

        }
    }
}
