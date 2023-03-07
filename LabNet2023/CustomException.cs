using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023
{
    public class CustomException : Exception
    {
        private string message;
        public override string Message { get { return base.Message + " " + this.message; } }

        public CustomException() : base("Custom exception") 
        { 

        }

        public CustomException(string message) : base("Custom exception")
        {
            this.message = message;
        }
    }
}
