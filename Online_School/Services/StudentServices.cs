using Online_School.Exceptions;
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

        public StudentServices(string dataBase)
        {
            this.control = new StudentRepository(dataBase);
        }

        public List<Student> lista()
        {
            return control.getAll();
        }
        public void create(Student student)
        {
            if (!this.exist(student.First_name, student.Last_name, student.Email, student.Age))
            {
                control.add(student);
            }
            else
            {
                throw new StudentException("Acest student exista");
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
                throw new StudentException("Acest student nu exista");
            }
        }
        public void deleteByFirst_name(string first_name)
        {
            if (this.existFirst_name(first_name))
            {
                control.deleteByName(first_name);
            }
            else
            {
                throw new StudentException("Acest student nu exista");
            }
        }

        public void updateFirst_name(string first_name, string newFirst_name)
        {
            if (this.existFirst_name(first_name))
            {
                control.updateFirst_nameByFirst_name(first_name, newFirst_name);
            }
            else
            {
                throw new StudentException("Acest student nu exista");
            }
        }
        public void updateLast_name(string first_name, string newLast_name)
        {
            if (this.existFirst_name(first_name))
            {
                control.updateLast_nameByFirst_name(first_name, newLast_name);
            }
            else
            {
                throw new StudentException("Acest student nu exista");
            }
        }
        public void updateEmail(string first_name, string newEmail)
        {
            if (this.existFirst_name(first_name))
            {
                control.updateEmailByFirst_name(first_name, newEmail);
            }
            else
            {
                throw new StudentException("Acest student nu exista");
            }
        }
        public void updateAge(string first_name, int age)
        {
            if (this.existFirst_name(first_name))
            {
                control.updateAgeByFirst_name(first_name, age);
            }
            else
            {
                throw new StudentException("Acest student nu exista");
            }
        }


        public bool exist(string first_name, string last_name, string email, int age)
        {
            foreach (Student student in this.lista())
                if (student.First_name == first_name && student.Last_name == last_name && student.Email == email && student.Age == age)
                    return true;
            return false;
        }
        public bool existFirst_name(string first_name)
        {
            foreach (Student student in this.lista())
                if (student.First_name == first_name)
                    return true;
            return false;
        }
        public bool existId(int id)
        {
            foreach (Student student in this.lista())
                if (student.Id == id)
                    return true;
            return false;
        }
        public bool exist(string first_name, string first_name_age)
        {
            foreach (Student student in this.lista())
                if (student.First_name == first_name && student.Age+student.First_name == first_name_age)
                    return true;
            return false;
        }
        public Student studentLogare(string first_name, string first_name_age)
        {
            foreach (Student student in this.lista())
                if (student.First_name == first_name && student.Age + student.First_name == first_name_age)
                    return student;
            return null;
        }
    }
}
