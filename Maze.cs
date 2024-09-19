using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
	public class Maze
	{
        private int _Width;
        private int _Height;

        private Player _Player;
        // calling an object from player class to tell maze class where the player is in the maze

        private IMazeObject[,] _MazeObjectsArray;

        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            _MazeObjectsArray = new IMazeObject[width, height];
            _Player = new Player()
            {
                X = 1,
                Y = 1
            };
            //_Player.X = 1;
            //_Player.Y = 1;
        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Height; y++) 
            { 
                for (int x = 0; x < _Width; x++)
				{
					// Outer walls && Exit
					if (x==0 && y == 1 ) // entry
					{
						_MazeObjectsArray[x, y] = new EmptySpace();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
					else if (x == 9 && y == 9)     //exit
					{
						_MazeObjectsArray[x, y] = new EmptySpace();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
					else if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
					{
						_MazeObjectsArray[x, y] = new Wall();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
                    else if (x == _Player.X && y == _Player.Y)
					{
                        Console.Write(_Player.Icon);
                    }
                    else if (x % 3 ==0 && y % 3 ==0)
                    {
						_MazeObjectsArray[x, y] = new Wall();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
					else if (x % 2 == 0 && y % 2 == 0)
					{
						_MazeObjectsArray[x, y] = new Wall();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
					else if (x % 5 == 0 && y % 5 == 0)
					{
						_MazeObjectsArray[x, y] = new Wall();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
					else // Empty spaces
                    {
						_MazeObjectsArray[x, y] = new EmptySpace();
						Console.Write(_MazeObjectsArray[x, y].Icon);
					}
				}
                Console.WriteLine();
            }
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey(true);

            ConsoleKey key = userInput.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
					UpdatePlayer(0, 1);
					break;
                case ConsoleKey.LeftArrow:
					UpdatePlayer(-1, 0);
					break;
                case ConsoleKey.RightArrow:
					UpdatePlayer(1, 0);
					break;
            }
        }

        private void UpdatePlayer(int playerMazeX, int playerMazeY)
        {
            int newX = _Player.X + playerMazeX;
            int newY = _Player.Y + playerMazeY;

            if (newX < _Width && newX>= 0 && newY < _Height && newY >= 0 && !_MazeObjectsArray[newX, newY].IsSolid)
			{
				_Player.X = newX;
				_Player.Y = newY;
                DrawMaze();
			}
        }
    }
}
