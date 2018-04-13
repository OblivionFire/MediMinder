using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Method_Source_Timer_Group_Project
{
	public class Counter
	{
		#region Variables
		private pathNodeControl pathMaster;
		private medNodeControl medMaster;
		private timerNodeControl timers;
		public static Counter master;
		#endregion
		#region Getters/Setters
		#endregion
		#region Constructors
		public Counter()
		{
			pathMaster = pathNodeControl.Master();
			medMaster = medNodeControl.Master();
			Thread burner = new Thread(() => timerCallBack());
		}
		#endregion
		#region Master
		public static Counter Master()
		{
			if(master == null)
			{
				master = new Counter();
			}

			return master;
		}
		#endregion

		public void addTimer(timerNode timerToAdd)
		{

		}


		public void timerCallBack()
		{

		}
	}
}
