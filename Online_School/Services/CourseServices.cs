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

        public CourseServices()
        {
            this.control = new CourseRepository();
        }

        public List<Course> lista()
        {
            return control.getAll();
        }

        public void create(Course course)
        {
            if (!this.lista().Contains(course))
            {
                control.add(course);
            }
            else
            {
                throw new Exception("");
            }
        }

        public void deleteById(int id)
        {
            if (this.lista().Contains(this.control.getCourseById(id)))
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
