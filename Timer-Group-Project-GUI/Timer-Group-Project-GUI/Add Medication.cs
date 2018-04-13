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
	public partial class Add_Medication : Form
	{
		private medNodeControl meds = medNodeControl.Master();
		public Add_Medication()
		{
			InitializeComponent();
			currentTimers.Clear();

			medNode[] currentMeds = meds.getMedArray();

			foreach (medNode x in currentMeds)
			{
				currentTimers.AppendText(x.toString(1) + "\r\n");
			}

			currentTimers.Enabled = false;
			currentTimersTitle.Enabled = false;
			medicationNameLeble.Enabled = false;
			medicationDoesLeble.Enabled = false;
			treatmentTimeLeble.Enabled = false;
			addMedicationTitle.Enabled = false;

		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Screen main = new Main_Screen();
			main.ShowDialog();
		}

		private void treatmentTimeLeble_TextChanged(object sender, EventArgs e)
		{

		}

		private void addMed_Click(object sender, EventArgs e)
		{
			int treatTimeMin;

			if ((string.IsNullOrWhiteSpace(medNameInput.Text) == false) && (string.IsNullOrWhiteSpace(medDoesInput.Text) == false) && (Int32.TryParse(treatTimeInput.Text, out treatTimeMin)))
			{

				Int32.TryParse(treatTimeInput.Text, out treatTimeMin);

				TimeSpan temp = new TimeSpan(0, treatTimeMin, 0);
				meds.addMed(medNameInput.Text, medDoesInput.Text, temp);
				MessageBox.Show("Medication Added");

                currentTimers.Clear();

                medNode[] currentMeds = meds.getMedArray();

                foreach (medNode x in currentMeds)
                {
                    currentTimers.AppendText(x.toString(1) + "\r\n");
                }
            }

			else
			{
				MessageBox.Show("Please enter all information in a valid format before trying to enter medication");
			}

			medNameInput.Clear();
			medDoesInput.Clear();
			treatTimeInput.Clear();
		}

		private void addMedicationTitle_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
