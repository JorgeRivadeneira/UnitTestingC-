using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja1st.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(2, "2")]
        public void GetOutput_WhenCalled_ReturnsFizzOrBuzzOrFizzBuzzOrTheNumber(int number, string expectedResults)
        {

            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(expectedResults));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {

            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo( "FizzBuzz"));
        }
    }
}
