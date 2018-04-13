using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source_Timer_Group_Project
{
	public class pathNode
	{
		#region Variables

		private pathNode prevPath; //The path directly behind this one
		private pathNode nextPath; //The path dircetly before this one
		private timerNodeControl timers; //The Timer Node Control linked to this path - It manages this path's timers -
		private eventNodeControler events;
		private String pathName; //Path's Name

		#endregion
		#region Getters/Setters
		public pathNode getPrevPath()
		{
			return prevPath;
		}
		public void setPrevpath(pathNode prevPathX)
		{
			prevPath = prevPathX;
		}

		public pathNode getNextPath()
		{
			return nextPath;
		}
		public void setNextpath(pathNode nextPathX)
		{
			nextPath = nextPathX;
		}

		public timerNodeControl getTimers()
		{
			return timers;
		}
		public void setTimers(timerNodeControl timersX)
		{
			timers = timersX;
		}

		public string getPathName()
		{
			return pathName;
		}
		public void setPathName(String pathNameX)
		{
			pathName = pathNameX;
		}

		public eventNodeControler getEvents()
		{
			return events;
		}
		public void setEvents(eventNodeControler eventsX)
		{
			events = eventsX;
		}

		#endregion
		#region Constructors
		public pathNode()
		{
			//Defult constructor
			prevPath = null;
			nextPath = null;
			timers = new timerNodeControl();
			events = new eventNodeControler();
		}

		public pathNode(String pathNameX)
		{
			//Constructor used for the first path created
			prevPath = null;
			nextPath = null;
			pathName = pathNameX;
			timers = new timerNodeControl();
			events = new eventNodeControler();
		}

		public pathNode(String pathNameX, pathNode prevPathX)
		{
			//Constructor for when only the prev path is know (The second path created)
			pathName = pathNameX;
			prevPath = prevPathX;
			prevPath = null;
			timers = new timerNodeControl();
			events = new eventNodeControler();
		}

		public pathNode(String pathNameX, pathNode prevPathX, pathNode nextPathX)
		{
			//Constructor that is going to be used the most often. Used when > 2 paths created
			pathName = pathNameX;
			prevPath = prevPathX;
			nextPath = nextPathX;
			timers = new timerNodeControl();
			events = new eventNodeControler();
		}
		#endregion

		public void changePathName(String oldName)
		{
			//changing the path name
			Console.WriteLine("What would you like to Change the Path name to?");
			string newName = Console.ReadLine(); //reading in the new path name
			pathName = newName;
			Console.WriteLine("Path " + oldName + " is now named " + newName);
		}






		#region Misc.
		public String toString()
		{
			return (pathName);
		}
		#endregion
	}
}
