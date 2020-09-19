using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaParcial1.Controllers;

namespace UTPracticaParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();
            //Act
            var ListaEstudiante = studentsController.GetStudents();
            //Assert
            Assert.IsNotNull(ListaEstudiante);
        }
    }
}
