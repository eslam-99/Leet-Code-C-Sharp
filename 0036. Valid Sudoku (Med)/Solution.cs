using System;

public class Solution
{
    Dictionary<char, List<int>> positions = new();
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.') continue;
                int x = i * 9 + j;
                if (positions.ContainsKey(board[i][j]))
                {
                    foreach (int index in positions[board[i][j]])
                        if (!CheckValidNum(x, index)) return false;
                    positions[board[i][j]].Add(x);
                }
                else positions.Add(board[i][j], new() { x });
            }
        }
        return true;
    }

    private bool CheckValidNum(int i, int j)
    {
        int x1 = i % 9, y1 = (i - i % 9) / 9;
        int x2 = j % 9, y2 = (j - j % 9) / 9;
        if (x1 == x2 || y1 == y2 || (x1 / 3 == x2 / 3 && y1 / 3 == y2 / 3)) return false;
        return true;
    }
} 