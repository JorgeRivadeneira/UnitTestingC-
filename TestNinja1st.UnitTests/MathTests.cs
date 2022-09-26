using NUnit.Framework;
using System;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja1st.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //SetUp
        //TearDown

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Arrange
            //var math = new Math();

            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {

            //Act
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("Obsolete by method: Max_WhenCalled_ReturnTheGreaterArgument")]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            //Arrange
            //var math = new Math();

            //Act
            var result = _math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Obsolete by method: Max_WhenCalled_ReturnTheGreaterArgument")]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            //Arrange
           // var math = new Math();

            //Act
            var result = _math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        [Ignore("Obsolete by method: Max_WhenCalled_ReturnTheGreaterArgument")]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            //Arrange
            var math = new Math();

            //Act
            var result = math.Max(2, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
