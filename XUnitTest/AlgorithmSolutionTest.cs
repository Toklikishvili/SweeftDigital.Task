using SweeftDigitalTask.Algorithm;

namespace Test
{
    public class AlgorithmSolutionTest
    {
        [Theory]
        [InlineData("Anna", "Abcd")]
        public void IsPalindromeTest(string value1, string value2)
        {
            //Act
            bool result1 = value1.IsPalindrome();
            bool result2 = value2.IsPalindrome();

            //Assert
            Assert.True(result1);
            Assert.False(result2);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        public void MinSplitTest(int amount)
        {
            //Act
            int result = amount.MinSplit();

            //Assert
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(new int[] { 10, 20, 20, 5, 30, 50, 70, 1 })]
        public void NotContains(int[] array)
        {
            //Act
            int result = array.NotContains();

            //Assert
            Assert.True(result != 0);
            Assert.True(result == 2);
        }

        [Theory]
        [InlineData("(()())()", "(()()")]
        public void IsProperlyTest(string value1, string value2)
        {
            //Act
            bool result1 = value1.IsProperly();
            bool result2 = value2.IsProperly();

            //Assert
            Assert.True(result1);
            Assert.False(result2);
        }

        [Theory]
        [InlineData(3, 8)]
        public void CountVariantsTest(int stairCount1, int stairCount2)
        {
            // Act
            var actualOptions1 = stairCount1.CountVariants();
            var actualOptions2 = stairCount2.CountVariants();

            // Assert
            Assert.Equal(3, actualOptions1);
            Assert.Equal(34, actualOptions2);
        }
    }
}