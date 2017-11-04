using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kata.Tests
{
    [TestClass()]
    public class PrimeDecompKataTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Input_N_less_than_1_should_be_throw_exception()
        {
            //arrange
            var sut = new PrimeDecompKata();
            //act
            var actual = sut.Factors(-1);
        }

        [TestMethod()]
        public void Input_2_should_be_2()
        {
            //arrange
            var input = 2;
            var expected = "(2)";
            var sut = new PrimeDecompKata();
            AssertAreEqual(sut, input, expected);
        }

        [TestMethod()]
        public void Input_4_should_be_2xx2()
        {
            //arrange
            var input = 4;
            var expected = "(2**2)";
            var sut = new PrimeDecompKata();
            AssertAreEqual(sut, input, expected);
        }

        private static void AssertAreEqual(PrimeDecompKata sut, int input, string expected)
        {
            var actual = sut.Factors(input);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}