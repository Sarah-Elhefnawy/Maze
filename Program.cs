namespace Maze
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello to the maze game!");
			Console.WriteLine("Use keyboard arrows to move the player");

			// Construct new maze
			Maze maze = new Maze(10, 12);

			while (true)
			{
				maze.DrawMaze();
				maze.MovePlayer();
			}
			


		}
	}
}
