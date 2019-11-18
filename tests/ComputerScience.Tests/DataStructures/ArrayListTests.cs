using ComputerScience.DataStructures;
using NUnit.Framework;

namespace ComputerScience.Tests.DataStructures
{
    [TestFixture]
    public class ArrayListTests
    {
        [Test]
        public void Add()
        {
            // Arrange
            var list = new ArrayList<int>(5);
            
            // Act
            list.Add(10);
            list.Add(20);
            list.Add(30);
            
            // Assert
            Assert.That(list[0], Is.EqualTo(10));
            Assert.That(list[1], Is.EqualTo(20));
            Assert.That(list[2], Is.EqualTo(30));
            Assert.That(list.Count(), Is.EqualTo(3));
        }
        
        [Test]
        public void Remove()
        {
            // Arrange
            var list = new ArrayList<int>(5);
            
            // Act
            list.Add(10);
            list.Add(20);
            list.Add(30);
            
            // Assert
            list.Remove(0);
            Assert.That(list[0], Is.EqualTo(20));
            Assert.That(list[1], Is.EqualTo(30));
            Assert.That(list.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Capacity()
        {
            // Arrange
            var list = new ArrayList<int>(2);
            
            // Act
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            
            // Assert
            Assert.That(list[4], Is.EqualTo(50));
            Assert.That(list.Count(), Is.EqualTo(5));
        }
    }
}