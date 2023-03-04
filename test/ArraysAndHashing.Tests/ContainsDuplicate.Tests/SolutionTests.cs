using FluentAssertions;

namespace ContainsDuplicate.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }                  , true)]
        [InlineData(new int[] { 1, 2, 3, 4 }                  , false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicate(int[] nums, bool expected)
        {
            // Act
            Solution solution = new Solution();

            // Actual
            var actual = solution.ContainsDuplicate(nums);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicateWithFluentAssertion(int[] nums, bool expected)
        {
            Solution solution = new Solution();

            solution.ContainsDuplicate(nums).Should().Be(expected);
        }
    }
}
