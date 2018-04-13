using Method_Source_Timer_Group_Project;
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
	public partial class Main_Screen : Form
	{
        private medNodeControl meds = medNodeControl.Master();
        private Timer t;

        public Main_Screen()
		{

			InitializeComponent();
            string clock = DateTime.Now.ToString();
           
            currentTimers.Enabled = false;
            currentTimersTitle.Enabled = false;
            medNode[] currentMeds = meds.getMedArray();

          

            foreach (medNode x in currentMeds)
            {
                currentTimers.AppendText(x.toString(1) + "\r\n");
            }

            backgroundWorker1.RunWorkerAsync();
        }
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//This is called when menu path File-> Exit is called
			//It should close the program, I'm not 100% that it will actually work though
			Environment.Exit(1);
		}

		private void addMedicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Add_Medication addMed = new Add_Medication();
			addMed.ShowDialog();
		}

		private void editMedicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Edit_Medication editMed = new Edit_Medication();
			editMed.ShowDialog();
		}

		private void removeMedicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Remove_Medication revMed = new Remove_Medication();
			revMed.ShowDialog();
		}

		private void addMedicationToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Add_Event addEvent = new Add_Event();
			addEvent.ShowDialog();
		}

        private void currentTimers_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void editMedicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Event editEvent = new Edit_Event();
            editEvent.ShowDialog();
        }

        private void currentTimersTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentTimers_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void removeMedicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove_Event removeEvent = new Remove_Event();
            removeEvent.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            eventNodeControler events = eventNodeControler.Master();
            events.manageEvents();


        }
    }
}
