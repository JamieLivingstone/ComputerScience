using ComputerScience.DataStructures;
using NUnit.Framework;

namespace ComputerScience.Tests.DataStructures
{
    [TestFixture]
    public class HashTableTests
    {
        [Test]
        public void Put()
        {
            // Arrange
            var hashTable = new HashTable();
            
            // Act
            hashTable.Put(10, "hello");
            
            // Assert
            Assert.That(hashTable.Size(), Is.EqualTo(1));
        }

        [Test]
        public void Get()
        {
            // Arrange
            var hashTable = new HashTable();
            
            // Act
            hashTable.Put(10, "hello");

            // Assert
            Assert.That(hashTable.Get(10), Is.EqualTo("hello"));
        }

        [Test]
        public void Remove()
        {
            // Arrange
            var hashTable = new HashTable();
            
            // Act
            hashTable.Put(20, "test");
            hashTable.Put(10, "foo");
            
            var beforeRemoval = hashTable.Get(10);
            
            hashTable.Remove(10);
            
            var afterRemoval = hashTable.Get(10);
            
            // Assert
            Assert.That(beforeRemoval, Is.EqualTo("foo"));
            Assert.That(afterRemoval, Is.EqualTo(null));
            Assert.That(hashTable.Size(), Is.EqualTo(1));
        }
    }
}