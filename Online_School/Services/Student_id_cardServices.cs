using Online_School.Exceptions;
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

        public Student_id_cardServices(string dataBase)
        {
            this.control = new Student_id_cardRepository(dataBase);
        }

        public List<Student_id_card> lista()
        {
            return control.getAll();
        }
        public void create(Student_id_card student_id_card)
        {
            if (!this.exist(student_id_card.Student_id, student_id_card.Card_number))
            {
                control.add(student_id_card);
            }
            else
            {
                throw new Student_id_cardException("Acest card exista");
            }
        }
        public void deleteById(int id)
        {
            if (this.existId(id))
            {
                control.deleteById(id);
            }
            else
            {
                throw new Student_id_cardException("Acest card nu exista");
            }
        }
        public void deleteByStudent_id(int student_id)
        {
            if (this.existStudent_id(student_id))
            {
                control.deleteByStudent_id(student_id);
            }
            else
            {
                throw new Student_id_cardException("Acest card nu exista");
            }
        }      

        public bool exist(int student_id, string card_number)
        {
            foreach (Student_id_card student_id_card in this.lista())
                if (student_id_card.Student_id==student_id && student_id_card.Card_number==card_number)
                    return true;
            return false;
        }
        public bool existStudent_id(int student_id)
        {
            foreach (Student_id_card student_id_card in this.lista())
                if (student_id_card.Student_id==student_id)
                    return true;
            return false;
        }
        public bool existId(int id)
        {
            foreach (Student_id_card student_id_card in this.lista())
                if (student_id_card.Id == id)
                    return true;
            return false;
        }
    }
}
