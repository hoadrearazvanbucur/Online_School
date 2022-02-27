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
    public class StudentTests
    {
        private readonly ITestOutputHelper outputHelper;
        private StudentServices student;
        public StudentTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.student = new StudentServices("Test");
        }

        [Fact]
        public void add_delete()
        {
            student.create(new Student(1,"firstTest","lastTest","emailTest"));
            Assert.Equal("Acest student exista", Assert.Throws<StudentException>(() => student.create(new Student(1, "firstTest", "lastTest", "emailTest"))).Message);
            student.deleteByFirst_name("firstTest");
            Assert.Equal("Acest student nu exista", Assert.Throws<StudentException>(() => student.deleteByFirst_name("firstTest")).Message);
        }

        [Fact]
        public void update()
        {
            Student s1 = new Student(1, "firstTest", "lastTest", "emailTest");
            student.create(s1);
            Assert.Equal("Acest student exista", Assert.Throws<StudentException>(() => student.create(s1)).Message);

            student.updateFirst_name("firstTest", "firstTest1");
            Assert.Equal("Acest student nu exista", Assert.Throws<StudentException>(() => student.updateFirst_name("firstTest", "firstTest1")).Message);

            student.updateLast_name("firstTest1", "lastTest1");
            Assert.Equal("Acest student nu exista", Assert.Throws<StudentException>(() => student.updateLast_name("firstTest", "lastTest1")).Message);

            student.updateEmail("firstTest1", "emailTest1");
            Assert.Equal("Acest student nu exista", Assert.Throws<StudentException>(() => student.updateEmail("firstTest", "emailTest1")).Message);

            student.updateAge("firstTest1", 99);
            Assert.Equal("Acest student nu exista", Assert.Throws<StudentException>(() => student.updateAge("firstTest", 99)).Message);

            s1.First_name = "firstTest1";
            student.deleteByFirst_name(s1.First_name);
            Assert.Equal("Acest student nu exista", Assert.Throws<StudentException>(() => student.deleteByFirst_name(s1.First_name)).Message);
        }
    }
}
