using System;

class HorsePath
{
    static void Main()
    {
        int[] board = new int[8];
        board[0] = 1;

        int rowPos = 0;
        int bitPos = 0;

        string command = Console.ReadLine();
        while (command != "stop")
        {
            if (CheckValidPosition(command, board, rowPos, bitPos))
            {
                switch (command)
                {
                    case "left up":
                        bitPos += 2;
                        rowPos -= 1;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "left down":
                        bitPos += 2;
                        rowPos += 1;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "right up":
                        bitPos -= 2;
                        rowPos -= 1;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "right down":
                        bitPos -= 2;
                        rowPos += 1;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "up left":
                        bitPos += 1;
                        rowPos -= 2;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "up right":
                        bitPos -= 1;
                        rowPos -= 2;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "down left":
                        bitPos += 1;
                        rowPos += 2;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                    case "down right":
                        bitPos -= 1;
                        rowPos += 2;
                        board[rowPos] = board[rowPos] ^ (1 << bitPos);
                        break;
                }
            }
            command = Console.ReadLine();
        }

        bool wholeZeroMap = true;
        foreach (var i in board)
        {
            if (i != 0)
            {
                wholeZeroMap = false;
                Console.WriteLine(i);
            }
        }

        if (wholeZeroMap)
        {
            Console.WriteLine("[Board is empty]");
        }
    }

    private static bool CheckValidPosition(string directions, int[] board, int rowPos, int bitIndex)
    {
        switch (directions)
        {
            case "left up":
                if (rowPos - 1 < 0 || bitIndex + 2 >= 8) return false;
                break;
            case "left down":
                if (rowPos + 1 >= board.Length || bitIndex + 2 >= 8) return false;
                break;
            case "right up":
                if (rowPos - 1 < 0 || bitIndex - 2 < 0) return false;
                break;
            case "right down":
                if (rowPos + 1 >= board.Length || bitIndex - 2 < 0) return false;
                break;
            case "up left":
                if (rowPos - 2 < 0 || bitIndex + 1 >= 8) return false;
                break;
            case "up right":
                if (rowPos - 2 < 0 || bitIndex - 1 < 0) return false;
                break;
            case "down left":
                if (rowPos + 2 >= board.Length || bitIndex + 1 >= 8) return false;
                break;
            case "down right":
                if (rowPos + 2 >= board.Length || bitIndex - 1 < 0) return false;
                break;
        }
        return true;
    }
}
