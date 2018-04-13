using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source_Timer_Group_Project
{
	class M
	{

		public static void BL()
		{
			Console.WriteLine("");
		}

		public static void debug(String message)
		{
			BL();
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.White;
			BL();
		}
	}
}
