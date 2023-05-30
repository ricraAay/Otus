using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.QuadraticEquation
{
    internal class NoRealValuesException : Exception
    {
        public NoRealValuesException(string message) : base(message) { }
    }
}
