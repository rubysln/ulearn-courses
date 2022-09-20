using System;

namespace TicTacToe
{
    class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Run("XXX OO. ...");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }

        public static GameResult GetGameResult(Mark[,] field)
        {
            if (WinResult(field, Mark.Circle) == WinResult(field, Mark.Cross)) return GameResult.Draw;
            if (WinResult(field,Mark.Cross)) return GameResult.CrossWin;
            if (WinResult(field,Mark.Circle)) return GameResult.CircleWin;
            return GameResult.Draw;
        }

        public static bool WinResult(Mark[,] field, Mark element)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (field[i, 0] == element && field[i, 1] == element && field[i, 2] == element) return true;
                    if (field[0, j] == element && field[1, j] == element && field[2, j] == element) return true;
                }
            }
            if (field[2, 0] == element && field[1, 1] == element && field[0, 2] == element) return true;
            if (field[0, 0] == element && field[1, 1] == element && field[2, 2] == element) return true;
            return false;
        }
    }
}
