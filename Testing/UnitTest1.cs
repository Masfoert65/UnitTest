using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static MyMath.MyFunc;
namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            int a = 2;
            int b = 3;
            int expected = 5;

            int actual = Otv(a, b);
           Assert.AreEqual(expected, actual);
        }
    }
}
