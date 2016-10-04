using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practical5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SmallestTest()
        {
            int result = Program.Smallest(3, 4, 5);
            Assert.AreEqual(result, 3);
            Assert.AreNotEqual(result, 4);
            Assert.AreNotEqual(result, 5);
        }

        [TestMethod()]
        public void AverageTest()
        {
            int result = Program.Average(3, 4, 5);
            Assert.AreEqual(result, 4);
            Assert.AreNotEqual(result, 5);
        }

        [TestMethod()]
        public void SameTest()
        {
            Assert.IsTrue(Program.Same(3, 3, 3));
            Assert.IsFalse(Program.Same(3, 4, 3));
            Assert.IsFalse(Program.Same(3, 4, 5));
        }

        [TestMethod()]
        public void DifferentTest()
        {
            Assert.IsTrue(Program.Different(3, 4, 5));
            Assert.IsFalse(Program.Different(3, 3, 5));
        }
    }
}