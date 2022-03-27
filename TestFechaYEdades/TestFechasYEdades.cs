using FechasYEdades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestFechaYEdades
{
    [TestClass]
    public class TestFechasYEdades
    {
        [TestMethod]
        public void TestDateOne()
        {
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(1, 1, 21);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 738220 + ". Y estos los años " + 2021;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        [TestMethod]
        public void TestDateTwo()
        {
            //Tiene que dar error.
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(1, 1, 21);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 7123 + ". Y estos los años " + 2;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        [TestMethod]
        public void TestDateThree()
        {
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(20, 11, 5);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 730992 + ". Y estos los años " + 2002;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        [TestMethod]
        public void TestDateFour()
        {
            //Tiene que dar error.
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(-1, 12, 21);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 7123 + ". Y estos los años " + 2;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        [TestMethod]
        public void TestDateFive()
        {
            //Tiene que dar error.
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(30, 2, 1992);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 727599 + ". Y estos los años " + 1992;
            //Assert
            Assert.AreEqual(text, expectedText);
        }

    }

}
