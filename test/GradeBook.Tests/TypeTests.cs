using Xunit;
using System;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            //arrange
            var x = GetInt();
            SetInt(ref x);

            //Assert
            Assert.Equal(42, x);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "Hello");

            //Assert
            Assert.Equal("Hello", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue ()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "Hello");

            //Assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "Hello");

            //Assert
            Assert.Equal("Hello", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //Act


            //Assert
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwoVarsCanReferenceTheSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //Assert
            Assert.Same(book1, book2);

        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}