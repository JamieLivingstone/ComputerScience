using ComputerScience.DataStructures;
using NUnit.Framework;

namespace ComputerScience.Tests.DataStructures
{
    [TestFixture]
    public class QueueTests
    {
        [Test]
        public void Enqueue()
        {
            // Arrange
            var queue = new Queue<int>();
            
            // Act
            queue.Enqueue(10);
            
            // Assert
            Assert.That(queue.Peek(), Is.EqualTo(10));
        }

        [Test]
        public void Dequeue()
        {
            // Arrange
            var queue = new Queue<int>();
            
            // Act
            queue.Enqueue(10);
            queue.Dequeue();
            
            // Assert
            Assert.That(queue.IsEmpty(), Is.EqualTo(true));
        }

        [Test]
        public void Peek()
        {
            // Arrange
            var queue = new Queue<int>();
            
            // Act
            queue.Enqueue(1);
            
            // Assert
            Assert.That(queue.Peek(), Is.EqualTo(1));
        }

        [Test]
        public void IsEmpty()
        {
            // Arrange
            var queue = new Queue<int>();
            
            // Act
            var initial = queue.IsEmpty();
            queue.Enqueue(10);
            var after = queue.IsEmpty();
            
            // Assert
            Assert.That(initial, Is.EqualTo(true));
            Assert.That(after, Is.EqualTo(false));
        }
    }
}