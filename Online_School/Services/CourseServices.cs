using Online_School.Exceptions;
using Online_School.Model;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Services
{
    public class CourseServices
    {
        public CourseRepository control;

        public CourseServices(string dataBase)
        {
            this.control = new CourseRepository(dataBase);
        }

        public List<Course> lista()
        {
            return control.getAll();
        }
        public void create(Course course)
        {
            if (!this.exist(course.Name, course.Departament))
            {
                control.add(course);
            }
            else
            {
                throw new CourseException("Aceast curs exista");
            }
        }
        public void deleteById(int id)
        {
            if (!this.exist(this.control.getCourseById(id).Name, this.control.getCourseById(id).Departament))
            {
                control.deleteById(id);
            }
            else
            {
                throw new CourseException("Aceast curs nu exista");
            }
        }
        public void deleteByName(string name)
        {
            if (this.existName(name))
            {
                control.deleteByName(name);
            }
            else
            {
                throw new CourseException("Aceast curs nu exista");
            }
        }

        public void updateName(string name, string newname)
        {
            if (this.existName(name))
            {
                control.updateNameByName(name, newname);
            }
            else
            {
                throw new CourseException("Aceast curs nu exista");
            }
        }
        public void updateDepartament(string name, string departament)
        {
            if (this.existName(name))
            {
                control.updateDepartamentByName(name, departament);
            }
            else
            {
                throw new CourseException("Aceast curs nu exista");
            }
        }


        public bool exist(string name,string departament)
        {
            foreach (Course course in this.lista())
                if (course.Name == name && course.Departament == departament) 
                    return true;
            return false;
        }
        public bool existName(string name)
        {
            foreach (Course course in this.lista())
                if (course.Name == name)
                    return true;
            return false;
        }
        public bool existId(int id)
        {
            foreach (Course course in this.lista())
                if (course.Id == id)
                    return true;
            return false;
        }
        public int getId(string name,string departament)
        {
            foreach (Course course in this.lista())
                if (course.Name == name && course.Departament == departament)
                    return course.Id;
            return -1;
        }
        public Course getCourseById(int id)
        {
            foreach (Course course in this.lista())
                if (course.Id == id)
                    return course;
            return null;
        }
    }
}
