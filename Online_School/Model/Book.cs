using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Model
{
    public class Book : IComparable
    {
        int id, student_id;
        string book_name, create_at;

        public Book(int id,int student_id,string book_name,string create_at)
        {
            this.id = id;
            this.student_id = student_id;
            this.book_name = book_name;
            this.create_at = create_at;
        }
        public Book(int student_id, string book_name, string create_at)
        {
            this.student_id = student_id;
            this.book_name = book_name;
            this.create_at = create_at;
        }

        public override string ToString() => this.id + "," + this.student_id + "," + this.book_name + "," + this.create_at;
        public override bool Equals(object obj) => (obj as Book).ToString() == this.ToString();
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
        public string Book_name
        {
            get => this.book_name;
            set => this.book_name = value;
        }
        public string Create_at
        {
            get => this.create_at;
            set => this.create_at = value;
        }
    }
}
