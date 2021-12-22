using System;
using CoreSolution;
using Xunit;

namespace SolutionTests
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(1, 1);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test1()
        {
            int numberMachineCanWash = 0;
            int[] cleanPile = new int[] { 1, 2, 1, 1 };
            int[] dirtyPile = new int[] { 1, 4, 3, 2, 4 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);
            Assert.Equal(1, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test2()
        {
            int numberMachineCanWash = 2;
            int[] cleanPile = new int[] { 1, 2, 1, 1 };
            int[] dirtyPile = new int[] { 1, 4, 3, 2, 4 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(3, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test4()
        {
            int numberMachineCanWash = 3;
            int[] cleanPile = new int[] { 1, 2, 1, 1 };
            int[] dirtyPile = new int[] { 1, 4, 3, 2, 4 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(3, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test5()
        {
            int numberMachineCanWash = 2;
            int[] cleanPile = new int[] { 1, 2, 3, 1, 2, 3 };
            int[] dirtyPile = new int[] { 3, 3, 4, 1, 2, 7, 9 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(4, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test6()
        {
            int numberMachineCanWash = 4;
            int[] cleanPile = new int[] { 1, 1, 1, 1, 1, 1 };
            int[] dirtyPile = new int[] { 1, 2, 2, 1, 3, 4, 5, 2 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(5, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test7()
        {
            int numberMachineCanWash = 0;
            int[] cleanPile = new int[] { 1 };
            int[] dirtyPile = new int[] { 1, 2, 3, 4, 5, 5 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(0, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test8()
        {
            int numberMachineCanWash = 20;
            int[] cleanPile = new int[] { 50, 50, 50, 37, 38, 37, 49, 39, 38, 45, 43 };
            int[] dirtyPile = new int[] { 50 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(4, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test9()
        {
            int numberMachineCanWash = 20;
            int[] cleanPile = new int[] { 1 };
            int[] dirtyPile = new int[] { 50, 50, 50, 37, 38, 37, 49, 39, 38, 45, 43 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(3, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test10()
        {
            int numberMachineCanWash = 50;
            int[] cleanPile = new int[] { 40, 40, 40, 40, 40, 40, 40, 50, 50, 50, 50, 50 };
            int[] dirtyPile = new int[] { 40, 40, 45, 45, 30, 35, 50, 50, 25, 25, 20, 20 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(10, pairs);
        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test11()
        {
            int numberMachineCanWash = 1;
            int[] cleanPile = new int[] { 8 };
            int[] dirtyPile = new int[] { 8 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(1, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Tst12()
        {
            int numberMachineCanWash = 20;
            int[] cleanPile = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] dirtyPile = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(0, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test13()
        {
            int numberMachineCanWash = 20;
            int[] cleanPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int[] dirtyPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(10, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test14()
        {
            int numberMachineCanWash = 20;
            int[] cleanPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int[] dirtyPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(10, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test15()
        {
            int numberMachineCanWash = 0;
            int[] cleanPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int[] dirtyPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(5, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test16()
        {
            int numberMachineCanWash = 30;
            int[] cleanPile = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11 };
            int[] dirtyPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(6, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test17()
        {
            int numberMachineCanWash = 4;
            int[] cleanPile = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11 };
            int[] dirtyPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(2, pairs);

        }

        //[Fact(Skip = "Skipped")]
        [Fact]
        public void Test18()
        {
            int numberMachineCanWash = 5;
            int[] cleanPile = new int[] { 1, 2, 3, 2, 3, 4, 5 };
            int[] dirtyPile = new int[] { 2, 1, 1, 1, 3, 3, 3, 4, 4, 4, 5, 5, 6, 5, 7, 5, 6 };
            int pairs = new ClassLib().GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);

            Assert.Equal(6, pairs);

        }
    }
}
