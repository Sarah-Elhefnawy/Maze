using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
	internal class Wall : IMazeObject
	{
		public char Icon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool IsSolid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
