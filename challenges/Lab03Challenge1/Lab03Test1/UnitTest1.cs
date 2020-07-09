using System;
using Xunit;
using static Lab03Challenge1.Program;

namespace Lab03Test1
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnZeroWhenLessThanThree()
        {
            //Arrange
            string input = "string";
            //Act
            int outputFromMethod = MultiplyInputNumber(input);

            //Assert
            Assert.Equal(0, outputFromMethod);
        }
        [Fact]
        public void CanReturnProductWithThreeNumbers()
        {
            //Arrange
            string numbers = "2 3 4";
            //Act
            int output = MultiplyInputNumber(numbers);
            //Assert
            Assert.Equal(24, output);
        }
        [Theory]
        [InlineData("4 8 15 16", 480)]
        [InlineData("1 1 1", 1)]
        [InlineData("cat dog 5", 5)]
        [InlineData("candycane chocolate", 0)]
        [InlineData("-5 -5 1", 25)]
        public void CanReturnProperProduct(string numbers, int product)
        {
            //Arrange
            //not necessary here, randomly
            //Act
            int result = MultiplyInputNumber(numbers);

            //Assert
            Assert.Equal(product, result);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2, 6 }, 3)]
        [InlineData(new int[] { 3, 5, 10, 55, 67}, 28)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void CanFindAveragesOfUserNumbers(int[] intArrayTest, int average)
        {
            //Arrange
            int expectedOutcome = average;
            //Act
            int output = (int)PickRandomNumberThenGetAverage(intArrayTest);
            //Assert
            Assert.Equal(expectedOutcome, output);
        }

        [Theory]
        [InlineData(new int[] {5, 5, 5, 5, 5, 5, 5, 5}, 5)]
        [InlineData(new int[] {4, 5, 6, 6, 7}, 6)]
        [InlineData(new int[] {1, 2, 3, 4}, 1)]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3}, 1)]

        public void TestTheSortedArray(int[] arrayTest, int biggestNumber)
        {
            //Arrange

            //Act
            int output = ArrayWithoutSortingIt(arrayTest);
            //Assert
            Assert.Equal(biggestNumber, output);
        }

        [Theory]
        [InlineData(new int[] {1, 4, 98, -310}, 98)]
        [InlineData(new int[] { 2, 2, 2, 2, 2}, 2)]
        public void TestTheMaxNumberMethod(int[] genericArray, int largestNumber)
        {
            //Arrange
            int expectedOutcome = largestNumber;
            //Act
            int output = (int)MaximumValue(genericArray);
            //Assert
            Assert.Equal(expectedOutcome, output);
        }
    }
}
