namespace Minesweeper
{
    using Models;
    using System;
    using System.Collections.Generic;

    public class StartupMinesweeper
    {
        public static void Main()
        {
            string command = string.Empty;

            char[,] screen = CreatePlayerScreen();
            char[,] bombs = SetupTheBombs();

            int timer = 0;
            bool fire = false;

            List<Player> champions = new List<Player>(6);

            int row = 0;
            int col = 0;
            bool flag = true;
            const int max = 35;
            bool secondFlag = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Lets play to the game “Mines”. You can test your luck" +
                    "Command 'top' show players count, 'restart' start new game, 'exit' stop the game!");

                    ScreenSize(screen);
                    flag = false;
                }

                Console.Write("Row and Col: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= screen.GetLength(0) &&
                        col <= screen.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        {
                            ResultCount(champions);
                            break;
                        }

                    case "restart":
                        {
                            screen = CreatePlayerScreen();
                            bombs = SetupTheBombs();
                            ScreenSize(screen);
                            fire = false;
                            flag = false;
                            break;
                        }

                    case "exit":
                        {
                            Console.WriteLine("Exit!");
                            break;
                        }

                    case "turn":
                        {
                            if (bombs[row, col] != '*')
                            {
                                if (bombs[row, col] == '-')
                                {
                                    ItIsYourTurn(screen, bombs, row, col);
                                    timer++;
                                }
                                if (max == timer)
                                {
                                    secondFlag = true;
                                }
                                else
                                {
                                    ScreenSize(screen);
                                }
                            }
                            else
                            {
                                fire = true;
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Error! Invalid Command!");
                            break;
                        }
                }
                if (fire)
                {
                    ScreenSize(bombs);

                    Console.Write("\nHrrrrrr! Game over. The player have {0} points. " +
                        "Nickname: ", timer);

                    string nickName = Console.ReadLine();

                    Player newPlayer = new Player(nickName, timer);

                    if (champions.Count < 5)
                    {
                        champions.Add(newPlayer);
                    }
                    else
                    {
                        for (int champion = 0; champion < champions.Count; champion++)
                        {
                            if (champions[champion].Points < newPlayer.Points)
                            {
                                champions.Insert(champion, newPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));

                    ResultCount(champions);

                    screen = CreatePlayerScreen();
                    bombs = SetupTheBombs();
                    timer = 0;
                    fire = false;
                    flag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nGood job! Next level.");
                    ScreenSize(bombs);

                    Console.WriteLine("Enter your nickname: ");
                    string nickName = Console.ReadLine();
                    Player newPleyer = new Player(nickName, timer);

                    champions.Add(newPleyer);
                    ResultCount(champions);
                    screen = CreatePlayerScreen();
                    bombs = SetupTheBombs();
                    timer = 0;
                    secondFlag = false;
                    flag = true;
                }
            }

            while (command != "exit");

            Console.Read();
        }

        private static void ResultCount(List<Player> points)
        {
            Console.WriteLine("\nTotal points:");

            if (points.Count > 0)
            {
                for (int point = 0; point < points.Count; point++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes",
                        point + 1, points[point].Name, points[point].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Result is empty!\n");
            }
        }

        private static void ItIsYourTurn(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = Counter(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }

        private static void ScreenSize(char[,] board)
        {
            int boardWidth = board.GetLength(0);
            int boardHeight = board.GetLength(1);

            Console.WriteLine("\n0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("---------------------");

            for (int i = 0; i < boardWidth; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < boardHeight; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("---------------------\n");
        }

        private static char[,] CreatePlayerScreen()
        {
            int boardRows = 5;
            int boardColumns = 10;

            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetupTheBombs()
        {
            int rows = 5;
            int cols = 10;

            char[,] playerScreen = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playerScreen[i, j] = '-';
                }
            }

            List<int> result = new List<int>();

            while (result.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);

                if (!result.Contains(asfd))
                {
                    result.Add(asfd);
                }
            }

            foreach (int element in result)
            {
                int col = (element / cols);
                int row = (element % cols);

                if (row == 0 && element != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playerScreen[col, row - 1] = '*';
            }

            return playerScreen;
        }

        private static void ResultCounts(char[,] board)
        {
            int col = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char isEnought = Counter(board, i, j);
                        board[i, j] = isEnought;
                    }
                }
            }
        }

        private static char Counter(char[,] result, int resultRow, int resultCol)
        {
            int counter = 0;
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            if (resultRow - 1 >= 0)
            {
                if (result[resultRow - 1, resultCol] == '*')
                {
                    counter++;
                }
            }
            if (resultRow + 1 < rows)
            {
                if (result[resultRow + 1, resultCol] == '*')
                {
                    counter++;
                }
            }
            if (resultCol - 1 >= 0)
            {
                if (result[resultRow, resultCol - 1] == '*')
                {
                    counter++;
                }
            }
            if (resultCol + 1 < cols)
            {
                if (result[resultRow, resultCol + 1] == '*')
                {
                    counter++;
                }
            }
            if ((resultRow - 1 >= 0) && (resultCol - 1 >= 0))
            {
                if (result[resultRow - 1, resultCol - 1] == '*')
                {
                    counter++;
                }
            }
            if ((resultRow - 1 >= 0) && (resultCol + 1 < cols))
            {
                if (result[resultRow - 1, resultCol + 1] == '*')
                {
                    counter++;
                }
            }
            if ((resultRow + 1 < rows) && (resultCol - 1 >= 0))
            {
                if (result[resultRow + 1, resultCol - 1] == '*')
                {
                    counter++;
                }
            }
            if ((resultRow + 1 < rows) && (resultCol + 1 < cols))
            {
                if (result[resultRow + 1, resultCol + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}
