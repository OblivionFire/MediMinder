using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source_Timer_Group_Project
{
	class Program
	{
		static void Main(string[] args)
		{
			pathNodeControl paths = pathNodeControl.Master();
			medNodeControl meds = medNodeControl.Master();
			paths.addPath("Path One");
			paths.addPath("Path Two");
			paths.addPath("Path Three");
			TimeSpan temp = new TimeSpan(0, 20, 0);
			meds.addMed("Saline", "20 mg", temp);

			TimeSpan temp2 = new TimeSpan(0, 10, 0);
			meds.addMed("Pulmozym", "10 mg", temp2);

			TimeSpan temp3 = new TimeSpan(0, 30, 0);
			meds.addMed("Vest", "Minnisota Protical", temp3);

			paths.addTimer("Path One", "Saline", "Saline");

			DateTime temp4 = new DateTime(2017, 11, 29, 18, 45, 55, 0);
			paths.addEvent("Path One", "Test", temp4);
			paths.startTimer("Path One");

		}
	}
}
