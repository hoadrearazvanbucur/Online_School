using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Model
{
    public class Enrolement: IComparable
    {
        private int student_id, course_id;
        private DateTime create_at;
        public Enrolement(int student_id,int course_id, DateTime create_at)
        {
            this.student_id = student_id;
            this.course_id = course_id;
            this.create_at = create_at;
        }

        public override string ToString() => this.student_id + "," + this.course_id + "," + this.create_at;
        public override bool Equals(object obj) => (obj as Enrolement).ToString() == this.ToString();
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Student_id
        {
            get => this.student_id;
            set => this.student_id = value;
        }
        public int Course_id
        {
            get => this.course_id;
            set => this.course_id = value;
        }
        public DateTime Create_at
        {
            get => this.create_at;
            set => this.create_at = value;
        }
    }
}
