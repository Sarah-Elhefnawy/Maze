using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
	public interface IMazeObject
	{
		// there is not set -->> cuz i can't add value to these variables in each class 
		//                       the value is unchangeable(there is a wall at the top its value won't change so the player can't pass)
		char Icon { get; }  // The shape of the maze object(Player, Wall, EmptySpace)
		bool IsSolid { get; }  // Movement block -> object will move through(EmptySpace) or not(Wall)

	}
}
