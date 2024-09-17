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

        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;

        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            ConsoleKey key = userInput.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:

                    break;
                case ConsoleKey.DownArrow:

                    break;
                case ConsoleKey.LeftArrow:

                    break;
                case ConsoleKey.RightArrow:

                    break;
            }
        }
    }
}
