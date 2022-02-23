using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Exceptions
{
    public class StudentException :Exception
    {
        public StudentException(string massage) : base(massage) { }
}
}
