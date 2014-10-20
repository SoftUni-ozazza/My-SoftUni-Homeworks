namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        public class Score
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

            public Score()
            {
            }

            public Score(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }
        }

        private static void Main()
        {
            const int MaxGameTurns = 35;

            List<Score> winnersScoreList = new List<Score>(6);
            char[,] questionField = CreateQuestionMarkField();
            char[,] bombField = CreateBombField();

            int row = 0;
            int col = 0;
            string command = string.Empty;
            bool isGameOver = false;
            bool isStartNewGame = true;
            bool isWinningTheGame = false;

            do
            {
                if (isStartNewGame)
                {
                    Console.WriteLine("Lets play “Minesweeper”.\nTry to find fields without mines.");
                    Console.WriteLine("\nCommands:\n");
                    Console.WriteLine("'top' -> shows scoreboard");
                    Console.WriteLine("'restart' -> starts new game");
                    Console.WriteLine("'exit' -> exits game");

                    PrintStartGameField(questionField);
                    isStartNewGame = false;
                }

                Console.Write("Add row and col: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= questionField.GetLength(0) &&
                        col <= questionField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                int pointsCounter = 0;
                switch (command)
                {
                    case "top":
                        PrintScoreboardWinners(winnersScoreList);
                        break;

                    case "restart":
                        questionField = CreateQuestionMarkField();
                        bombField = CreateBombField();
                        PrintStartGameField(questionField);
                        isGameOver = false;
                        isStartNewGame = false;
                        break;

                    case "exit":
                        Console.WriteLine("Bye! Come back soon!");
                        break;

                    case "turn":
                        if (bombField[row, col] != '*')
                        {
                            if (bombField[row, col] == '-')
                            {
                                CheckPlayerChoice(questionField, bombField, row, col);
                                pointsCounter++;
                            }

                            if (MaxGameTurns == pointsCounter)
                            {
                                isWinningTheGame = true;
                            }
                            else
                            {
                                PrintStartGameField(questionField);
                            }
                        }
                        else
                        {
                            isGameOver = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nUpss.. Try another command!\n");
                        break;
                }

                if (isGameOver)
                {
                    PrintStartGameField(bombField);
                    Console.Write("\nHrrrrrr! You died like a hero! You have {0} points.\nYour name: ", pointsCounter);
                    string playerName = Console.ReadLine();

                    Score player = new Score(playerName, pointsCounter);
                    if (winnersScoreList.Count < 5)
                    {
                        winnersScoreList.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < winnersScoreList.Count; i++)
                        {
                            if (winnersScoreList[i].Points < player.Points)
                            {
                                winnersScoreList.Insert(i, player);
                                winnersScoreList.RemoveAt(winnersScoreList.Count - 1);
                                break;
                            }
                        }
                    }

                    winnersScoreList.Sort((Score winner, Score looser) => looser.Name.CompareTo(winner.Name));
                    winnersScoreList.Sort((Score winner, Score looser) => looser.Points.CompareTo(winner.Points));
                    PrintScoreboardWinners(winnersScoreList);

                    questionField = CreateQuestionMarkField();
                    bombField = CreateBombField();
                    pointsCounter = 0;

                    isGameOver = false;
                    isStartNewGame = true;
                }

                if (isWinningTheGame)
                {
                    Console.WriteLine("\nBRAVOOOS! You open up 35 cells!");

                    PrintStartGameField(bombField);

                    Console.WriteLine("Enter your name: ");

                    string playerName = Console.ReadLine();

                    Score newWinner = new Score(playerName, pointsCounter);
                    winnersScoreList.Add(newWinner);
                    PrintScoreboardWinners(winnersScoreList);

                    questionField = CreateQuestionMarkField();
                    bombField = CreateBombField();
                    pointsCounter = 0;

                    isWinningTheGame = false;
                    isStartNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void PrintScoreboardWinners(List<Score> winners)
        {
            Console.WriteLine("\nWinners:");
            if (winners.Count > 0)
            {
                for (int i = 0; i < winners.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, winners[i].Name, winners[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("empty scoreboard!\n");
            }
        }

        private static void CheckPlayerChoice(char[,] questionMarkField, char[,] bombField, int rowIndexPlayer, int colIndexPlayer)
        {
            char cellPlayerChoice = CalculateBombsAroundCell(bombField, rowIndexPlayer, colIndexPlayer);
            bombField[rowIndexPlayer, colIndexPlayer] = cellPlayerChoice;
            questionMarkField[rowIndexPlayer, colIndexPlayer] = cellPlayerChoice;
        }

        private static void PrintStartGameField(char[,] questionMarkField)
        {
            int lengthBoardRow = questionMarkField.GetLength(0);
            int lengthBoardCol = questionMarkField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int indexRow = 0; indexRow < lengthBoardRow; indexRow++)
            {
                Console.Write("{0} | ", indexRow);
                for (int indexCol = 0; indexCol < lengthBoardCol; indexCol++)
                {
                    Console.Write(string.Format("{0} ", questionMarkField[indexRow, indexCol]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateQuestionMarkField()
        {
            const int BoardRows = 5;
            const int BoardColumns = 10;

            char[,] questionMarkField = new char[BoardRows, BoardColumns];

            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardColumns; col++)
                {
                    questionMarkField[row, col] = '?';
                }
            }

            return questionMarkField;
        }

        private static char CalculateBombsAroundCell(char[,] bombField, int rowIndex, int colIndex)
        {
            int bombsAround = 0;
            int rowMaxLength = bombField.GetLength(0);
            int colMaxLength = bombField.GetLength(1);

            if (rowIndex - 1 >= 0)
            {
                if (bombField[rowIndex - 1, colIndex] == '*')
                {
                    bombsAround++;
                }
            }

            if (rowIndex + 1 < rowMaxLength)
            {
                if (bombField[rowIndex + 1, colIndex] == '*')
                {
                    bombsAround++;
                }
            }

            if (colIndex - 1 >= 0)
            {
                if (bombField[rowIndex, colIndex - 1] == '*')
                {
                    bombsAround++;
                }
            }

            if (colIndex + 1 < colMaxLength)
            {
                if (bombField[rowIndex, colIndex + 1] == '*')
                {
                    bombsAround++;
                }
            }

            if ((rowIndex - 1 >= 0) && (colIndex - 1 >= 0))
            {
                if (bombField[rowIndex - 1, colIndex - 1] == '*')
                {
                    bombsAround++;
                }
            }

            if ((rowIndex - 1 >= 0) && (colIndex + 1 < colMaxLength))
            {
                if (bombField[rowIndex - 1, colIndex + 1] == '*')
                {
                    bombsAround++;
                }
            }

            if ((rowIndex + 1 < rowMaxLength) && (colIndex - 1 >= 0))
            {
                if (bombField[rowIndex + 1, colIndex - 1] == '*')
                {
                    bombsAround++;
                }
            }

            if ((rowIndex + 1 < rowMaxLength) && (colIndex + 1 < colMaxLength))
            {
                if (bombField[rowIndex + 1, colIndex + 1] == '*')
                {
                    bombsAround++;
                }
            }

            return char.Parse(bombsAround.ToString());
        }

        private static void CreateCountingCellsField(char[,] bombField)
        {
            int rowMaxLength = bombField.GetLength(0);
            int colMaxLength = bombField.GetLength(1);

            for (int i = 0; i < rowMaxLength; i++)
            {
                for (int j = 0; j < colMaxLength; j++)
                {
                    if (bombField[i, j] != '*')
                    {
                        char bombsAroundCell = CalculateBombsAroundCell(bombField, i, j);
                        bombField[i, j] = bombsAroundCell;
                    }
                }
            }
        }

        private static char[,] CreateBombField()
        {
            int rows = 5;
            int cols = 10;
            char[,] bombField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bombField[i, j] = '-';
                }
            }

            List<int> minesIndexer = new List<int>();

            while (minesIndexer.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!minesIndexer.Contains(randomNumber))
                {
                    minesIndexer.Add(randomNumber);
                }
            }

            foreach (int lotteryWinner in minesIndexer)
            {
                int col = lotteryWinner / cols;
                int row = lotteryWinner % cols;

                if (row == 0 && lotteryWinner != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                bombField[col, row - 1] = '*';
            }

            return bombField;
        }
    }
}