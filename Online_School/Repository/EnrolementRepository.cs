using Data_Acces;
using Microsoft.Extensions.Configuration;
using Online_School.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace Online_School.Repository
{
    public class EnrolementRepository
    {
        private readonly string connectionString;
        private DataAcces db;


        public EnrolementRepository(string dataBase)
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString(dataBase);
        }

        public List<Enrolement> getAll()
        {
            string sql = "select * from enrolement";
            return db.LoadData<Enrolement, dynamic>(sql, new { }, connectionString);
        }


        public void add(Enrolement enrolement)
        {
            string sql = "insert into enrolement(student_id, course_id, create_at)  values (@student_id,@course_id,@create_at)";
            db.SaveData(sql, new {enrolement.Student_id,enrolement.Course_id,enrolement.Create_at}, connectionString);
        }
        public void deleteByStudent_idANDCourse_id(int student_id,int course_id)
        {
            string sql = "delete from enrolement where student_id=@student_id and course_id=@course_id";
            db.SaveData(sql, new { student_id ,course_id}, connectionString);
        }

        public Enrolement getEnrolementByStudent_Id(int student_id)
        {
            string sql = "select * from enrolement where id=@id";
            return db.LoadData<Enrolement, dynamic>(sql, new { student_id }, connectionString)[0];
        }
        public Enrolement getEnrolementByCourse_id(int course_id)
        {
            string sql = "select * from enrolement where course_id=@course_id";
            return db.LoadData<Enrolement, dynamic>(sql, new { course_id }, connectionString)[0];
        }
    }
}
