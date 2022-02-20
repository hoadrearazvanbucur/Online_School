using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Model
{
    public class Student_id_card : IComparable
    {
        private int id, student_id, card_number;
        
        public Student_id_card(int id,int student_id,int card_number)
        {
            this.id = id;
            this.student_id = student_id;
            this.card_number = card_number;
        }
        public Student_id_card(int student_id, int card_number)
        {
            this.student_id = student_id;
            this.card_number = card_number;
        }

        public override string ToString() => this.id + "," + this.student_id + "," + this.card_number;
        public override bool Equals(object obj) => (obj as Student_id_card).ToString() == this.ToString();
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public int Student_id
        {
            get => this.student_id;
            set => this.student_id = value;
        }
        public int Card_number
        {
            get => this.card_number;
            set => this.card_number = value;
        }
    }
}
