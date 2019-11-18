using System.Collections.Generic;
using ComputerScience.DataStructures.BinarySearchTree;
using NUnit.Framework;

namespace ComputerScience.Tests.DataStructures
{
    [TestFixture]
    public class BinarySearchTreeTests
    {
        [Test]
        public void Insert()
        {
            // Arrange
            var bst = new BinarySearchTree();
            
            // Act
            bst.Insert(10);
            var root = bst.GetRoot();
            
            // Assert
            Assert.That(root.Value, Is.EqualTo(10));
            Assert.That(root.Left, Is.Null);
            Assert.That(root.Right, Is.Null);
        }

        [Test]
        public void Find()
        {
            // Arrange
            var bst = new BinarySearchTree();
            
            // Act
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(15);
            
            // Assert
            Assert.That(bst.Find(15), Is.True);
            Assert.That(bst.Find(8), Is.False);
        }

        [Test]
        public void ValidateOrder()
        {
            // Arrange
            var bst = new BinarySearchTree();
            
            // Act
            bst.Insert(5);
            bst.Insert(2);
            bst.Insert(3);
            bst.Insert(1);
            bst.Insert(6);
            
            var root = bst.GetRoot();

            // Assert
            Assert.That(root.Value, Is.EqualTo(5));
            Assert.That(root.Left.Value, Is.EqualTo(2));
            Assert.That(root.Left.Right.Value, Is.EqualTo(3));
            Assert.That(root.Left.Left.Value, Is.EqualTo(1));
            Assert.That(root.Right.Value, Is.EqualTo(6));
            Assert.That(root.Right.Right, Is.Null);
        }

        [Test]
        public void TraversePreOrder()
        {
            // Arrange
            var bst = new BinarySearchTree();
            
            // Act
            bst.Insert(20);
            bst.Insert(10);
            bst.Insert(30);
            bst.Insert(6);
            bst.Insert(14);
            bst.Insert(24);
            bst.Insert(3);
            bst.Insert(8);
            bst.Insert(26);

            var result = bst.TraversePreOrder();
            
            // Assert
            Assert.That(result, Is.EqualTo(new List<int> { 20, 10, 6, 3, 8, 14, 30, 24, 26 }));
        }

        [Test]
        public void TraverseInOrder()
        {
            // Arrange
            var bst = new BinarySearchTree();
            
            // Act
            bst.Insert(20);
            bst.Insert(10);
            bst.Insert(30);
            bst.Insert(6);
            bst.Insert(14);
            bst.Insert(24);
            bst.Insert(3);
            bst.Insert(8);
            bst.Insert(26);

            var result = bst.TraverseInOrder();
            
            // Assert
            Assert.That(result, Is.EqualTo(new List<int> { 3, 6, 8, 10, 14, 20, 24, 26, 30 }));
        }

        [Test]
        public void TraversePostOrder()
        {
            // Arrange
            var bst = new BinarySearchTree();
            
            // Act
            bst.Insert(20);
            bst.Insert(10);
            bst.Insert(30);
            bst.Insert(6);
            bst.Insert(14);
            bst.Insert(24);
            bst.Insert(3);
            bst.Insert(8);
            bst.Insert(26);

            var result = bst.TraversePostOrder();
            
            // Assert
            Assert.That(result, Is.EqualTo(new List<int> { 3, 8, 6, 14, 10, 26, 24, 30, 20 }));
        }
    }
}