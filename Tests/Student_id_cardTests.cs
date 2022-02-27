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
    public class Student_id_cardTests
    {
        private readonly ITestOutputHelper outputHelper;
        private Student_id_cardServices student_id_card;
        public Student_id_cardTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.student_id_card = new Student_id_cardServices("Test");
        }

        [Fact]
        public void add_delete()
        {
            student_id_card.create(new Student_id_card(1,"9"));
            Assert.Equal("Acest card exista", Assert.Throws<Student_id_cardException>(() => student_id_card.create(new Student_id_card(1, "9"))).Message);
            student_id_card.deleteByStudent_id(1);
            Assert.Equal("Acest card nu exista", Assert.Throws<Student_id_cardException>(() => student_id_card.deleteByStudent_id(1)).Message);
        }
    }
}
