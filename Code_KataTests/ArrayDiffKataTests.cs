using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Code_Kata.Tests
{
    [TestClass()]
    public class ArrayDiffKataTests
    {
        [TestMethod()]
        public void Input_Int_Array_1_2_Substract_Int_Array_1_Should_Be_Int_Array_2()
        {
            var expected = new[] { 2 };
            var input = new[] { 1,2 };
            var substract = new[] { 1 };
            var kata = new ArrayDiffKata();
            var actual = kata.ArrayDiff(input, substract);
            actual.Should().Equal(expected);
        }
    }
}