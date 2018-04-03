using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrdinaLibrary.test
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void TestArrayOrdinamento()
        {
            int[] v1 = new int[] { 11, 22, 13, 4 };
            int[] v2 = new int[] { 4, 11, 3, 22 };
            int[] vettoreOrdinato = Vettore.Ordina(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);
        }
    }
}
