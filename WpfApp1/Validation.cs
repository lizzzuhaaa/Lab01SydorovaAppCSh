using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Sydorova
{
    internal class Validation: Exception
    {
        private string _message; 

        public Validation(string message) 
        {
            this._message = message;
        }
        public Validation(string message, DateTime date) : this("Invalid Date due to incorrect age")
        {
        }
        public Validation(string message, string email) : this("Your email is invalid format")
        {
        }

        public override string Message 
        {
            get { return _message; }
        }
    }
}
