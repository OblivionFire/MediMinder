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

	public partial class Remove_Medication : Form
	{
		private medNodeControl meds = medNodeControl.Master();
		public Remove_Medication()
		{
			InitializeComponent();
			currentTimers.Clear();

			medNode[] currentMeds = meds.getMedArray();

			foreach (medNode x in currentMeds)
			{
				currentTimers.AppendText(x.toString(1) + "\r\n");
			}

			removeMedicationTitle.Enabled = false;
			currentTimers.Enabled = false;
			currentTimersTitle.Enabled = false;
			nameOfMedLable.Enabled = false;
			nameOfMedLable2.Enabled = false;
			doesOfMedLeble.Enabled = false;
			treatTimeLeble.Enabled = false;
			medNameOutput.Enabled = false;
			medDoesOutput.Enabled = false;
			treatTimeOutput.Enabled = false;
		}

		private void Exit_Click(object sender, EventArgs e)
		{ 
			this.Hide();
			Main_Screen main = new Main_Screen();
			main.ShowDialog();
		}

		private void searchMed_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameOfMedInput.Text) == false)
			{
				medNode temp = meds.findMed(nameOfMedInput.Text);

				if (temp == null)
				{
					MessageBox.Show("That Med Does not Exists");
				}

				else
				{
					medNameOutput.AppendText(temp.getName());
					medDoesOutput.AppendText(temp.getDoes());
					treatTimeOutput.AppendText(temp.getTime().TotalMinutes.ToString());
					nameOfMedInput.Enabled = false;
					searchMed.Enabled = false;
				}
			}

			else
			{
				MessageBox.Show("Please input a Medication name");
			}
		}

		private void remove_Click(object sender, EventArgs e)
		{
			medNode temp = meds.findMed(nameOfMedInput.Text);
			temp.remove();
			medNameOutput.Clear();
			medDoesOutput.Clear();
			treatTimeOutput.Clear();
			nameOfMedInput.Clear();
			nameOfMedInput.Enabled = true;
			searchMed.Enabled = true;

            currentTimers.Clear();

            medNode[] currentMeds = meds.getMedArray();

            foreach (medNode x in currentMeds)
            {
                currentTimers.AppendText(x.toString(1) + "\r\n");
            }
        }

		private void clear_Click(object sender, EventArgs e)
		{
			nameOfMedInput.Clear();
			nameOfMedInput.Enabled = true;
			medNameOutput.Clear();
			medDoesOutput.Clear();
			treatTimeOutput.Clear();
			searchMed.Enabled = true;
		}

        private void doesOfMedLeble_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
