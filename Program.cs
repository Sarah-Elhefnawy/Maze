namespace Maze
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello to the maze game!");
			Console.WriteLine("Use keyboard arrows to move the player");

			Maze maze = new Maze(20, 20);

			maze.DrawMaze();
		}
	}
}
