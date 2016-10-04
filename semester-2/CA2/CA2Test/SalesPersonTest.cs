using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2;

namespace CA2Test
{
    [TestClass]
    public class SalesPersonTest
    {
        [TestMethod]
        public void SetRatingTest3Stars()
        {
            SalesPerson sp = new SalesPerson("", "", "", 699);

            string result = sp.StarRating;

            Assert.AreEqual(result, "***");
        }
    }
}
