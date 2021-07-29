using NUnit.Framework;
using System;
using ExceptionsApp;

namespace ExceptionDatatypesTest
{
    public class GradeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-34)]
        [TestCase(-1)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(()=> Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range of 0-100")); // this is a generic
        }

        [TestCase(400)]
        [TestCase(101)]
        public void WhenMarkIsGreaterThanOneHundred_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(()=> Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range of 0-100"));
        }

        [TestCase(400)]
        [TestCase(101)]
        public void WhenMarkIsGreaterThanOneHundred_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range of 0-100"));
        }
    }
}