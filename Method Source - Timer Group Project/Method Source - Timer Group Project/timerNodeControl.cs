using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Method_Source_Timer_Group_Project
{
	public class timerNodeControl
	{
		#region Variables
		private timerNode firstTimer; //referance to first node stored
		private timerNode TS; //A scanner used to accsess data in a non-discructive fassion
		private medNodeControl medMaster; //referance to med controller
		#endregion
		#region Getters/Setters
		public timerNode getFirstNode()
		{
			return firstTimer;
		}
		public void setFristNode(timerNode firstNodeX)
		{
			firstTimer = firstNodeX;
		}

		/*
		 * No getter and setter for TS, it will never be called out side this method
		 */
		#endregion
		#region Constructors

		public timerNodeControl()
		{
			firstTimer = null;
			TS = null;
			medMaster = medNodeControl.Master();
		}

		#endregion




		public void addTimer(String timerNodeX, medNode medX, string pathNameX)
		{
			/*
			 * Three Conditions
			 * First Timer == null - No Timers - firstTimer = New Path
			 * First Timer.getNext() == null - One Timer - firstTimer.getNext().setNext(New Timer)
			 * First Timer.getNext() != null - > Two Timers - find last and assign
			 */

			if (firstTimer == null)
			{
				timerNode newTimer = new timerNode(timerNodeX, medX, pathNameX);
				firstTimer = newTimer;
				Console.ForegroundColor = ConsoleColor.DarkGray;
				M.debug("New Timer Created, assigned to firstTimer");
			}

			else if (firstTimer.getNextTimer() == null)
			{
				timerNode newTimer = new timerNode(timerNodeX, medX, pathNameX);
				firstTimer.setNextTimer(newTimer); //firstTimer.next = newPath
                newTimer.setPrevTimer(firstTimer);
				M.debug("New Timer Created, registered as second Timer created");
			}

			else
			{
				TS = firstTimer;
				while (TS.getNextTimer() != null)
				{
					//Find last path
					TS = TS.getNextTimer();
				}
				timerNode newPath = new timerNode(timerNodeX, medX, pathNameX);
				TS.setNextTimer(newPath); //lastPath.next = newPath
				newPath.setPrevTimer(TS); //newPath.last = lastPath

				M.debug("Timer created, Unkown TImer possiton, Prev/Next Timer values assigned accordingly");
			}

		}
        #region removeTimer
        public void removeTimer(String timerNameToRemove)
        {
            timerNode toRemove = null;
            if (firstTimer != null) //if FT == null then there are no timers
            {
                TS = firstTimer;

                while (TS.getNextTimer() != null)
                {
                    if (TS.getTimerName().Equals(timerNameToRemove))
                    {
                        toRemove = TS; //finding the first timer with this name and exiting loop
                        break;
                    }
                    TS = TS.getNextTimer(); //incriment loop
                }

                if (toRemove == null)
                {
                    Console.WriteLine("There was no Timers With that Name. Pleaes make sure it was spelled correctly, this is Case sensative"); //No path found with proper nam
                }

                else
                {
                    M.BL();
                    Console.WriteLine("Are you Sure you want to remove Timer " + timerNameToRemove + "?"); //Double checking can't hurt
                    Console.WriteLine("This CANNOT be undone");
                    Console.WriteLine("Y/N");
                    M.BL();
                    ConsoleKeyInfo answer = Console.ReadKey(); //Reading answer
                    M.BL();


                    switch (answer.KeyChar)
                    {

                        case 'y': //making sure this works for either case
                            {
                                Console.WriteLine("Removing timer " + timerNameToRemove + ".");
                                removeTimer(toRemove);
                                break;
                            }

                        case 'Y': //making sure this works for either case
                            {
                                Console.WriteLine("Removing timer " + timerNameToRemove + ".");
                                removeTimer(toRemove);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Cancling remove operation, returning to menu");
                                break;
                            }
                    }
                }
            }

            else
            {
                Console.WriteLine("There are no timers to remove, please add some, so I can remove them");
            }
        }

        public void removeTimer(timerNode remove)
        {

            /*
			 * The getters for pathNodes are not build to not return null, meaning if you try and call a method like
			 * remove.getNext().setNext(null) but remove.getNext() is null it will hard error
			 */
            if (remove == firstTimer) //If the path to remove is the first path, you simple need to re-assign first path.
            {
                if (remove.getNextTimer() == null) //Program will error out w/o these error checks
                {
                    firstTimer = null;
                }

                else
                {
                    firstTimer = remove.getNextTimer();
                    firstTimer.setPrevTimer(null);
                }
            }

            else if (remove == firstTimer.getNextTimer())
            /*
             * This is a simi-redundent case
             * This could be handled with the else statment
             * however I like handling this case seperatly I don't know why
             * Anyt thing I mess with anything to do with firstTimer, I like to call it Directly
             */
            {
                if (remove.getNextTimer() == null)
                {
                    firstTimer.setNextTimer(null);
                    remove.setPrevTimer(null); //This is a redudent clean up that I like to do, it is not necissary
                }

                else
                {
                    firstTimer.setNextTimer(remove.getNextTimer());
                    remove.getNextTimer().setPrevTimer(firstTimer);
                    remove.setNextTimer(null);
                    remove.setPrevTimer(null);
                }
            }

            else
            {
                if (remove.getNextTimer() == null)
                {
                    remove.getPrevTimer().setNextTimer(null);
                    remove.setNextTimer(null);
                }

                else
                {
                    remove.getPrevTimer().setNextTimer(remove.getNextTimer());
                    remove.getNextTimer().setPrevTimer(remove.getPrevTimer());
                    remove.setNextTimer(null);
                    remove.setPrevTimer(null);
                }
            }
        }
        #endregion

        public void editTimer(string timerToEdit)
        {
            timerNode toEdit = null;
            if (firstTimer != null) //if FT == null then there are no paths
            {
                TS = firstTimer;

                while (TS.getNextTimer() != null)
                {
                    if (TS.getTimerName().Equals(timerToEdit))
                    {
                        toEdit = TS; //finding the first path with this name and exiting loop
                        break;
                    }
                    TS = TS.getNextTimer(); //incriment loop
                }

                if(toEdit == null)
                {
                    Console.WriteLine("There was no timers with this name. Please make sure it was spelt correctly, this is case sensative");
                }

                else
                {
					if (toEdit.getRunning() == true)
					{
						Console.WriteLine("You can't edit a running timer");
					}

					else
					{
						Console.WriteLine("What part of the timer would you Like to Edit");
						Console.WriteLine("1) Linked Medication");
						Console.WriteLine("2) Timer Name");
						M.BL();
						ConsoleKeyInfo answer = Console.ReadKey();
						M.BL();
						switch (answer.KeyChar)
						{
							case '1':
								{
									Console.WriteLine("What medication would you like to change to (Enter Name)");
									M.BL();
									medMaster.printMeds();

									string medToChangeTo = Console.ReadLine();
									toEdit.setMed(medMaster.findMed(medToChangeTo));
									break;
								}

							case '2':
								{
									Console.WriteLine("What would you like to change the name to be?");
									M.BL();
									string newName = Console.ReadLine();
									toEdit.setTimerName(newName);
									break;
								}
							default:
								{
									Console.WriteLine("This is not an option");
									break;
								}
						}
					}
                }
            }


        }

		public void startFirstTimer()
		{
			if (firstTimer.getRunning() != true)
			{
				firstTimer.startTimer(true);
				firstTimer.setRunning(true);
			}
			else
			{
				Console.WriteLine("The first timer is alraedy running");
			}
		}

		#region Misc.

		public void printTimers()
		{
			if (firstTimer == null)
			{
				Console.WriteLine("There are no Timers to display");
			}

			else
			{
				TS = firstTimer;

				while (TS != null)
				{
					TS.toString();
					M.BL();
					TS = TS.getNextTimer();
				}
			}
		}
		#endregion

	}
}
