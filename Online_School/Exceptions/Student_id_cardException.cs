using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Exceptions
{
    public class Student_id_cardException:Exception
    {
        public Student_id_cardException(string massage) : base(massage) { }
    }
}
