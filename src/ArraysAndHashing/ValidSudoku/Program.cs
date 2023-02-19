internal class Program
{
    private static void Main(string[] args)
    {
        var sudoku1 = new char[][] 
        { 
            new char [] {'.', '3', '.', '.', '7', '.', '.', '.', '.'},
            new char [] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char [] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char [] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char [] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char [] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char [] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char [] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char [] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
        };

        var sudoku2 = new char[][]
        {
            new char [] {'.', '.', '.', '.', '5', '.', '.', '1', '.'},
            new char [] {'.', '4', '.', '3', '.', '.', '.', '.', '.'},
            new char [] {'.', '.', '.', '.', '.', '3', '.', '.', '1'},
            new char [] {'8', '.', '.', '.', '.', '.', '.', '2', '.'},
            new char [] {'.', '.', '2', '.', '7', '.', '.', '.', '.'},
            new char [] {'.', '1', '5', '.', '.', '.', '.', '.', '.'},
            new char [] {'.', '.', '.', '.', '.', '2', '.', '.', '.'},
            new char [] {'.', '2', '.', '9', '.', '.', '.', '.', '.'},
            new char [] {'.', '.', '4', '.', '.', '.', '.', '.', '.' }
        };

        Console.WriteLine(new Solution().IsValidSudoku(sudoku1));
    }
}

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<(int, int), HashSet<char>> subBoxes = new Dictionary<(int, int), HashSet<char>>();

        for (int r = 0; r < 9; r++)
        {
            var rowSet    = new HashSet<char>();
            var columnSet = new HashSet<char>();

            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] != '.' && !rowSet.Add(board[r][c]))
                {
                    return false;
                }

                if (board[c][r] != '.' && !columnSet.Add(board[c][r]))
                {
                    return false;
                }

                if (!subBoxes.ContainsKey((r / 3, c / 3)))
                {
                    subBoxes.Add((r / 3, c / 3), new HashSet<char>());
                }

                if (board[r][c] != '.' && !subBoxes[(r / 3, c / 3)].Add(board[r][c]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}