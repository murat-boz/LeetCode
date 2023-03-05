using FluentAssertions;

namespace KokoEatingBananas.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 6, 7, 11 }                    , 8         , 4)]
        [InlineData(new int[] { 30, 11, 23, 4, 20 }              , 5         , 30)]
        [InlineData(new int[] { 30, 11, 23, 4, 20 }              , 6         , 23)]
        [InlineData(new int[] { 805306368, 805306368, 805306368 }, 1000000000, 3)]
        public void MinEatingSpeed(int[] piles, int h, int expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int actual = solution.MinEatingSpeed(piles, h);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, 6, 7, 11 }                    , 8         , 4)]
        [InlineData(new int[] { 30, 11, 23, 4, 20 }              , 5         , 30)]
        [InlineData(new int[] { 30, 11, 23, 4, 20 }              , 6         , 23)]
        [InlineData(new int[] { 805306368, 805306368, 805306368 }, 1000000000, 3)]
        public void MinEatingSpeedwithFluentAssertion(int[] piles, int h, int expected)
        {
            Solution solution = new Solution();

            solution.MinEatingSpeed(piles, h).Should().Be(expected);
        }
    }
}
