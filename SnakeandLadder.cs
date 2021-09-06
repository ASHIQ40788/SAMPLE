using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
	class SnakeandLadder
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int dice = rnd.Next(1, 7);// creates a number between 1 and 6
			Console.Write(dice);
			Console.Read();
		}
	}
}
