using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
	public interface IMazeObject
	{
		char Icon { get; set; }  // The shape of the maze object(Player, Wall, EmptySpace)
		bool IsSolid { get; set; }  // Movement block -> object will move through(EmptySpace) or not(Wall)

	}
}
