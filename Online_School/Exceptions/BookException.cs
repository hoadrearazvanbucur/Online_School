using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Exceptions
{
    public class BookException : Exception
    {
        public BookException(string massage) : base(massage) { }
    }
}
