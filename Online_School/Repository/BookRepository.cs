using Data_Acces;
using Microsoft.Extensions.Configuration;
using Online_School.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Repository
{
    public class BookRepository
    {
        private readonly string connectionString;
        private DataAcces db;

        public BookRepository(string dataBase)
        {
            db = new DataAcces();
            var builder = new ConfigurationBuilder().SetBasePath
            (@"D:\1_PROGRAMARE\C#\Baza_De_Date\Online_School\Online_School").AddJsonFile("appsettings.json");
            var config = builder.Build();
            this.connectionString = config.GetConnectionString(dataBase);
        }

        public List<Book> getAll()
        {
            string sql = "select * from book";
            return db.LoadData<Book, dynamic>(sql, new { }, connectionString);
        }
        public void add(Book book)
        {
            string sql = "insert into book(student_id,book_name,create_at) values(@student_id,@book_name,@create_at)";
            db.SaveData(sql, new {book.Student_id,book.Book_name,book.Create_at}, connectionString);
        }
        public void deleteById(int id)
        {
            string sql = "delete from book where id=@id";
            db.SaveData(sql, new { id }, connectionString);
        }
        public void deleteByName(string book_name)
        {
            string sql = "delete from book where book_name=@book_name";
            db.SaveData(sql, new { book_name }, connectionString);
        }

        public void updateBook_nameByName(string name, string newname)
        {
            string sql = "update book set book_name=@newname where book_name=@name";
            db.SaveData(sql, new { newname, name }, connectionString);
        }
        public void updateStudent_IdByName(string name, int newstudent_id)
        {
            string sql = "update book set student_id=@newstudent_id where book_name=@name";
            db.SaveData(sql, new { newstudent_id, name }, connectionString);
        }
        public void updateCreate_atByName(string name, DateTime create_at)
        {
            string sql = "update book set create_at=@create_at where book_name=@name";
            db.SaveData(sql, new { create_at, name }, connectionString);
        }

        public Book getBookById(int id)
        {
            string sql = "select * from book where id=@id";
            return db.LoadData<Book, dynamic>(sql, new { id }, connectionString)[0];
        }
        public Book getBookByName(string book_name)
        {
            string sql = "select * from book where book_name=@book_name";
            return db.LoadData<Book, dynamic>(sql, new { book_name }, connectionString)[0];
        }
    }
}
