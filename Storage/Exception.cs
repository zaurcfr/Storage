using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class NoSpaceInMemoryException : ApplicationException
    {
        private string _message;
        public DateTime TimeException { get; set; }
        public NoSpaceInMemoryException()
        {
            _message = "NO SPACE IN MEMORY!";
        }
        public NoSpaceInMemoryException(string message)
        {
            TimeException = DateTime.Now;
            _message = message;
        }
        public override string Message
        {
            get { return _message; }
        }
    }
}
