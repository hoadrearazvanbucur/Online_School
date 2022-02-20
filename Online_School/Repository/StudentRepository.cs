using Data_Acces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Online_School.Model;


namespace Online_School.Repository
{
    public class StudentRepository
    {
        private readonly string connectionString;
        private DataAcces db;

        public StudentRepository()
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School\appsettings.json").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString("Default");
        }

        public List<Student> getAll()
        {
            string sql = "select * from student";
            return db.LoadData<Student, dynamic>(sql, new { }, connectionString);
        }

        public void add(Student student)
        {
            string sql = "insert into (first_name,last_name,email,age) values(@first_name,@last_name,@email,@age)";
            db.SaveData(sql, new {student.First_name,student.Last_name,student.Email,student.Age }, connectionString);
        }

        public void deleteById(int id)
        {
            string sql = "delete from student where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }

        public void updateFirst_nameById(int id, string first_name)
        {
            string sql = "update student set first_name=@first_name where id=@id";
            db.SaveData(sql, new { first_name, id }, connectionString);
        }
        public void updateLast_nameById(int id, string last_name)
        {
            string sql = "update student set last_name=@last_name where id=@id";
            db.SaveData(sql, new { last_name, id }, connectionString);
        }
        public void updateEmailById(int id, string email)
        {
            string sql = "update student set email=@email where id=@id";
            db.SaveData(sql, new { email, id }, connectionString);
        }

        public void updateAgeById(int id, int age)
        {
            string sql = "update student set age=@age where id=@id";
            db.SaveData(sql, new { age, id }, connectionString);
        }


        public Student getStudentById(int id)
        {
            string sql = "select * from student where id=@id";
            return db.LoadData<Student, dynamic>(sql, new { id }, connectionString)[0];
        }

    }
}
