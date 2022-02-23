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
    public class CourseTests
    {
        private readonly ITestOutputHelper outputHelper;
        private CourseServices course;
        public CourseTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.course = new CourseServices("Test");
        }

        [Fact]
        public void add_delete()
        {
            course.create(new Course("testName","testDepartament"));
            Assert.Equal("Aceast curs exista", Assert.Throws<CourseException>(() => course.create(new Course("testName", "testDepartament"))).Message);
            course.deleteByName("testName");
            Assert.Equal("Aceast curs nu exista", Assert.Throws<CourseException>(() => course.deleteByName("testName")).Message);
        }

        [Fact]
        public void update()
        {
            Course curs = new Course("testName", "testDepartament");
            course.create(curs);
            Assert.Equal("Aceast curs exista", Assert.Throws<CourseException>(() => course.create(curs)).Message);

            course.updateName("testName", "testName1");
            Assert.Equal("Aceast curs nu exista", Assert.Throws<CourseException>(() => course.updateName("testName", "testName2")).Message);
            course.updateDepartament("testName1", "testDepartament1");
            Assert.Equal("Aceast curs nu exista", Assert.Throws<CourseException>(() => course.updateDepartament("testName", "testDepartament1")).Message);

            curs.Name = "testName1";
            course.deleteByName(curs.Name);
            Assert.Equal("Aceast curs nu exista", Assert.Throws<CourseException>(() => course.deleteByName(curs.Name)).Message);
        }
    }
}
