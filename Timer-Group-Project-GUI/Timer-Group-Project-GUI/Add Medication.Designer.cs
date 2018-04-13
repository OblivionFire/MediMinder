namespace Timer_Group_Project_GUI
{
	partial class Add_Medication
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
            this.addMedicationTitle = new System.Windows.Forms.TextBox();
            this.currentTimers = new System.Windows.Forms.RichTextBox();
            this.currentTimersTitle = new System.Windows.Forms.TextBox();
            this.medicationNameLeble = new System.Windows.Forms.TextBox();
            this.medicationDoesLeble = new System.Windows.Forms.TextBox();
            this.treatmentTimeLeble = new System.Windows.Forms.TextBox();
            this.treatTimeInput = new System.Windows.Forms.TextBox();
            this.medDoesInput = new System.Windows.Forms.TextBox();
            this.medNameInput = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.addMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMedicationTitle
            // 
            this.addMedicationTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addMedicationTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addMedicationTitle.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.addMedicationTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.addMedicationTitle.Location = new System.Drawing.Point(24, 22);
            this.addMedicationTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addMedicationTitle.Name = "addMedicationTitle";
            this.addMedicationTitle.Size = new System.Drawing.Size(1398, 131);
            this.addMedicationTitle.TabIndex = 5;
            this.addMedicationTitle.Text = "Add Medication";
            this.addMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addMedicationTitle.TextChanged += new System.EventHandler(this.addMedicationTitle_TextChanged);
            // 
            // currentTimers
            // 
            this.currentTimers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentTimers.Location = new System.Drawing.Point(912, 222);
            this.currentTimers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentTimers.Name = "currentTimers";
            this.currentTimers.Size = new System.Drawing.Size(510, 530);
            this.currentTimers.TabIndex = 10;
            this.currentTimers.Text = "";
            // 
            // currentTimersTitle
            // 
            this.currentTimersTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimersTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentTimersTitle.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.currentTimersTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimersTitle.Location = new System.Drawing.Point(912, 165);
            this.currentTimersTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentTimersTitle.Name = "currentTimersTitle";
            this.currentTimersTitle.Size = new System.Drawing.Size(510, 50);
            this.currentTimersTitle.TabIndex = 6;
            this.currentTimersTitle.Text = "Current Medications";
            this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medicationNameLeble
            // 
            this.medicationNameLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.medicationNameLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.medicationNameLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicationNameLeble.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.medicationNameLeble.ForeColor = System.Drawing.SystemColors.Window;
            this.medicationNameLeble.Location = new System.Drawing.Point(124, 222);
            this.medicationNameLeble.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.medicationNameLeble.Name = "medicationNameLeble";
            this.medicationNameLeble.Size = new System.Drawing.Size(314, 36);
            this.medicationNameLeble.TabIndex = 7;
            this.medicationNameLeble.Text = "Medication Name";
            // 
            // medicationDoesLeble
            // 
            this.medicationDoesLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.medicationDoesLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.medicationDoesLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicationDoesLeble.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.medicationDoesLeble.ForeColor = System.Drawing.SystemColors.Window;
            this.medicationDoesLeble.Location = new System.Drawing.Point(124, 302);
            this.medicationDoesLeble.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.medicationDoesLeble.Name = "medicationDoesLeble";
            this.medicationDoesLeble.Size = new System.Drawing.Size(314, 36);
            this.medicationDoesLeble.TabIndex = 8;
            this.medicationDoesLeble.Text = "Medication Dose";
            // 
            // treatmentTimeLeble
            // 
            this.treatmentTimeLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treatmentTimeLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.treatmentTimeLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treatmentTimeLeble.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.treatmentTimeLeble.ForeColor = System.Drawing.SystemColors.Window;
            this.treatmentTimeLeble.Location = new System.Drawing.Point(124, 386);
            this.treatmentTimeLeble.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treatmentTimeLeble.Name = "treatmentTimeLeble";
            this.treatmentTimeLeble.Size = new System.Drawing.Size(314, 36);
            this.treatmentTimeLeble.TabIndex = 9;
            this.treatmentTimeLeble.Text = "Treatment Time(Min.) ";
            this.treatmentTimeLeble.TextChanged += new System.EventHandler(this.treatmentTimeLeble_TextChanged);
            // 
            // treatTimeInput
            // 
            this.treatTimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treatTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatTimeInput.Location = new System.Drawing.Point(482, 386);
            this.treatTimeInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treatTimeInput.Name = "treatTimeInput";
            this.treatTimeInput.Size = new System.Drawing.Size(272, 44);
            this.treatTimeInput.TabIndex = 2;
            // 
            // medDoesInput
            // 
            this.medDoesInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.medDoesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDoesInput.Location = new System.Drawing.Point(482, 302);
            this.medDoesInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.medDoesInput.Name = "medDoesInput";
            this.medDoesInput.Size = new System.Drawing.Size(272, 44);
            this.medDoesInput.TabIndex = 1;
            // 
            // medNameInput
            // 
            this.medNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.medNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameInput.Location = new System.Drawing.Point(482, 222);
            this.medNameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.medNameInput.Name = "medNameInput";
            this.medNameInput.Size = new System.Drawing.Size(272, 44);
            this.medNameInput.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.Location = new System.Drawing.Point(24, 712);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // addMed
            // 
            this.addMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addMed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addMed.Font = new System.Drawing.Font("Segoe UI Emoji", 10.125F);
            this.addMed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addMed.Location = new System.Drawing.Point(356, 466);
            this.addMed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addMed.Name = "addMed";
            this.addMed.Size = new System.Drawing.Size(254, 70);
            this.addMed.TabIndex = 3;
            this.addMed.Text = "Add Medication";
            this.addMed.UseVisualStyleBackColor = false;
            this.addMed.Click += new System.EventHandler(this.addMed_Click);
            // 
            // Add_Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1450, 778);
            this.Controls.Add(this.addMed);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.medNameInput);
            this.Controls.Add(this.medDoesInput);
            this.Controls.Add(this.treatTimeInput);
            this.Controls.Add(this.treatmentTimeLeble);
            this.Controls.Add(this.medicationDoesLeble);
            this.Controls.Add(this.medicationNameLeble);
            this.Controls.Add(this.currentTimersTitle);
            this.Controls.Add(this.currentTimers);
            this.Controls.Add(this.addMedicationTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Add_Medication";
            this.Text = "Add_Medication";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox addMedicationTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox currentTimersTitle;
		private System.Windows.Forms.TextBox medicationNameLeble;
		private System.Windows.Forms.TextBox medicationDoesLeble;
		private System.Windows.Forms.TextBox treatmentTimeLeble;
		private System.Windows.Forms.TextBox treatTimeInput;
		private System.Windows.Forms.TextBox medDoesInput;
		private System.Windows.Forms.TextBox medNameInput;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button addMed;
	}
}