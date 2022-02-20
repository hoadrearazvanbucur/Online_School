using Online_School.Model;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Services
{
    public class Student_id_cardServices
    {
        public Student_id_cardRepository control;

        public Student_id_cardServices()
        {
            this.control = new Student_id_cardRepository();
        }

        public List<Student_id_card> lista()
        {
            return control.getAll();
        }

        public void create(Student_id_card student_id_card)
        {
            if (!this.lista().Contains(student_id_card))
            {
                control.add(student_id_card);
            }
            else
            {
                throw new Exception("");
            }
        }

        public void deleteById(int id)
        {
            if (this.lista().Contains(this.control.getStudent_id_cardById(id)))
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
