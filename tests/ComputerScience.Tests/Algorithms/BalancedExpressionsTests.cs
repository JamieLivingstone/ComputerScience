using ComputerScience.Algorithms;
using NUnit.Framework;

namespace ComputerScience.Tests.Algorithms
{
    [TestFixture]
    public class BalancedExpressionsTests
    {
        [TestCase("()", true)]
        [TestCase("())", false)]
        [TestCase("[())", false)]
        [TestCase("<[()]>", true)]
        public void Balanced(string input, bool expected)
        {
            var result = BalancedExpressions.IsBalanced(input);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}