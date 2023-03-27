using FluentAssertions;

namespace EvaluateReversePolishNotation.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { "2", "1", "+", "3", "*"  }                                           , 9 )]
        [InlineData(new string[] { "4", "13", "5", "/", "+" }                                           , 6 )]
        [InlineData(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22 )]
        public void EvalRPN(string[] tokens, int expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int actual = solution.EvalRPN(tokens);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "2", "1", "+", "3", "*"  }                                           , 9 )]
        [InlineData(new string[] { "4", "13", "5", "/", "+" }                                           , 6 )]
        [InlineData(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22 )]
        public void EvalRPNWithFluentAssertion(string[] tokens, int expected)
        {
            Solution solution = new Solution();

            solution.EvalRPN(tokens).Should().Be(expected);
        }
    }
}