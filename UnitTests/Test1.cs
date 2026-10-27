using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationsConstructorTest()
        {
            Calculations calcObject = new Calculations();
        }

        [TestMethod]
        public void AddNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Add(3, 4);
            int expectedValue = 7;
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SubtractNumbersTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Subtract(32, 4);
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            Calculations calcObject = new Calculations();
            try
            {
                calcObject.Divide(32, 0);
                Assert.Fail("An ArgumentOutOfRangeException was expected but was not thrown.");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Test passes successfully
            }
        }

        // ==========================================
        // 6 DOMAIN PARTITION / BRANCH COVERAGE TESTS
        // ==========================================

        [TestMethod]
        public void MidDomainPartitioningTest1()
        {
            // Path: If-0 (T) -> If-1 (T) -> output y
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(1, 2, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MidDomainPartitioningTest2()
        {
            // Path: If-0 (F) -> If-3 (T) -> output y
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(3, 2, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MidDomainPartitioningTest3()
        {
            // Path: If-0 (T) -> If-1 (F) -> If-2 (T) -> output x
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(2, 1, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MidDomainPartitioningTest4()
        {
            // Path: If-0 (T) -> If-1 (F) -> If-2 (F) -> output z
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(4, 1, 3);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MidDomainPartitioningTest5()
        {
            // Path: If-0 (F) -> If-3 (F) -> If-4 (T) -> output x
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(2, 3, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MidDomainPartitioningTest6()
        {
            // Path: If-0 (F) -> If-3 (F) -> If-4 (F) -> output z
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(0, 3, 1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Test_Subtraction_ValidInput()
        {
            var calcObject = new Calculations();
            double result = calcObject.Subtract(10, 4);
            Assert.AreEqual(6.0, result);
        }

        [TestMethod]
        public void Test_Divide_ValidInput()
        {
            var calcObject = new Calculations();
            double result = calcObject.Divide(10, 2);
            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        public void Test_Add_NegativeNumbers()
        {
            var calcObject = new Calculations();
            int result = calcObject.Add(-5, -3);
            Assert.AreEqual(-8, result);
        }




    }
}
