using FechasYEdades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestFechaYEdades
{
    /// <summary>
    /// Pruebas de Fechas
    /// </summary>
    [TestClass]
    public class TestDate
    {
        /// <summary>
        /// Comprueba que el resultado sea correcto con unos valores dentro de los parametros
        /// </summary>
        [TestMethod]
        public void TestDateOne()
        {
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(1, 1, 21);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 738221 + ". Y estos los años " + 2021;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        [TestMethod]
        public void TestDateTwo()
        {
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(1, 1, 21);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 7123 + ". Y estos los años " + 2;
            //Assert
            Assert.AreNotEqual(text, expectedText);
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
            string expectedText = "Estos son los dias " + 730993 + ". Y estos los años " + 2002;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
    }
    /// <summary>
    /// Serie de pruebas con fechas erroneas dentro de los parametros
    /// </summary>
    [TestClass]
    public class TestWrongDays
    {
        /// <summary>
        /// Prueba con día negativo
        /// </summary>
        [TestMethod]
        public void TestNegativeDay()
        {
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(-1, 12, 21);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 7123 + ". Y estos los años " + 2;
            //Assert
            Assert.AreNotEqual(text, expectedText);
        }
        [TestMethod]
        /// <summary>
        ///Prueba con dia imposible para ciertos meses
        /// </summary>
        public void TestWrongDaysPerMonth()
        {
            Functions codificacion = new Functions();
            //Arrange
            DateTime hoy = DateTime.Today;
            DateTime date = new DateTime(30, 2, 1992);
            //Act
            string text = Functions.DiffDate(date, hoy);
            string expectedText = "Estos son los dias " + 727599 + ". Y estos los años " + 1992;
            //Assert
            Assert.AreNotEqual(text, expectedText);
        }
    }
}
