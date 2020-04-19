using NUnit.Framework;
using System;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        Fundamentals.Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Fundamentals.Stack<string>(); 
        }

        [Test]
        public void Push_WithNullArgument_ReturnArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Push_WhenCalled_AddObject()
        {
            _stack.Push("test");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

       

        [Test]
        public void Pop_WithoutObjects_ReturnInvalidOperationException()
        {
            Assert.That(()=>_stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_WithObjects_RemoveLastValueTop()
        {
            //Arrange
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            //Act
            var result = _stack.Pop();

            //Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_WithObjects_RemoveLastValue()
        {
            //Arrange
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            //Act
            var result = _stack.Pop();

            //Assert
            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_WithoutObjects_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }



    }
}
