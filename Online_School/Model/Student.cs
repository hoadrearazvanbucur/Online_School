using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Model
{
    public class Student : IComparable
    {
        private int id, age;
        private string first_name, last_name, email;
        
        public Student(int id,int age,string first_name,string last_name,string email)
        {
            this.id = id;
            this.age = age;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
        }
        public Student(int age, string first_name, string last_name, string email)
        {
            this.age = age;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
        }

        public override string ToString() => this.id + "," + this.age + "," + this.first_name + "," + this.last_name + "," + this.email;
        public override bool Equals(object obj) => (obj as Student).ToString() == this.ToString();
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        public string First_name
        {
            get => this.first_name;
            set => this.first_name = value;
        }
        public string Last_name
        {
            get => this.last_name;
            set => this.last_name = value;
        }
        public string Email
        {
            get => this.email;
            set => this.email = value;
        }
    }
}
