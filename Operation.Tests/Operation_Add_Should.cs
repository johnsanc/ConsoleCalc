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
    }
}
