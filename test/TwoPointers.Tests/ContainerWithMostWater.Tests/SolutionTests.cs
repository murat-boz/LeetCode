using FluentAssertions;

namespace ContainerWithMostWater.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 1 }, 40)]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 5, 3, 1 }, 25)]
        public void MaxArea(int[] array, int expected)
        {
            //Arrange
            Solution solution = new Solution();

            //Act
            var actual = solution.MaxArea(array);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 1 }, 40)]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 5, 3, 1 }, 25)]
        public void MaxAreaWithFluentAssertion(int[] array, int expected)
        {
            Solution solution = new Solution();

            solution.MaxArea(array).Should().Be(expected);
        }
    }
}