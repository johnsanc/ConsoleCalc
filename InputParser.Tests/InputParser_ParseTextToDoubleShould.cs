using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System.Collections.Generic;
using System.Linq;

namespace InputParser.Tests
{
    [TestClass]
    public class ParseTextToDoubleShould
    {
        [TestMethod]
        public void ShouldReturnDoublesWithValidString()
        {
            string numbers = "1,2";
            List<double> target = new List<double> { 1, 2 };

            var actual = Program.InputParser.ParseTextToDouble(numbers);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReplaceInvalidStringWithZeroInList()
        {
            string numbers = "1,abc";
            List<double> target = new List<double> { 1, 0 };

            var actual = Program.InputParser.ParseTextToDouble(numbers);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnZeroFilledListWithAllInvalidString()
        {
            string numbers = "one,abc";
            List<double> target = new List<double> { 0, 0 };

            var actual = Program.InputParser.ParseTextToDouble(numbers);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldComputeListsWithMoreThanTwoItems()
        {
            string numbers = "1,2,3,4,5";
            List<double> target = new List<double> { 1, 2, 3, 4, 5 };

            var actual = Program.InputParser.ParseTextToDouble(numbers);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }
    }
}