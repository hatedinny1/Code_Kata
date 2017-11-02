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
    }
}