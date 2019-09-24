using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System.Collections.Generic;
using System.Linq;
using System;

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
            List<double> target = new List<double> { 1 };

            var actual = Program.InputParser.ParseTextToDouble(numbers);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnZeroFilledListWithAllInvalidString()
        {
            string numbers = "one,abc";
            List<double> target = new List<double> { };

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

        [DataTestMethod]
        [DataRow("1,\\n2")]
        [DataRow("1\\n2")]
        public void ShouldReturnCorrectListWithNewlineDelim(string value)
        {
            List<double> target = new List<double> { 1, 2 };

            var actual = Program.InputParser.ParseTextToDouble(value);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("1,2\\n-13")]
        [DataRow("-50,40,-32,-14, -5")]
        public void ShouldThrowExceptionIfNegativeNumbersFound(string values)
        {
            Assert.ThrowsException<Exception>(() => 
                Program.InputParser.ParseTextToDouble(values)
            );
        }

        [TestMethod]
        public void ShouldIgnoreNumbersGreaterThanOneThousand()
        {
            string numbers = "2,1001,6";
            List<double> target = new List<double> { 2, 6 };

            var actual = Program.InputParser.ParseTextToDouble(numbers);
            bool result = Enumerable.SequenceEqual(target, actual);

            Assert.IsTrue(result);
        }
    }
}
