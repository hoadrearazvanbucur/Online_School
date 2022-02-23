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

        public StudentRepository(string dataBase)
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString(dataBase);
        }

        public List<Student> getAll()
        {
            string sql = "select * from student";
            return db.LoadData<Student, dynamic>(sql, new { }, connectionString);
        }
        public void add(Student student)
        {
            string sql = "insert into student(id, first_name, last_name, email, age) values (@id, @first_name, @last_name, @email, @age)";
            db.SaveData(sql, new { student.Id, student.First_name, student.Last_name, student.Email, student.Age}, connectionString);
        }
        public void deleteById(int id)
        {
            string sql = "delete from student where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }
        public void deleteByName(string first_name)
        {
            string sql = "delete from student where first_name=@first_name";
            db.SaveData(sql, new { first_name }, connectionString);
        }

        public void updateFirst_nameByFirst_name(string first_name, string newfirst_name)
        {
            string sql = "update student set first_name=@newfirst_name where first_name=@first_name";
            db.SaveData(sql, new { newfirst_name, first_name }, connectionString);
        }
        public void updateLast_nameByFirst_name(string first_name, string last_name)
        {
            string sql = "update student set last_name=@last_name where first_name=@first_name";
            db.SaveData(sql, new { last_name, first_name }, connectionString);
        }
        public void updateEmailByFirst_name(string first_name, string email)
        {
            string sql = "update student set email=@email where first_name=@first_name";
            db.SaveData(sql, new { email, first_name }, connectionString);
        }
        public void updateAgeByFirst_name(string first_name, int age)
        {
            string sql = "update student set age=@age where first_name=@first_name";
            db.SaveData(sql, new { age, first_name }, connectionString);
        }

        public Student getStudentById(int id)
        {
            string sql = "select * from student where id=@id";
            return db.LoadData<Student, dynamic>(sql, new { id }, connectionString)[0];
        }
        public Student getStudentByName(string first_name)
        {
            string sql = "select * from student where first_name=@first_name";
            return db.LoadData<Student, dynamic>(sql, new { first_name }, connectionString)[0];
        }
    }
}
