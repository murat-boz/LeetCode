using FluentAssertions;

namespace ValidPalindrome.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car"                    , false)]
        public void IsPalindrome(string testValue, bool expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            bool actual = solution.IsPalindrome(testValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car"                    , false)]
        public void IsPalindromeWithFluentAssertion(string testValue, bool expected)
        {
            Solution solution = new Solution();

            solution.IsPalindrome(testValue)
                    .Should()
                    .Be(expected);
        }
    }
}