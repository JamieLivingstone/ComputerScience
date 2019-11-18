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
    }
}