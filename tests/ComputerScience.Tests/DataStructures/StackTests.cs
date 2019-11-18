using ComputerScience.DataStructures;
using NUnit.Framework;

namespace ComputerScience.Tests.DataStructures
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push()
        {
            // Arrange
            var stack = new Stack<int>();
            
            // Act
            stack.Push(10);
            stack.Push(20);
            
            // Assert
            Assert.That(stack.Size(), Is.EqualTo(2));
        }

        [Test]
        public void Pop()
        {
            // Arrange
            var stack = new Stack<int>();
            
            // Act
            stack.Push(10);
            stack.Push(20);
            stack.Pop();
            
            // Assert
            Assert.That(stack.Size(), Is.EqualTo(1));
        }

        [Test]
        public void Peek()
        {
            // Arrange
            var stack = new Stack<int>();
            
            // Act
            stack.Push(10);
            
            // Assert
            Assert.That(stack.Peek(), Is.EqualTo(10));
            Assert.That(stack.Size(), Is.EqualTo(1));
        }

        [Test]
        public void IsEmpty()
        {
            // Arrange
            var stack = new Stack<int>();
            
            // Act
            var initial = stack.IsEmpty();
            stack.Push(10);
            var after = stack.IsEmpty();
            
            // Assert
            Assert.That(initial, Is.EqualTo(true));
            Assert.That(after, Is.EqualTo(false));
        }
    }
}