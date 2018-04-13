using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source_Timer_Group_Project
{
	public class timerNode
	{
		#region Variables
		private timerNode prevTimer;
		private timerNode nextTimer;
		private medNode med;
		private Counter counter;
        private string timerName;
		private string pathName;
		private DateTime start;
		private bool running;
		#endregion
		#region Getters/Setters
		public timerNode getPrevTimer()
		{
			return prevTimer;
		}
		public void setPrevTimer(timerNode prevTimerX)
		{
			prevTimer = prevTimerX;
		}

		public timerNode getNextTimer()
		{
			return nextTimer;
		}
		public void setNextTimer(timerNode nextTimerX)
		{
			nextTimer = nextTimerX;
		}

        public string getTimerName()
        {
            return timerName;
        }
        public void setTimerName(String nameX)
        {
            timerName = nameX;
        }

        public medNode getMed()
        {
            return med;
        }
        public void setMed(medNode medX)
        {
            med = medX;
        }

		public DateTime getStart()
		{
			return start;
		}
		public void setStart(DateTime startX)
		{
			start = startX;
		}

		public bool getRunning()
		{
			return running;
		}
		public void setRunning(bool runningX)
		{
			running = runningX;
		}
		#endregion
		#region Constructor
		public timerNode()
		{
			//Defult constructor
			prevTimer = null;
			nextTimer = null;
			med = null;
			counter = Counter.Master();
			running = false;
		}

		public timerNode(String timerNameX)
		{
			//Constructor used for the first path created
			prevTimer = null;
			nextTimer = null;
			timerName = timerNameX;
			med = null;
			counter = Counter.Master();
			running = false;
		}

		public timerNode(String timerNameX, timerNode prevTimerX)
		{
			//Constructor for when only the prev path is know (The second path created)
			timerName = timerNameX;
			prevTimer = prevTimerX;
			prevTimer = null;
			med = null;
			counter = Counter.Master();
			running = false;
		}

		public timerNode(String timerNameX, timerNode prevTimerX, timerNode nextTimerX)
		{
			//Constructor that is going to be used the most often. Used when > 2 paths created
			timerName = timerNameX;
			prevTimer = prevTimerX;
			nextTimer = nextTimerX;
			med = null;
			counter = Counter.Master();
			running = false;
		}

		public timerNode(String timerNameX, medNode medX, string pathNameX)
		{
			timerName = timerNameX;
			med = medX;
			pathName = pathNameX;
			counter = Counter.Master();
			running = false;
		}
		#endregion


		public void startTimer(bool thread)
		{

			DateTime start = DateTime.Now;
			TimeSpan timeRamaining = TimeSpan.FromSeconds(0);
			running = true;
			do
			{
				TimeSpan Delta = DateTime.Now - start;
				timeRamaining = med.getTime() - Delta;
				Console.WriteLine(timeRamaining);

			} while (timeRamaining.TotalSeconds > 0);

		}

		public void startTimer()
		{

		}
		#region Misc.

		public void toString()
		{
			Console.WriteLine("Timer Name: " + timerName);
			Console.Write("Link Medication: " + med.getName());
			Console.WriteLine("Home Path: " + pathName);
		}
		#endregion
	}
}
