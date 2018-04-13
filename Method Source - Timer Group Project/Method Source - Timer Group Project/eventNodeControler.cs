using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Method_Source_Timer_Group_Project
{
	public class eventNodeControler
	{
		public static eventNodeControler master;
		private eventNode firstEvent;
		private eventNode ES;

		public eventNodeControler()
		{
			firstEvent = null;
			ES = null;
		}

		public static eventNodeControler Master()
		{
			if(master == null)
			{
				master = new eventNodeControler();
			}

			return master;
		}

		public void addEvent(String eventNameX, DateTime endTimeX)
		{
			/*
			 * Three Conditions
			 * First Event == null - No Events - firstEvent = New Path
			 * First Event.getNext() == null - One Event - firstEvent.getNext().setNext(New Event)
			 * First Event.getNext() != null - > Two Events - find last and assign
			 */

			if (firstEvent == null)
			{
				eventNode newEvent = new eventNode(eventNameX, endTimeX);
				firstEvent = newEvent;
				M.debug("New Event Created, assigned to firstEvent");
			}

			else if (firstEvent.getNextEvent() == null)
			{
				eventNode newEvent = new eventNode(eventNameX, endTimeX);
				firstEvent.setNextEvent(newEvent); //firstEvent.next = newPath
				newEvent.setPrevEvent(firstEvent);
				M.debug("New Event Created, registered as second Event created");
			}

			else
			{
				ES = firstEvent;
				while (ES.getNextEvent() != null)
				{
					//Find last path
					ES = ES.getNextEvent();
				}
				eventNode newPath = new eventNode(eventNameX, endTimeX);
				ES.setNextEvent(newPath); //lastPath.next = newPath
				newPath.setPrevEvent(ES); //newPath.last = lastPath

				M.debug("Event created, Unkown Event possiton, Prev/Next Event values assigned accordingly");
			}
		}

        public void addEvent(String eventNameX, DateTime endTimeX, medNode linkedMedX)
        {
            /*
			 * Three Conditions
			 * First Event == null - No Events - firstEvent = New Path
			 * First Event.getNext() == null - One Event - firstEvent.getNext().setNext(New Event)
			 * First Event.getNext() != null - > Two Events - find last and assign
			 */

            if (firstEvent == null)
            {
                eventNode newEvent = new eventNode(eventNameX, endTimeX, linkedMedX);
                firstEvent = newEvent;
                M.debug("New Event Created, assigned to firstEvent");
            }

            else if (firstEvent.getNextEvent() == null)
            {
                eventNode newEvent = new eventNode(eventNameX, endTimeX, linkedMedX);
                firstEvent.setNextEvent(newEvent); //firstEvent.next = newPath
                newEvent.setPrevEvent(firstEvent);
                M.debug("New Event Created, registered as second Event created");
            }

            else
            {
                ES = firstEvent;
                while (ES.getNextEvent() != null)
                {
                    //Find last path
                    ES = ES.getNextEvent();
                }
                eventNode newPath = new eventNode(eventNameX, endTimeX, linkedMedX);
                ES.setNextEvent(newPath); //lastPath.next = newPath
                newPath.setPrevEvent(ES); //newPath.last = lastPath

                M.debug("Event created, Unkown Event possiton, Prev/Next Event values assigned accordingly");
            }
        }

        public eventNode[] getEventArray()
		{
			int eventCount = 1;
			if(firstEvent == null)
			{
				eventNode[] temp = new eventNode[0];
				return temp;
			}

			else
			{
				ES = firstEvent;

				while(ES.getNextEvent() != null)
				{
					eventCount++;
					ES = ES.getNextEvent();
				}

				eventNode[] events = new eventNode[eventCount];
				ES = firstEvent;

				for(int i = 0; i<eventCount; i++)
				{
					events[i] = ES;
					ES = ES.getNextEvent();
				}

				return events;

			}
		}

		public void manageEvents()
		{
			while(true)
			{
				if(firstEvent == null)
				{
					Thread.Sleep(1000);
				}

				else
				{ 
					ES = firstEvent;

					while(ES != null)
					{
						int finished = DateTime.Compare(ES.getEndTime(), DateTime.Now);
						if(finished > 0 && ES.getReminder() == false)
						{
							if (ES.getLinkedMed() == null)
							{
								MessageBox.Show("Event: " + ES.getName() + " Has finished");
                                ES.setReminder(true);
								removeEvent(ES);
							}

							else
							{
								MessageBox.Show("Event: " + ES.getName() + " Has finished. Linked Medication: " + ES.getLinkedMed().toString(false));
                                ES.setReminder(true);
								removeEvent(ES);
							}
						}

						ES = ES.getNextEvent();
					}
				}


			}
		}


		public void removeEvent(eventNode remove)
		{

			/*
			 * The getters for pathNodes are not build to not return null, meaning if you try and call a method like
			 * remove.getNext().setNext(null) but remove.getNext() is null it will hard error
			 */
			if (remove == firstEvent) //If the path to remove is the first path, you simple need to re-assign first path.
			{
				if (remove.getNextEvent() == null) //Program will error out w/o these error checks
				{
					firstEvent = null;
				}

				else
				{
					firstEvent = remove.getNextEvent();
					firstEvent.setPrevEvent(null);
				}
			}

			else if (remove == firstEvent.getNextEvent())
			/*
             * This is a simi-redundent case
             * This could be handled with the else statment
             * however I like handling this case seperatly I don't know why
             * Anyt thing I mess with anything to do with firstEvent, I like to call it Directly
             */
			{
				if (remove.getNextEvent() == null)
				{
					firstEvent.setNextEvent(null);
					remove.setPrevEvent(null); //This is a redudent clean up that I like to do, it is not necissary
				}

				else
				{
					firstEvent.setNextEvent(remove.getNextEvent());
					remove.getNextEvent().setPrevEvent(firstEvent);
					remove.setNextEvent(null);
					remove.setPrevEvent(null);
				}
			}

			else
			{
				if (remove.getNextEvent() == null)
				{
					remove.getPrevEvent().setNextEvent(null);
					remove.setNextEvent(null);
				}

				else
				{
					remove.getPrevEvent().setNextEvent(remove.getNextEvent());
					remove.getNextEvent().setPrevEvent(remove.getPrevEvent());
					remove.setNextEvent(null);
					remove.setPrevEvent(null);
				}
			}
		}

	}
}
