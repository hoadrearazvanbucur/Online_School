using Online_School.Exceptions;
using Online_School.Model;
using Online_School.Services;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class EnrolementTests
    {
        private readonly ITestOutputHelper outputHelper;
        private EnrolementServices enrolement;
        public EnrolementTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.enrolement = new EnrolementServices("Test");
        }

        [Fact]
        public void add_delete()
        {
            enrolement.create(new Enrolement(4,4,new DateTime(2021,04,25)));
            Assert.Equal("Aceasta inscriere exista", Assert.Throws<EnrolementException>(() => enrolement.create(new Enrolement(4, 4, new DateTime(2021, 04, 25)))).Message);
            enrolement.deleteByStudent_idANDCourse_id(4,4);
            Assert.Equal("Aceasta inscriere nu exista", Assert.Throws<EnrolementException>(() => enrolement.deleteByStudent_idANDCourse_id(4, 4)).Message);
        }
    }
}
