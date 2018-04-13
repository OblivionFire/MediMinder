using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source_Timer_Group_Project
{
	public class medNodeControl
	{
		#region Variables
		private medNode firstMed; //first medication node stored
		private medNode MS; //Med Scanner
		private static medNodeControl master; //Singleton master copy
		#endregion
		#region Constructors
		public medNodeControl()
		{
			firstMed = null;
			MS = null;
		}
		#endregion
		#region Master
		public static medNodeControl Master()
		{
			if(master == null)
			{
				master = new medNodeControl();
			}

			return master;
		}
		#endregion

		public void addMed(String medNameX, String medDoesX, TimeSpan treatTimeX)
		{
			/*
			 * Three Conditions
			 * First med == null - No meds - Firstmed = New med
			 * First med.getNext() == null - One Med - FirstMed.getNext().setNext(New med)
			 * First med.getNext() != null - > Two meds - find last and assign
			 */

			if (firstMed == null)
			{
				medNode newMed = new medNode(medNameX, medDoesX, treatTimeX);
				firstMed = newMed;
				Console.ForegroundColor = ConsoleColor.DarkGray;
				M.debug("New Med Created, assigned to firstMed");
			}

			else if (firstMed.getNextMed() == null)
			{
				medNode newMed = new medNode(medNameX, medDoesX, treatTimeX);
				firstMed.setNextMed(newMed); //firstMed.next = newMed
				newMed.setPrevMed(firstMed);
				M.debug("New Med Created, registered as second med created");
			}

			else
			{
				MS = firstMed;
				while (MS.getNextMed() != null)
				{
					//Find last med
					MS = MS.getNextMed();
				}
				medNode newMed = new medNode(medNameX, medDoesX, treatTimeX);
				MS.setNextMed(newMed); //lastPath.next = newMed
				newMed.setPrevMed(MS); //newMed.last = lastPath

				M.debug("Med created, Unkown Med possiton, Prev/Next med values assigned accordingly");
			}

		}








		#region Misc.
		public void printMeds()
		{
			if(firstMed == null)
			{
				Console.WriteLine("There are no meds to display");
			}

			else
			{
				MS = firstMed;

				while(MS != null)
				{
					MS.toString();
					M.BL();
					MS = MS.getNextMed();
				}
			}
		}

		public medNode findMed(string medName)
		{
			if(firstMed == null)
			{
				//If first med is null there are no meds
				M.debug("First Med is null");
				return null;
			}

			else
			{
				MS = firstMed;
				while(MS != null)
				{
					if(MS.getName().Equals(medName))
					{
						//Return first found med with proper name
						M.debug("Return found value");
						return MS;
					}

					MS = MS.getNextMed();
				}

				//returning null if nothing found
				M.debug("Nothing found returning null");
				return null;
			}
		}

		public medNode[] getMedArray()
		{
			int medCount = 1;

			if(firstMed == null)
			{
				medNode[] temp = new medNode[0];
				return temp;
			}

			else
			{
				MS = firstMed;

				while(MS.getNextMed() != null)
				{
					medCount++;
					MS = MS.getNextMed();
				}

				medNode[] meds = new medNode[medCount];

				MS = firstMed;

				for(int i = 0; i<medCount; i++)
				{
					meds[i] = MS;
					MS = MS.getNextMed();
				}

				return meds;
			}
		}
		#endregion
	}
}
