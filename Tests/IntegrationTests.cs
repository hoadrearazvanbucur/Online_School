using Online_School.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class IntegrationTests
    {
        private readonly ITestOutputHelper outputHelper;
        private BookServices book;
        private CourseServices course;
        private EnrolementServices enrolement;
        private Student_id_cardServices student_id_card;
        private StudentServices student;

        public IntegrationTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            //this.book= new BookServices("Test");
            //this.course =new CourseServices();
            //this.enrolement =new EnrolementServices();
            //this.student_id_card =new Student_id_cardServices();
            //this.student =new StudentServices();
        }

        [Fact]
        public void integration()
        {

        }
    }
}
