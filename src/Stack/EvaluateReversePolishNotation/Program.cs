namespace EvaluateReversePolishNotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = new string[] { "2", "1", "+", "3", "*" };

            Solution solution = new Solution();
            Console.WriteLine(solution.EvalRPN(tokens));
        }
    }

    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            string[] operand = new string[] 
            { 
                "+",
                "-", 
                "*", 
                "/" 
            };

            Stack<string> stack = new ();

            foreach (var token in tokens)
            {
                if (operand.Contains(token))
                {
                    string secondValue = stack.Pop();
                    string firstValue  = stack.Pop();

                    stack.Push(this.DoMath(token, firstValue, secondValue).ToString());

                    continue;
                }

                stack.Push(token);
            }

            return Convert.ToInt32(stack.Pop());
        }

        private int DoMath(string operand, string firstValue, string secondValue)
        {
            switch (operand)
            {
                case "+":
                    return Convert.ToInt32(firstValue) + Convert.ToInt32(secondValue);
                case "-":
                    return Convert.ToInt32(firstValue) - Convert.ToInt32(secondValue);
                case "*":
                    return Convert.ToInt32(firstValue) * Convert.ToInt32(secondValue);
                case "/":
                    return Convert.ToInt32(firstValue) / Convert.ToInt32(secondValue);
                default:
                    return 0;
            }
        }
    }
}