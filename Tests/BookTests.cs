using Online_School.Exceptions;
using Online_School.Model;
using Online_School.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class BookTests
    {
        private readonly ITestOutputHelper outputHelper;
        private BookServices book;
        public BookTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.book = new BookServices("Test");
        }

        [Fact]
        public void add_delete()
        {
            book.create(new Book(1, "test", new DateTime(2020, 4, 17)));
            Assert.Equal("Aceasta carte exista", Assert.Throws<BookException>(() => book.create(new Book(1, "test", new DateTime(2020, 4, 17)))).Message);
            book.deleteByName("test");
            Assert.Equal("Aceasta carte nu exista", Assert.Throws<BookException>(() => book.deleteByName("test")).Message);
        }

        [Fact]
        public void update()
        {
            Book carte = new Book(1, "test", new DateTime(2020, 4, 17));
            book.create(carte);
            Assert.Equal("Aceasta carte exista", Assert.Throws<BookException>(() => book.create(carte)).Message);

            book.updateBook_name("test" , "test1");
            Assert.Equal("Aceasta carte nu exista", Assert.Throws<BookException>(() => book.updateBook_name("test","test2")).Message);
            book.updateStudent_id("test1", 4);
            Assert.Equal("Aceasta carte nu exista", Assert.Throws<BookException>(() => book.updateStudent_id("test",4)).Message);
            book.updateCreate_at("test1", new DateTime(2020, 4, 27));
            Assert.Equal("Aceasta carte nu exista", Assert.Throws<BookException>(() => book.updateCreate_at("test",carte.Create_at)).Message);

            carte.Book_name = "test1";
            book.deleteByName(carte.Book_name);
            Assert.Equal("Aceasta carte nu exista", Assert.Throws<BookException>(() => book.deleteByName(carte.Book_name)).Message);
        }

    }
}
