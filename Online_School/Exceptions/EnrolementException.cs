using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Exceptions
{
    public class EnrolementException : Exception
    {
        public EnrolementException(string massage) : base(massage) { }
}
}
