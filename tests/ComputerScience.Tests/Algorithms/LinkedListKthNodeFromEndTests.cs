using ComputerScience.Algorithms;
using ComputerScience.DataStructures;
using NUnit.Framework;

namespace ComputerScience.Tests.Algorithms
{
    [TestFixture]
    public class LinkedListKthNodeFromEndTests
    {
        [Test]
        public void GetKthNode()
        {
            // Arrange
            var rootNode = new Node(10);
            var secondNode = new Node(20);
            var thirdNode = new Node(30);

            rootNode.Next = secondNode;
            secondNode.Next = thirdNode;
            
            // Act
            var kthNode = LinkedListKthNodeFromEnd.Get(rootNode, 2);
            
            // Assert
            Assert.That(kthNode, Is.EqualTo(20));
        }
    }
}