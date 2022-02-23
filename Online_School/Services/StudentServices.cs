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
        public void create(Book book)
        {
            if (!this.exist(book.Student_id, book.Book_name, book.Create_at))
            {
                control.add(book);
            }
            else
            {
                throw new BookException("Aceasta carte exista");
            }
        }
        public void deleteById(int id)
        {
            if (this.exist(this.control.getBookById(id).Student_id, this.control.getBookById(id).Book_name, this.control.getBookById(id).Create_at))
            {
                control.deleteById(id);
            }
            else
            {
                throw new BookException("Aceasta carte nu exista");
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
                throw new BookException("Aceasta carte nu exista");
            }
        }

        public void updateBook_name(string name, string newname)
        {
            if (this.existName(name))
            {
                control.updateBook_nameByName(name, newname);
            }
            else
            {
                throw new BookException("Aceasta carte nu exista");
            }
        }
        public void updateStudent_id(string name, int student_id)
        {
            if (this.existName(name))
            {
                control.updateStudent_IdByName(name, student_id);
            }
            else
            {
                throw new BookException("Aceasta carte nu exista");
            }
        }
        public void updateCreate_at(string name, DateTime create_at)
        {
            if (this.existName(name))
            {
                control.updateCreate_atByName(name, create_at);
            }
            else
            {
                throw new BookException("Aceasta carte nu exista");
            }
        }

        public bool exist(int student_id, string book_name, DateTime create_at)
        {
            foreach (Book book in this.lista())
                if (book.Student_id == student_id && book.Book_name == book_name && book.Create_at == create_at)
                    return true;
            return false;
        }
        public bool existName(string name)
        {
            foreach (Book book in this.lista())
                if (book.Book_name == name)
                    return true;
            return false;
        }
        public bool existId(int id)
        {
            foreach (Book book in this.lista())
                if (book.Id == id)
                    return true;
            return false;
        }
    }
}
