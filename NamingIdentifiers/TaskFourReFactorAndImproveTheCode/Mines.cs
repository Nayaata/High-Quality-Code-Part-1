namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public class Points
        {
            private string name;
            private int points;

            public string Name
            {
                get 
                { 
                    return this.name; 
                }
                set 
                { 
                    this.name = value; 
                }
            }

            public int Points
            {
                get 
                {
                    return this.points; 
                }
                set
                {
                    this.points = value;
                }
            }

            public Points() 
            { 
            }

            public Points(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }
        }

        static void Main()
        {
            string command = string.Empty;
            char[,] screen = CreatePlayerScreen();
            char[,] bombs = PutTheBombs();
            int timer = 0;
            bool fire = false;

            List<Points> champions = new List<Points>(6);

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
                    "Command 'top' show players count, 'restart' start new game, 'exit' stop the game and than say Good night!");

                    dumpp(screen);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
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
                            klasacia(champions);
                            break;
                        }

                    case "restart":
                        {
                            screen = CreatePlayerScreen();
                            bombs = PutTheBombs();
                            dumpp(screen);
                            fire = false;
                            flag = false;
                            break;
                        }

                    case "exit":
                        {
                            Console.WriteLine("4a0, 4a0, 4a0!");
                            break;
                        }

                    case "turn":
                        {
                            if (bombs[row, col] != '*')
                            {
                                if (bombs[row, col] == '-')
                                {
                                    tisinahod(screen, bombs, row, col);
                                    timer++;
                                }
                                if (max == timer)
                                {
                                    secondFlag = true;
                                }
                                else
                                {
                                    dumpp(screen);
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
                            Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                            break;
                        }
                }
                if (fire)
                {
                    dumpp(bombs);

                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", timer);

                    string nickName = Console.ReadLine();
                    Points t = new Points(nickName, timer);

                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Points.CompareTo(r1.Points));

                    klasacia(champions);

                    screen = CreatePlayerScreen();
                    bombs = PutTheBombs();
                    timer = 0;
                    fire = false;
                    flag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Points to4kii = new Points(imeee, timer);
                    champions.Add(to4kii);
                    klasacia(champions);
                    screen = CreatePlayerScreen();
                    bombs = PutTheBombs();
                    timer = 0;
                    secondFlag = false;
                    flag = true;
                }
            }

            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void klasacia(List<Points> to4kii)
        {
            Console.WriteLine("\nTo4KI:");

            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }

        private static void dumpp(char[,] board)
        {
            int RRR = board.GetLength(0);
            int KKK = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < RRR; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < KKK; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
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

        private static char[,] PutTheBombs()
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

            List<int> r3 = new List<int>();

            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);

                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = (i2 / cols);
                int red = (i2 % cols);

                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = cols;
                }
                else
                {
                    red++;
                }

                playerScreen[kol, red - 1] = '*';
            }

            return playerScreen;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            return char.Parse(brojkata.ToString());
        }
    }
}