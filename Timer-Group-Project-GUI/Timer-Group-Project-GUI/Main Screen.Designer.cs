namespace Timer_Group_Project_GUI
{
	partial class Main_Screen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMedicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMedicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMedicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMedicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTimersTitle = new System.Windows.Forms.TextBox();
            this.currentTimers = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.medicationToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1213, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // medicationToolStripMenuItem
            // 
            this.medicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMedicationToolStripMenuItem,
            this.editMedicationToolStripMenuItem,
            this.removeMedicationToolStripMenuItem});
            this.medicationToolStripMenuItem.Name = "medicationToolStripMenuItem";
            this.medicationToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.medicationToolStripMenuItem.Text = "Medication";
            // 
            // addMedicationToolStripMenuItem
            // 
            this.addMedicationToolStripMenuItem.Name = "addMedicationToolStripMenuItem";
            this.addMedicationToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.addMedicationToolStripMenuItem.Text = "Add Medication";
            this.addMedicationToolStripMenuItem.Click += new System.EventHandler(this.addMedicationToolStripMenuItem_Click);
            // 
            // editMedicationToolStripMenuItem
            // 
            this.editMedicationToolStripMenuItem.Name = "editMedicationToolStripMenuItem";
            this.editMedicationToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.editMedicationToolStripMenuItem.Text = "Edit Medication";
            this.editMedicationToolStripMenuItem.Click += new System.EventHandler(this.editMedicationToolStripMenuItem_Click);
            // 
            // removeMedicationToolStripMenuItem
            // 
            this.removeMedicationToolStripMenuItem.Name = "removeMedicationToolStripMenuItem";
            this.removeMedicationToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.removeMedicationToolStripMenuItem.Text = "Remove Medication";
            this.removeMedicationToolStripMenuItem.Click += new System.EventHandler(this.removeMedicationToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMedicationToolStripMenuItem1,
            this.editMedicationToolStripMenuItem1,
            this.removeMedicationToolStripMenuItem1});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // addMedicationToolStripMenuItem1
            // 
            this.addMedicationToolStripMenuItem1.Name = "addMedicationToolStripMenuItem1";
            this.addMedicationToolStripMenuItem1.Size = new System.Drawing.Size(210, 30);
            this.addMedicationToolStripMenuItem1.Text = "Add Event";
            this.addMedicationToolStripMenuItem1.Click += new System.EventHandler(this.addMedicationToolStripMenuItem1_Click);
            // 
            // editMedicationToolStripMenuItem1
            // 
            this.editMedicationToolStripMenuItem1.Name = "editMedicationToolStripMenuItem1";
            this.editMedicationToolStripMenuItem1.Size = new System.Drawing.Size(210, 30);
            this.editMedicationToolStripMenuItem1.Text = "Edit Event";
            this.editMedicationToolStripMenuItem1.Click += new System.EventHandler(this.editMedicationToolStripMenuItem1_Click);
            // 
            // removeMedicationToolStripMenuItem1
            // 
            this.removeMedicationToolStripMenuItem1.Name = "removeMedicationToolStripMenuItem1";
            this.removeMedicationToolStripMenuItem1.Size = new System.Drawing.Size(210, 30);
            this.removeMedicationToolStripMenuItem1.Text = "Remove Event";
            this.removeMedicationToolStripMenuItem1.Click += new System.EventHandler(this.removeMedicationToolStripMenuItem1_Click);
            // 
            // currentTimersTitle
            // 
            this.currentTimersTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimersTitle.Enabled = false;
            this.currentTimersTitle.Font = new System.Drawing.Font("Modern No. 20", 22F);
            this.currentTimersTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimersTitle.Location = new System.Drawing.Point(39, 450);
            this.currentTimersTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentTimersTitle.Name = "currentTimersTitle";
            this.currentTimersTitle.Size = new System.Drawing.Size(1047, 55);
            this.currentTimersTitle.TabIndex = 14;
            this.currentTimersTitle.Text = "Current Timers";
            this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentTimersTitle.TextChanged += new System.EventHandler(this.currentTimersTitle_TextChanged);
            // 
            // currentTimers
            // 
            this.currentTimers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentTimers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.currentTimers.Location = new System.Drawing.Point(39, 541);
            this.currentTimers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentTimers.Name = "currentTimers";
            this.currentTimers.Size = new System.Drawing.Size(1053, 226);
            this.currentTimers.TabIndex = 15;
            this.currentTimers.Text = "";
            this.currentTimers.TextChanged += new System.EventHandler(this.currentTimers_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(313, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = "Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 78F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1126, 186);
            this.label2.TabIndex = 17;
            this.label2.Text = "Medi - Minder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1213, 826);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentTimersTitle);
            this.Controls.Add(this.currentTimers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Screen";
            this.Text = "Main_Screen";
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem medicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addMedicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMedicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeMedicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addMedicationToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editMedicationToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem removeMedicationToolStripMenuItem1;
        private System.Windows.Forms.TextBox currentTimersTitle;
        private System.Windows.Forms.RichTextBox currentTimers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}