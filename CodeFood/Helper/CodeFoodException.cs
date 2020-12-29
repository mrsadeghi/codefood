using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFood.Helper
{
    public class CodeFoodException : Exception
    {
        public CodeFoodException()
        {
        }

        public CodeFoodException(string message)
            : base(message)
        {
        }

        public CodeFoodException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
