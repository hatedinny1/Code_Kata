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
    public class ArrayDiffInitial
    {
        public ArrayDiffInitial(int[] input, int[] substract, int[] expected)
        {
            Input = input;
            Substract = substract;
            Kata = new ArrayDiffKata();
            Expected = expected;
        }

        public int[] Input { get; private set; }
        public int[] Substract { get; private set; }
        public ArrayDiffKata Kata { get; private set; }
        public int[] Expected { get; private set; }
    }

    [TestClass()]
    public class ArrayDiffKataTests
    {
        [TestMethod()]
        public void Input_Int_Array_1_2_Substract_Int_Array_1_Should_Be_Int_Array_2()
        {
            var arrayDiffInitial = new ArrayDiffInitial(new[] { 1, 2 }, new[] { 1 }, new[] { 2 });
            ActualAreEqualExpected(arrayDiffInitial);
        }

        [TestMethod()]
        public void Input_Int_Array_1_2_2_Substract_Int_Array_1_Should_Be_Int_Array_2_2()
        {
            var arrayDiffInitial = new ArrayDiffInitial(new[] { 1, 2, 2 }, new[] { 1 }, new[] { 2, 2 });
            ActualAreEqualExpected(arrayDiffInitial);
        }

        [TestMethod()]
        public void Input_Int_Array_1_2_2_Substract_Int_Array_2_Should_Be_Int_Array_1()
        {
            var arrayDiffInitial = new ArrayDiffInitial(new[] { 1, 2, 2 }, new[] { 2 }, new[] { 1});
            ActualAreEqualExpected(arrayDiffInitial);
        }

        private static void ActualAreEqualExpected(ArrayDiffInitial arrayDiffInitial)
        {
            var actual = arrayDiffInitial.Kata.ArrayDiff(arrayDiffInitial.Input, arrayDiffInitial.Substract);
            actual.Should().Equal(arrayDiffInitial.Expected);
        }
    }
}