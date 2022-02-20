using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Model
{
    public class Course : IComparable
    {
        private int id;
        private string name, departament;

        public Course(int id,string name, string departament)
        {
            this.id = id;
            this.name = name;
            this.departament = departament;
        }
        public Course(string name, string departament)
        {
            this.name = name;
            this.departament = departament;
        }

        public override string ToString() => this.id + "," + this.name + "," + this.departament;
        public override bool Equals(object obj) => (obj as Course).ToString() == this.ToString();
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public string Departament
        {
            get => this.departament;
            set => this.departament = value;
        }
    }
}
