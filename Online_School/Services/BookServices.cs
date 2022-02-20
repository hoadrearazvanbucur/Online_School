using Online_School.Model;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Services
{
    public class BookServices
    {
        public BookRepository control;

        public BookServices()
        {
            this.control = new BookRepository();
        }

        public List<Book> lista()
        {
            return control.getAll();
        }

        public void create(Book book)
        {
            if (!this.lista().Contains(book))
            {
                control.add(book);
            }
            else
            {
                throw new Exception("");
            }
        }

        public void deleteById(int id)
        {
            if (this.lista().Contains(this.control.getBookById(id)))
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
