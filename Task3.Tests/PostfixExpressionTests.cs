using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3.Tests
{
    [TestClass]
    public class PostfixExpressionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var postfixExpression = new PostfixExpression();

            string[] input = { "5", "10", "+", "10", "*"};

            double expected = 150;

            double result = postfixExpression.CalculatePostfix(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var postfixExpression = new PostfixExpression();

            string[] input = { "5", "10", "15", "+", "-"};

            double expected = -20;

            double result = postfixExpression.CalculatePostfix(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var postfixExpression = new PostfixExpression();

            string[] input = { "5", "10", "+", "10", "*", "14", "-" };

            double expected = 136;

            double result = postfixExpression.CalculatePostfix(input);

            Assert.AreEqual(expected, result);
        }
    }
}
