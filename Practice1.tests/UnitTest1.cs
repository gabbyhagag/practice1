using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice1.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPushPopWithOneValue()
        {
            //arrange
            Stack1 stack = new Stack1();
            int val = 5;
            int expected = 5;
            int result;

            //act
            stack.Push(val);
            result = stack.Pop();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxWithSmallerToMax()
        {
            //arrange
            Stack1 stack = new Stack1();
            int expected = 10;
            int result;

            //act
            stack.Push(1);
            stack.Push(2);
            stack.Push(10);
            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxWithMaxToSmallest()
        {
            //arrange
            Stack1 stack = new Stack1();
            int expected = 10;
            int result;

            //act
            stack.Push(10);
            stack.Push(5);
            stack.Push(1);
            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxInMiddleWithPops()
        {
            //arrange
            Stack1 stack = new Stack1();
            int[] values = new int[] {1,2,10,5,7};
            int expected = 10;
            int result;

            //act
            foreach(int val in values)
            {
                stack.Push(val);
            }
            stack.Pop();
            stack.Pop();

            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxWhenWasAndPoped()
        {
            //arrange
            Stack1 stack = new Stack1();
            int[] values = new int[] { 1, 2, 10, 5, 20 };
            int expected = 10;
            int result;

            //act
            foreach (int val in values)
            {
                stack.Push(val);
            }
            stack.Pop();
            stack.Pop();

            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxWithDoubleValues()
        {
            //arrange
            Stack1 stack = new Stack1();
            int[] values = new int[] { 1, 2, 10, 10, 11 };
            int expected = 10;
            int result;

            //act
            foreach (int val in values)
            {
                stack.Push(val);
            }
            stack.Pop();
            stack.Pop();

            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxWithDoubleValuesPoped()
        {
            //arrange
            Stack1 stack = new Stack1();
            int[] values = new int[] { 1, 2, 10, 10, 11 };
            int expected = 2;
            int result;

            //act
            foreach (int val in values)
            {
                stack.Push(val);
            }
            stack.Pop();
            stack.Pop();
            stack.Pop();

            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMaxWithGaps()
        {
            //arrange
            Stack1 stack = new Stack1();
            int[] values = new int[] { 1, 10, 2, 10, 11 };
            int expected = 10;
            int result;

            //act
            foreach (int val in values)
            {
                stack.Push(val);
            }
            stack.Pop();
            stack.Pop();

            result = stack.Max();

            //assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void PushPopRangeTest()
        {
            //arrange
            Stack1 stack = new Stack1();
            int result;

            stack.Push(10);
            Assert.AreEqual(stack.Max(), 10, "Value should be 10");

            stack.Push(15);
            Assert.AreEqual(stack.Max(), 15, "Value should be 15");

            stack.Push(3);
            Assert.AreEqual(stack.Max(), 15, "Value should be 15");

            stack.Push(100);
            Assert.AreEqual(stack.Max(), 100, "Value should be 100");

            stack.Pop();
            Assert.AreEqual(stack.Max(), 15, "Value should be 15");

            stack.Pop();
            Assert.AreEqual(stack.Max(), 15, "Value should be 15");

            stack.Pop();
            Assert.AreEqual(stack.Max(), 10, "Value should be 10");
        }
    }
}
