using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Method_Source_Timer_Group_Project;

namespace Timer_Group_Project_GUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		
		[STAThread]
		static void Main()
		{
			#region instantiation
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			medNodeControl master = medNodeControl.Master();
			#endregion

			Application.Run(new Main_Screen());
		}
	}
}
