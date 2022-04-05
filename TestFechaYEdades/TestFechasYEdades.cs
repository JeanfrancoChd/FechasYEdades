using FechasYEdades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestFechaYEdades
{
    /// <summary>
    /// Pruebas de Fechas
    /// </summary>
    [TestClass]
    public class TestDateDC
    {
        /// <summary>
        /// Comprueba que el resultado sea correcto con unos valores dentro de los parametros
        /// </summary>
        [TestMethod]
        public void TestDateDCOne()
        {
            //Arrange
            DateTime hoy = new DateTime(2022, 04, 4);
            DateTime date = new DateTime(2021,1,21);
            bool negative = false;
            //Act
            string text = Functions.DiffDate(date, hoy, negative);
            string expectedText = "Diferencia con la fecha actual en dias: " + 1231 + ". Y en años: " + 1 + ".";
            //Assert
            Assert.AreNotEqual(text, expectedText);
        }
        /// <summary>
        /// Comprueba que la operacion se realiza bien, haciendose mal 
        /// </summary>
        [TestMethod]
        public void TestDateDCTwo()
        {
            //Arrange
            DateTime hoy = new DateTime(2022, 04, 4);
            DateTime date = new DateTime(1, 1, 21);
            bool negative = false;
            //Act
            string text = Functions.DiffDate(date, hoy, negative);
            string expectedText = "Diferencia con la fecha actual en dias: " + 12231 + ". Y en años: " + 123123 + ".";
            //Assert
            Assert.AreNotEqual(text, expectedText);
        }
        /// <summary>
        /// Comprobacion normal de fechas DC
        /// </summary>
        [TestMethod]
        public void TestDateDCThree()
        {
            //Arrange
            DateTime hoy = new DateTime(2022,04,4);
            DateTime date = new DateTime(2020,11,05);
            bool negative = false;
            //Act
            string text = Functions.DiffDate(date, hoy, negative);
            string expectedText = "Diferencia con la fecha actual en dias: " + 515 + ". Y en años: " + 2 + ".";
            //Assert
            Assert.AreEqual(text, expectedText);
        }
    }

    /// <summary>
    /// Compurueba la diferencia entre las dos fechas inciales.
    /// </summary>
    [TestClass]
    public class TestDatesDiff
    {
        /// <summary>
        /// Comprobar Diferencia entre fechas
        /// </summary>
        [TestMethod]
        public void TestDateDatesDiffOne()
        {
            //Arrange
            DateTime dateOne = new DateTime(2004, 4, 22);
            DateTime dateTwo = new DateTime(2020, 11,5);
            //Act
            string expectedText = Functions.DatesDiff(dateOne, dateTwo);
            string text = "Diferencia en años entre las dos fecha: " + 16 + ". Y diferencia en días: " + 6041;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        /// <summary>
        /// Comprobar Diferencia entre fechas
        /// </summary>
        [TestMethod]
        public void TestDateDatesDiffTwo()
        {
            //Arrange
            DateTime dateOne = new DateTime(2004 ,4 ,18);
            DateTime dateTwo = new DateTime(2001, 11, 19);
            //Act
            string expectedText = Functions.DatesDiff(dateOne, dateTwo);
            string text = "Diferencia en años entre las dos fecha: " + 3 + ". Y diferencia en días: " + 881;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
        /// <summary>
        /// Comprobar Diferencia entre fechas
        /// </summary>
        [TestMethod]
        public void TestDateDatesDiffThree()
        {
            //Arrange
            DateTime dateOne = new DateTime(1982, 4, 1);
            DateTime dateTwo = new DateTime(2001, 11, 19);
            //Act
            string expectedText = Functions.DatesDiff(dateOne, dateTwo);
            string text = "Diferencia en años entre las dos fecha: " + 19 + ". Y diferencia en días: " + 7172;
            //Assert
            Assert.AreEqual(text, expectedText);
        }
    }
}
