using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Exceptions
{
    public class CourseException :Exception
    {
        public CourseException(string massage) : base(massage) { }
    }
}
