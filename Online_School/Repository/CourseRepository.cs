using Data_Acces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Online_School.Model;


namespace Online_School.Repository
{
    public class CourseRepository
    {
        private readonly string connectionString;
        private DataAcces db;

        public CourseRepository()
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School\appsettings.json").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString("Default");
        }

        public List<Course> getAll()
        {
            string sql = "select * from course";
            return db.LoadData<Course, dynamic>(sql, new { }, connectionString);
        }

        public void add(Course course)
        {
            string sql = "insert into (name,departament) values(@name,@departament)";
            db.SaveData(sql, new {course.Name, course.Departament},connectionString);
        }

        public void deleteById(int id)
        {
            string sql = "delete from course where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }

        public void updateNameById(int id, string name)
        {
            string sql = "update course set name=@name where id=@id";
            db.SaveData(sql, new { name, id }, connectionString);
        }

        public void updateDepartamentById(int id, string departament)
        {
            string sql = "update course set departament=@departament where id=@id";
            db.SaveData(sql, new { departament, id }, connectionString);
        }

        public Course getCourseById(int id)
        {
            string sql = "select * from course where id=@id";
            return db.LoadData<Course, dynamic>(sql, new { id }, connectionString)[0];
        }

        public void deleteByName(string course_name)
        {
            string sql = "delete from course where name=@name";
            db.SaveData(sql, new { course_name }, connectionString);
        }

        public Course getCourseByName(string name)
        {
            string sql = "select * from course where name=@name";
            return db.LoadData<Course, dynamic>(sql, new { name }, connectionString)[0];
        }
    }
}
