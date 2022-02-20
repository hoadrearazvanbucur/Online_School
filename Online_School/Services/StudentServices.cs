using Online_School.Model;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Services
{
    public class StudentServices
    {
        public StudentRepository control;

        public StudentServices()
        {
            this.control = new StudentRepository();
        }

        public List<Student> lista()
        {
            return control.getAll();
        }

        public void create(Student student)
        {
            if (!this.lista().Contains(student))
            {
                control.add(student);
            }
            else
            {
                throw new Exception("");
            }
        }

        public void deleteById(int id)
        {
            if (this.lista().Contains(this.control.getStudentById(id)))
            {
                control.deleteById(id);
            }
            else
            {
                throw new Exception("");
            }
        }
    }
}
