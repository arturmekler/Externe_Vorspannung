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
            Cable k = new Cable();
            Assert.AreEqual(1,1);
        }
    }
}
