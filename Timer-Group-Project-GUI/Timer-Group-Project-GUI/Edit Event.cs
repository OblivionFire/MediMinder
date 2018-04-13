using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Group_Project_GUI
{
	public partial class Edit_Event : Form
	{
		public Edit_Event()
		{
			InitializeComponent();
		}

        private void searchMed_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen main = new Main_Screen();
            main.ShowDialog();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}
