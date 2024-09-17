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
        }

        public void DrawMaze()
        {
            for (int y = 0; y < _Height; y++) 
            { 
                for (int x = 0; x < _Width; x++)
                {
                    _MazeObjectsArray[x, y] = new Wall();

                    Console.Write(_MazeObjectsArray[x, y].Icon);
                }
                Console.WriteLine();
            }
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            ConsoleKey key = userInput.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.DownArrow:
					UpdatePlayer(0, -1);
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

            if (newX < _Width && newX>= 0 && newY < _Height && newY >= 0)
            {
				_Player.X = newX;
				_Player.Y = newY;
			}
        }
    }
}
