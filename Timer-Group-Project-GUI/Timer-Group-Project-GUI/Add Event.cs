using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Method_Source_Timer_Group_Project;

namespace Timer_Group_Project_GUI
{
	public partial class Add_Event : Form
	{
		private eventNodeControler events = eventNodeControler.Master();
        private medNodeControl meds = medNodeControl.Master();
		public Add_Event()
		{
			InitializeComponent();
            currentEvents.Clear();
			eventNode[] eventList = events.getEventArray();

			foreach (eventNode x in eventList)
			{
				currentEvents.AppendText(x.toString() +"\r\n");
			}

            currentTimers.Clear();
            medNode[] currentMeds = meds.getMedArray();

            foreach (medNode x in currentMeds)
            {
                currentTimers.AppendText(x.toString(1) + "\r\n");
            }

            currentEvents.Enabled = false;
			currentEventsTitle.Enabled = false;
			currentMedsTitle.Enabled = false;
			currentTimers.Enabled = false;
			eventNameLable.Enabled = false;
			eventTimeLable.Enabled = false;
			linkedMedLable.Enabled = false;
			addEventTitle.Enabled = false;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Screen main = new Main_Screen();
			main.ShowDialog();
		}

		private void addEvent_Click(object sender, EventArgs e)
		{
			DateTime temp = new DateTime();
			if((string.IsNullOrWhiteSpace(eventNameInput.Text) == false) && (string.IsNullOrWhiteSpace(linkedMedInput.Text) == false) && (DateTime.TryParse(eventTimeInput.Text, out temp)))
			{
				medNode tempMed = meds.findMed(linkedMedInput.Text);
				if (tempMed == null)
				{
					MessageBox.Show("That medication Does not Exist");
				}

				else if (DateTime.Compare(temp, DateTime.Now) < 0)
				{
					MessageBox.Show("That date has already past");
				}

				else
				{
					events.addEvent(eventNameInput.Text, temp, tempMed);
					MessageBox.Show("Event Added");
				}
			}

			else if((string.IsNullOrWhiteSpace(eventNameInput.Text) == false) && (DateTime.TryParse(eventTimeInput.Text, out temp)))
			{
				if (DateTime.Compare(temp, DateTime.Now) < 0)
				{
					MessageBox.Show("That date has already past");
				}
				else
				{
					events.addEvent(eventNameInput.Text, temp);
					MessageBox.Show("Event Added");
				}
			}
		}

		private void Add_Event_Load(object sender, EventArgs e)
		{

		}
	}
}
