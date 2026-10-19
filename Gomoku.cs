class Gomoku
{
    static char[,] board = new char[15, 15];
    static void show()
    {
        Console.WriteLine("   A B C D E F G H I J K L M N O");
        for (int i = 0; i < 15; i++)
        {
            Console.Write((i + 1).ToString().PadLeft(2) + " ");
            for (int j = 0; j < 15; j++)
            {
                Console.Write(board[i, j] == '\0' ? '·' : board[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int turn = 0;
        int row = 0, col = 0;
        while (true)
        {
            show();
            Console.WriteLine("轮到 " + (turn % 2 == 0 ? "黑棋" : "白棋") + " 下棋");
            Console.Write("请输入列号(A-O)和行号(1-15)，例如 A1: ");
            string input = Console.ReadLine();
            if (input.Length == 2)
            {
                row = input[1] - '1';
                col = input[0] - 'A';
            }
            else if (input.Length == 3)
            {
                row = 10 + input[2] - '1';
                col = input[0] - 'A';
            }
            else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("游戏结束");
                break;
            }
            else
            {
                Console.WriteLine("输入格式错误，请重新输入");
                continue;
            }
            if (row < 0 || row >= 15 || col < 0 || col >= 15)
            {
                Console.WriteLine("输入位置超出范围，请重新输入");
                continue;
            }
            if (board[row, col] != '\0')
            {
                Console.WriteLine("该位置已有棋子，请重新输入");
                continue;
            }
            board[row, col] = turn % 2 == 0 ? '●' : '○';
            turn++;
        }
    }
}