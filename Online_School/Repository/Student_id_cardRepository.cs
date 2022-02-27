using Data_Acces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Online_School.Model;


namespace Online_School.Repository
{
    public class Student_id_cardRepository
    {
        private readonly string connectionString;
        private DataAcces db;

        public Student_id_cardRepository(string dataBase)
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString(dataBase);
        }

        public List<Student_id_card> getAll()
        {
            string sql = "select id,student_id,card_number from student_id_card";
            return db.LoadData<Student_id_card, dynamic>(sql, new { }, connectionString);
        }
        public void add(Student_id_card Student_id_card)
        {
            string sql = "insert into student_id_card(student_id, card_number) values (@student_id, @card_number) ";
            db.SaveData(sql, new { Student_id_card.Student_id, Student_id_card.Card_number }, connectionString);
        }
        public void deleteById(int id)
        {
            string sql = "delete from student_id_card where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }
        public void deleteByStudent_id(int student_id)
        {
            string sql = "delete from student_id_card where student_id=@student_id";
            db.SaveData(sql, new { student_id }, connectionString);
        }

        public Student_id_card getStudent_id_cardById(int id)
        {
            string sql = "select * from student_id_card where id=@id";
            return db.LoadData<Student_id_card, dynamic>(sql, new { id }, connectionString)[0];
        }
        public Student_id_card getStudent_id_cardByStudent_id(int student_id)
        {
            string sql = "select * from student_id_card where student_id=@student_id";
            return db.LoadData<Student_id_card, dynamic>(sql, new { student_id }, connectionString)[0];
        }
    }
}
