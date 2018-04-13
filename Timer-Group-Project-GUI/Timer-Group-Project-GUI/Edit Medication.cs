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
	public partial class Edit_Medication : Form
	{
		private medNodeControl meds = medNodeControl.Master();

		public Edit_Medication()
		{
			InitializeComponent();
			currentTimers.Clear();

			medNode[] currentMeds = meds.getMedArray();

			foreach (medNode x in currentMeds)
			{
				currentTimers.AppendText(x.toString(1) + "\r\n");
			}

			nameOfMedLable.Enabled = false;
			nameOfMedLable2.Enabled = false;
			doesOfMedLeble.Enabled = false;
			treatTimeLeble.Enabled = false;
			currentTimers.Enabled = false;
			editMedicationTitle.Enabled = false;
			currentTimersTitle.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int treatTimeMin;
			if ((string.IsNullOrWhiteSpace(medNameOutput.Text) == false) && (string.IsNullOrWhiteSpace(medDoesOutput.Text) == false) && (Int32.TryParse(treatTimeOutput.Text, out treatTimeMin)))
			{
				medNode temp = meds.findMed(nameOfMedInput.Text);

				temp.setName(medNameOutput.Text);
				temp.setDoes(medDoesOutput.Text);
				TimeSpan tempTime = new TimeSpan(0, treatTimeMin, 0);
				temp.setTime(tempTime);

				nameOfMedInput.Clear();
				medNameOutput.Clear();
				medDoesOutput.Clear();
				treatTimeOutput.Clear();
				nameOfMedInput.Enabled = true;
				searchMed.Enabled = true;

                currentTimers.Clear();

                medNode[] currentMeds = meds.getMedArray();

                foreach (medNode x in currentMeds)
                {
                    currentTimers.AppendText(x.toString(1) + "\r\n");
                }
            }
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Screen main = new Main_Screen();
			main.ShowDialog();
		}

		private void currentTimers_TextChanged(object sender, EventArgs e)
		{

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

		private void clear_Click(object sender, EventArgs e)
		{
			medNameOutput.Clear();
			medDoesOutput.Clear();
			treatTimeOutput.Clear();
			nameOfMedInput.Clear();
			nameOfMedInput.Enabled = true;
			searchMed.Enabled = true;
		}

		private void nameOfMedInput_TextChanged(object sender, EventArgs e)
		{

		}

		private void Edit_Medication_Load(object sender, EventArgs e)
		{

		}

		private void nameOfMedLable_TextChanged(object sender, EventArgs e)
		{

		}

        private void doesOfMedLeble_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
