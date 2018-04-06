using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice1;

namespace Practice1.test
{
    [TestClass]
    public class Practice1Tests
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
    }
}
