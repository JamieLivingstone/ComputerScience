using ComputerScience.DataStructures;
using NUnit.Framework;

namespace ComputerScience.Tests.DataStructures
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void AddFirst()
        {
            // Arrange
            var list = new LinkedList();
            
            // Act
            list.AddFirst(20);
            
            // Assert
            Assert.That(list.IndexOf(20), Is.EqualTo(0));
        }
        
        [Test]
        public void AddLast()
        {
            // Arrange
            var list = new LinkedList();
            
            // Act
            list.AddFirst(10);
            list.AddLast(30);
            list.AddFirst(0);
            
            // Assert
            Assert.That(list.IndexOf(30), Is.EqualTo(2));
        }

        [Test]
        public void DeleteFirst()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            list.DeleteFirst();
            
            // Assert
            Assert.That(list.IndexOf(20), Is.EqualTo(0));
        }
        
        [Test]
        public void DeleteLast()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            list.AddFirst(10);
            list.AddLast(20);
            list.DeleteLast();
            
            // Assert
            Assert.That(list.IndexOf(20), Is.EqualTo(-1));
        }

        [Test]
        public void Contains()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            list.AddLast(20);
            
            // Assert
            Assert.That(list.Contains(10), Is.EqualTo(false));
            Assert.That(list.Contains(20), Is.EqualTo(true));
        }

        [Test]
        public void IndexOf()
        {
            // Arrange
            var list = new LinkedList();
            
            // Act
            list.AddLast(10);
            list.AddFirst(40);
            
            // Assert
            Assert.That(list.IndexOf(10), Is.EqualTo(1));
            Assert.That(list.IndexOf(40), Is.EqualTo(0));
            Assert.That(list.IndexOf(999), Is.EqualTo(-1));
        }

        [Test]
        public void Size_Simple()
        {
            // Arrange
            var list = new LinkedList();
            
            // Act
            list.AddLast(10);
            list.DeleteLast();
            
            // Assert
            Assert.That(list.Size(), Is.EqualTo(0));
        }

        [Test]
        public void Size_Advanced()
        {
            // Arrange
            var list = new LinkedList();
            
            // Act
            list.AddFirst(10); // 1
            list.AddFirst(5); // 2
            list.DeleteLast(); // 1
            list.DeleteLast(); // 0
            list.AddLast(10); // 1
            list.AddLast(40); // 2
            list.AddLast(700); // 3
            
            // Assert
            Assert.That(list.Size(), Is.EqualTo(3));
        }

        [Test]
        public void Reverse()
        {
            // Arrange
            var list = new LinkedList();
            
            // Act
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(1);
            list.Reverse();

            // Assert
            Assert.That(list.IndexOf(1), Is.EqualTo(0));
            Assert.That(list.IndexOf(2), Is.EqualTo(1));
            Assert.That(list.IndexOf(3), Is.EqualTo(2));
        }
    }
}