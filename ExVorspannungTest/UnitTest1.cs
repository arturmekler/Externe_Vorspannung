using System;
using Externe_Vorspannung;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExVorspannungTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kabel k = new Kabel();
            Assert.AreEqual(1,1);
        }
    }
}
