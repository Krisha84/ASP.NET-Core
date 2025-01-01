using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestB
{
    class StringsNotEqualException : Exception
    {
        public StringsNotEqualException(string message) : base(message) { }
    }
}
