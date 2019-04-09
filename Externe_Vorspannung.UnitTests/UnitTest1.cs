using System;


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Externe_Vorspannung.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            // Arrange
            Cable k = new Cable();
            k.friction=0.1;
            double [,] Ordinates = new double[4, 2] { { 0, 0 }, { 20, 2 }, { 40, 0 }, { 60, 2 } };
            k.cableOrdinates.Add(Ordinates);
            k.prestressForce = 100;
            k.quantityCable = 1;

            double [,] expected = new double[4, 2] { { 0, 0 }, { 20, 2 }, { 40, 0 }, { 60, 2 } };


            // Act
            double[,] forces = k.Forces();


            // Assert
            Assert.AreSame(expected, Ordinates);


        }
    }
}
