using System;
using System.Collections.Generic;

namespace Ex3._04
{
	public class Mines
	{
		public class Player
		{
			private string name;
			private int points;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

			public int Points
			{
				get { return points; }
				set { points = value; }
			}

			public Player() { }

			public Player(string name, int points)
			{
				this.name = name;
				this.points = points;
			}
		}

		static void Main(string[] аргументи)
		{
			string command = string.Empty;

			char[,] field = CreateField();
			char[,] bombs = PlaceBombs();

			int counter = 0;

			bool isExplosion = false;

			List<Player> players = new List<Player>(6);

			int row = 0;
			int column = 0;
            const int max = 35;

            bool isGameOver = true;
			bool isWin = false;

			do
			{
				if (isGameOver)
				{
					Console.WriteLine(
						"Let's play \"Mines\". " +
						"Try to find the cells with no mines." +
						" The 'top' command shows the leaderboard, " +
						"'restart' starts a new game," +
						" 'exit' exits the application!");

					PrintBoard(field);

					isGameOver = false;
				}

				Console.Write("Enter row and column: ");
				command = Console.ReadLine().Trim();

				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
							int.TryParse(command[2].ToString(), out column) &&
							row <= field.GetLength(0) && 
							column <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						Leaderboard(players);
						break;
					case "restart":
						field = CreateField();
						bombs = PlaceBombs();

						PrintBoard(field);

						isExplosion = false;
						isGameOver = false;

						break;
					case "exit":
						Console.WriteLine("Bye, bye, bye!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								ChangeTurns(field, bombs, row, column);
								counter++;
							}

							if (max == counter)
							{
								isWin = true;
							}
							else
							{
								PrintBoard(field);
							}
						}
						else
						{
							isExplosion = true;
						}

						break;
					default:
						Console.WriteLine("\nError! Invalid command!\n");
						break;
				}
				if (isExplosion)
				{
					PrintBoard(bombs);

					Console.Write(
						$"\nHrrrrrr! You died heroically with {counter} points. " +
						"Enter your nickname: ");

					string nickname = Console.ReadLine();

					Player player = new Player(nickname, counter);

					if (players.Count < 5)
					{
						players.Add(player);
					}
					else
					{
						for (int i = 0; i < players.Count; i++)
						{
							if (players[i].Points < player.Points)
							{
								players.Insert(i, player);
								players.RemoveAt(players.Count - 1);

								break;
							}
						}
					}

					players.Sort((Player p1, Player p2) 
						=> p2.Name.CompareTo(p1.Name));

					players.Sort((Player p1, Player p2) 
						=> p2.Points.CompareTo(p1.Points));

					Leaderboard(players);

					field = CreateField();
					bombs = PlaceBombs();

					counter = 0;

					isExplosion = false;
					isGameOver = true;
				}
				if (isWin)
				{
					Console.WriteLine(
						"\nBravo! You opened 35 cells " +
						"without a single drop of blood.");

					PrintBoard(bombs);
					
					Console.WriteLine("Enter your name: ");

					string name = Console.ReadLine();

					Player player = new Player(name, counter);
					players.Add(player);

					Leaderboard(players);

					field = CreateField();
					bombs = PlaceBombs();
					counter = 0;
					isWin = false;
					isGameOver = true;
				}
			}

			while (command != "exit");

			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void Leaderboard(List<Player> players)
		{
			Console.WriteLine("\nPoints:");

			if (players.Count > 0)
			{
				for (int i = 0; i < players.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells",
						i + 1, players[i].Name, players[i].Points);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Leaderboard is empty!\n");
			}
		}

		private static void ChangeTurns(
			char[,] field,
			char[,] bombs,
			int row, 
			int column)
		{
			char amountOfBombs = GetAmount(bombs, row, column);

			bombs[row, column] = amountOfBombs;
			field[row, column] = amountOfBombs;
		}

		private static void PrintBoard(char[,] board)
		{
			int rows = board.GetLength(0);
			int columns = board.GetLength(1);

			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");

			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);

				for (int j = 0; j < columns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}

				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateField()
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

		private static char[,] PlaceBombs()
		{
			int rows = 5;
			int columns = 10;

			char[,] field = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					field[i, j] = '-';
				}
			}

			List<int> bombPositions = new List<int>();

			while (bombPositions.Count < 15)
			{
				Random random = new Random();

				int randomPosition = random.Next(50);
				
				if (!bombPositions.Contains(randomPosition))
				{
					bombPositions.Add(randomPosition);
				}
			}

			foreach (int position in bombPositions)
			{
				int newColumns = (position / columns);
				int newRows = (position % columns);

				if (newRows == 0 && position != 0)
				{
					newColumns--;
					newRows = columns;
				}
				else
				{
					newRows++;
				}

				field[newRows, newColumns - 1] = '*';
			}

			return field;
		}

		private static void Calculate(char[,] field)
		{
			int rows = field.GetLength(0);
			int columns = field.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					if (field[i, j] != '*')
					{
						char amount = GetAmount(field, i, j);
						field[i, j] = amount;
					}
				}
			}
		}

		private static char GetAmount(char[,] bombs, int rows, int columns)
		{
			int amount = 0;
			int thisRows = bombs.GetLength(0);
			int thisColumns = bombs.GetLength(1);

			if (rows - 1 >= 0)
			{
				if (bombs[rows - 1, columns] == '*')
				{ 
					amount++; 
				}
			}

			if (rows + 1 < thisRows)
			{
				if (bombs[rows + 1, columns] == '*')
				{ 
					amount++; 
				}
			}

			if (columns - 1 >= 0)
			{
				if (bombs[rows, columns - 1] == '*')
				{ 
					amount++;
				}
			}

			if (columns + 1 < columns)
			{
				if (bombs[rows, columns + 1] == '*')
				{ 
					amount++;
				}
			}

			if ((rows - 1 >= 0) && (columns - 1 >= 0))
			{
				if (bombs[rows - 1, columns - 1] == '*')
				{ 
					amount++; 
				}
			}

			if ((rows - 1 >= 0) && (columns + 1 < thisColumns))
			{
				if (bombs[rows - 1, columns + 1] == '*')
				{ 
					amount++; 
				}
			}

			if ((rows + 1 < thisRows) && (columns - 1 >= 0))
			{
				if (bombs[rows + 1, columns - 1] == '*')
				{ 
					amount++; 
				}
			}

			if ((rows + 1 < thisRows) && (columns + 1 < thisColumns))
			{
				if (bombs[rows + 1, columns + 1] == '*')
				{ 
					amount++; 
				}
			}

			return char.Parse(amount.ToString());
		}
	}
}
