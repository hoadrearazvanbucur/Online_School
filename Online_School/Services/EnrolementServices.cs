using Online_School.Exceptions;
using Online_School.Model;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Services
{
    public class EnrolementServices
    {
        public EnrolementRepository control;

        public EnrolementServices(string dataBase)
        {
            this.control = new EnrolementRepository(dataBase);
        }

        public List<Enrolement> lista()
        {
            return control.getAll();
        }
        public void create(Enrolement enrolement)
        {
            if(!this.exist(enrolement.Student_id,enrolement.Course_id))
            {
                control.add(enrolement);
            }
            else
            {
                throw new EnrolementException("Aceasta inscriere exista");
            }
        }
        public void deleteByStudent_idANDCourse_id(int student_id,int course_id)
        {
            if(this.exist(student_id,course_id))
            {
                control.deleteByStudent_idANDCourse_id(student_id, course_id);
            }
            else
            {
                throw new EnrolementException("Aceasta inscriere nu exista");
            }
        }

        public bool exist(int student_id, int course_id)
        {
            foreach (Enrolement enrolement in this.lista())
                if (enrolement.Student_id == student_id && enrolement.Course_id == course_id)
                    return true;
            return false;
        }
        public bool existCourse_id(int course_id)
        {
            foreach (Enrolement enrolement in this.lista())
                if (enrolement.Course_id == course_id)
                    return true;
            return false;
        }
        public bool existStudent_id(int student_id)
        {
            foreach (Enrolement enrolement in this.lista())
                if (enrolement.Student_id == student_id)
                    return true;
            return false;
        }

    }
}
