using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System.Collections.Generic;

namespace Operation.Tests
{
    [TestClass]
    public class AddShould
    {
        [TestMethod]
        public void AddShould_ReturnCorrectSumFromNumbers()
        {
            var numbers = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
            var target = 15.0;

            var result = Program.Operation.Add(numbers);

            Assert.AreEqual(target, result);
        }

        [TestMethod]
        public void AddShould_ReturnZeroWithEmptyInput()
        {
            var numbers = new List<double> { };
            var target = 0.0;

            var result = Program.Operation.Add(numbers);

            Assert.AreEqual(target, result);
        }

        [TestMethod]
        public void AddShould_ReturnSameNumberWithOneInput()
        {
            var numbers = new List<double> { 1.0 };
            var target = 1.0;

            var result = Program.Operation.Add(numbers);

            Assert.AreEqual(target, result);
        }
    }
}
