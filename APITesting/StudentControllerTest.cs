using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Practical18.Controllers;
using Practical18.Model;
using Practical18.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITesting
{
    [TestClass]
    public class StudentControllerTest
    {
        private Mock<IstudentRepository> _studentrepository;
        private Fixture _fixture;
        private StudentController _controller;
        public StudentControllerTest()
        {
            _fixture = new Fixture(); 
            _studentrepository = new Mock<IstudentRepository>();
        }
        [TestMethod]
        public void GetStudent()
        {
            var studentlist = _fixture.CreateMany<Student>(3).ToList(); 
            _studentrepository.Setup(repo=>repo.GetAllStudents()).Returns(studentlist);
            _controller= new StudentController(_studentrepository.Object);
            var result = _controller.ShowAllStudent();
            var obj = result as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);
        }
        [TestMethod]
        public void UpdateStudent()
        {
            var student = _fixture.Create<Student>();
            var studentviewmodel = _fixture.Create<StudentViewModel>();
            var studentid= _fixture.Create<int>();
            _studentrepository.Setup(repo => repo.UpdateStudent(studentid, studentviewmodel)).Returns(student);

            _controller = new StudentController(_studentrepository.Object);

            // Act
            var result = _controller.UpdateStudentRecord(studentid, studentviewmodel);

            // Assert
            var obj = result as ObjectResult;
            Assert.IsNotNull(obj);
            Assert.AreEqual(200, obj.StatusCode);
        }
    }
}
