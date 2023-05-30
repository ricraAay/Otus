using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.QuadraticEquation
{
    internal class InvalidParameterFormatException : Exception
    {
        public InvalidParameterFormatException(string message) : base(message) { }
    }
}
