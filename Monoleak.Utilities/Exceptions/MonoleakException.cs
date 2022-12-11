using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Utilities.Exceptions
{
    public class MonoleakException : Exception
    {
        public MonoleakException()
        {

        }
        public MonoleakException(string message)
            : base(message)
        {

        }
        public MonoleakException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
