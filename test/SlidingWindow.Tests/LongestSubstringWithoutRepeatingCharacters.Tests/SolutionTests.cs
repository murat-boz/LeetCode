using FluentAssertions;

namespace LongestSubstringWithoutRepeatingCharacters.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb"   , 1)]
        [InlineData("pwwkew"  , 3)]
        [InlineData("aab"     , 2)]
        [InlineData("dvdf"    , 3)]
        [InlineData(""        , 0)]
        [InlineData("c"       , 1)]
        public void LengthOfLongestSubstring(string s, int expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int actual = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb"   , 1)]
        [InlineData("pwwkew"  , 3)]
        [InlineData("aab"     , 2)]
        [InlineData("dvdf"    , 3)]
        [InlineData(""        , 0)]
        [InlineData("c"       , 1)]
        public void LengthOfLongestSubstringWithFluentAssertion(string s, int expected)
        {
            Solution solution = new Solution();

            solution.LengthOfLongestSubstring(s).Should().Be(expected);
        }
    }
}