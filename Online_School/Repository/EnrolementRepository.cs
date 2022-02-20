using Data_Acces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Online_School.Model;


namespace Online_School.Repository
{
    public class EnrolementRepository
    {
        private readonly string connectionString;
        private DataAcces db;

        public EnrolementRepository()
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School\appsettings.json").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString("Default");
        }

        public List<Enrolement> getAll()
        {
            string sql = "select * from enrolement";
            return db.LoadData<Enrolement, dynamic>(sql, new { }, connectionString);
        }

        public void add(Enrolement enrolement)
        {
            string sql = "insert into (student_id,course_id,create_at) values(@student_id,@course_id,@create_at)";
            db.SaveData(sql, new { enrolement.Student_id, enrolement.Course_id, enrolement.Create_at }, connectionString);
        }

        public void deleteById(int id)
        {
            string sql = "delete from enrolement where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }

        public void updateStudent_idById(int id, string student_id)
        {
            string sql = "update enrolement set student_id=@student_id where id=@id";
            db.SaveData(sql, new { student_id, id }, connectionString);
        }

        public void updateCourse_idById(int id, int course_id)
        {
            string sql = "update enrolement set course_id=@course_id where id=@id";
            db.SaveData(sql, new { course_id, id }, connectionString);
        }

        public void updateCreate_atById(int id, string create_at)
        {
            string sql = "update enrolement set create_at=@create_at where id=@id";
            db.SaveData(sql, new { create_at, id }, connectionString);
        }

        public Enrolement getEnrolementById(int id)
        {
            string sql = "select * from enrolement where id=@id";
            return db.LoadData<Enrolement, dynamic>(sql, new { id }, connectionString)[0];
        }
    }
}
