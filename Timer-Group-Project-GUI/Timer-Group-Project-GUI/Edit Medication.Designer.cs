namespace Timer_Group_Project_GUI
{
	partial class Edit_Medication
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
            this.Exit = new System.Windows.Forms.Button();
            this.currentTimersTitle = new System.Windows.Forms.TextBox();
            this.currentTimers = new System.Windows.Forms.RichTextBox();
            this.editMedicationTitle = new System.Windows.Forms.TextBox();
            this.nameOfMedLable = new System.Windows.Forms.TextBox();
            this.nameOfMedInput = new System.Windows.Forms.TextBox();
            this.nameOfMedLable2 = new System.Windows.Forms.TextBox();
            this.doesOfMedLeble = new System.Windows.Forms.TextBox();
            this.treatTimeLeble = new System.Windows.Forms.TextBox();
            this.medNameOutput = new System.Windows.Forms.TextBox();
            this.medDoesOutput = new System.Windows.Forms.TextBox();
            this.treatTimeOutput = new System.Windows.Forms.TextBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.searchMed = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.Location = new System.Drawing.Point(24, 804);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 44);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // currentTimersTitle
            // 
            this.currentTimersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimersTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimersTitle.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.currentTimersTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimersTitle.Location = new System.Drawing.Point(880, 145);
            this.currentTimersTitle.Margin = new System.Windows.Forms.Padding(6);
            this.currentTimersTitle.Name = "currentTimersTitle";
            this.currentTimersTitle.Size = new System.Drawing.Size(626, 73);
            this.currentTimersTitle.TabIndex = 8;
            this.currentTimersTitle.Text = "Current Medication";
            this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentTimers
            // 
            this.currentTimers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentTimers.Location = new System.Drawing.Point(880, 224);
            this.currentTimers.Margin = new System.Windows.Forms.Padding(6);
            this.currentTimers.Name = "currentTimers";
            this.currentTimers.Size = new System.Drawing.Size(626, 613);
            this.currentTimers.TabIndex = 13;
            this.currentTimers.Text = "";
            this.currentTimers.TextChanged += new System.EventHandler(this.currentTimers_TextChanged);
            // 
            // editMedicationTitle
            // 
            this.editMedicationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMedicationTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.editMedicationTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editMedicationTitle.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.editMedicationTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.editMedicationTitle.Location = new System.Drawing.Point(15, 15);
            this.editMedicationTitle.Margin = new System.Windows.Forms.Padding(6);
            this.editMedicationTitle.Name = "editMedicationTitle";
            this.editMedicationTitle.Size = new System.Drawing.Size(1468, 131);
            this.editMedicationTitle.TabIndex = 7;
            this.editMedicationTitle.Text = "Edit Medication";
            this.editMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameOfMedLable
            // 
            this.nameOfMedLable.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameOfMedLable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfMedLable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nameOfMedLable.ForeColor = System.Drawing.SystemColors.Window;
            this.nameOfMedLable.Location = new System.Drawing.Point(224, 192);
            this.nameOfMedLable.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfMedLable.Name = "nameOfMedLable";
            this.nameOfMedLable.Size = new System.Drawing.Size(448, 40);
            this.nameOfMedLable.TabIndex = 9;
            this.nameOfMedLable.Text = "Name of Medication to Edit";
            this.nameOfMedLable.TextChanged += new System.EventHandler(this.nameOfMedLable_TextChanged);
            // 
            // nameOfMedInput
            // 
            this.nameOfMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfMedInput.Location = new System.Drawing.Point(267, 244);
            this.nameOfMedInput.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfMedInput.Name = "nameOfMedInput";
            this.nameOfMedInput.Size = new System.Drawing.Size(348, 41);
            this.nameOfMedInput.TabIndex = 0;
            this.nameOfMedInput.TextChanged += new System.EventHandler(this.nameOfMedInput_TextChanged);
            // 
            // nameOfMedLable2
            // 
            this.nameOfMedLable2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameOfMedLable2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfMedLable2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nameOfMedLable2.ForeColor = System.Drawing.SystemColors.Window;
            this.nameOfMedLable2.Location = new System.Drawing.Point(50, 457);
            this.nameOfMedLable2.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfMedLable2.Name = "nameOfMedLable2";
            this.nameOfMedLable2.Size = new System.Drawing.Size(222, 30);
            this.nameOfMedLable2.TabIndex = 10;
            this.nameOfMedLable2.Text = "Medication Name";
            this.nameOfMedLable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doesOfMedLeble
            // 
            this.doesOfMedLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.doesOfMedLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doesOfMedLeble.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.doesOfMedLeble.ForeColor = System.Drawing.SystemColors.Window;
            this.doesOfMedLeble.Location = new System.Drawing.Point(323, 457);
            this.doesOfMedLeble.Margin = new System.Windows.Forms.Padding(6);
            this.doesOfMedLeble.Name = "doesOfMedLeble";
            this.doesOfMedLeble.Size = new System.Drawing.Size(216, 30);
            this.doesOfMedLeble.TabIndex = 11;
            this.doesOfMedLeble.Text = "Medication Dose";
            this.doesOfMedLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doesOfMedLeble.TextChanged += new System.EventHandler(this.doesOfMedLeble_TextChanged);
            // 
            // treatTimeLeble
            // 
            this.treatTimeLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.treatTimeLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treatTimeLeble.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.treatTimeLeble.ForeColor = System.Drawing.SystemColors.Window;
            this.treatTimeLeble.Location = new System.Drawing.Point(580, 457);
            this.treatTimeLeble.Margin = new System.Windows.Forms.Padding(6);
            this.treatTimeLeble.Name = "treatTimeLeble";
            this.treatTimeLeble.Size = new System.Drawing.Size(196, 30);
            this.treatTimeLeble.TabIndex = 12;
            this.treatTimeLeble.Text = "Treatment Time";
            this.treatTimeLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medNameOutput
            // 
            this.medNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameOutput.Location = new System.Drawing.Point(50, 518);
            this.medNameOutput.Margin = new System.Windows.Forms.Padding(6);
            this.medNameOutput.Name = "medNameOutput";
            this.medNameOutput.Size = new System.Drawing.Size(222, 35);
            this.medNameOutput.TabIndex = 2;
            this.medNameOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medDoesOutput
            // 
            this.medDoesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDoesOutput.Location = new System.Drawing.Point(323, 518);
            this.medDoesOutput.Margin = new System.Windows.Forms.Padding(6);
            this.medDoesOutput.Name = "medDoesOutput";
            this.medDoesOutput.Size = new System.Drawing.Size(216, 35);
            this.medDoesOutput.TabIndex = 3;
            this.medDoesOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treatTimeOutput
            // 
            this.treatTimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatTimeOutput.Location = new System.Drawing.Point(580, 518);
            this.treatTimeOutput.Margin = new System.Windows.Forms.Padding(6);
            this.treatTimeOutput.Name = "treatTimeOutput";
            this.treatTimeOutput.Size = new System.Drawing.Size(196, 35);
            this.treatTimeOutput.TabIndex = 4;
            this.treatTimeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.saveChanges.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.saveChanges.Location = new System.Drawing.Point(321, 593);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(6);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(220, 44);
            this.saveChanges.TabIndex = 5;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchMed
            // 
            this.searchMed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchMed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.searchMed.Location = new System.Drawing.Point(366, 316);
            this.searchMed.Margin = new System.Windows.Forms.Padding(6);
            this.searchMed.Name = "searchMed";
            this.searchMed.Size = new System.Drawing.Size(150, 44);
            this.searchMed.TabIndex = 1;
            this.searchMed.Text = "Search";
            this.searchMed.UseVisualStyleBackColor = false;
            this.searchMed.Click += new System.EventHandler(this.searchMed_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.clear.Location = new System.Drawing.Point(356, 669);
            this.clear.Margin = new System.Windows.Forms.Padding(6);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(150, 44);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Edit_Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1548, 871);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.searchMed);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.treatTimeOutput);
            this.Controls.Add(this.medDoesOutput);
            this.Controls.Add(this.medNameOutput);
            this.Controls.Add(this.treatTimeLeble);
            this.Controls.Add(this.doesOfMedLeble);
            this.Controls.Add(this.nameOfMedLable2);
            this.Controls.Add(this.nameOfMedInput);
            this.Controls.Add(this.nameOfMedLable);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.currentTimersTitle);
            this.Controls.Add(this.currentTimers);
            this.Controls.Add(this.editMedicationTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Edit_Medication";
            this.Text = "Edit_Medication";
            this.Load += new System.EventHandler(this.Edit_Medication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox currentTimersTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox editMedicationTitle;
		private System.Windows.Forms.TextBox nameOfMedLable;
		private System.Windows.Forms.TextBox nameOfMedInput;
		private System.Windows.Forms.TextBox nameOfMedLable2;
		private System.Windows.Forms.TextBox doesOfMedLeble;
		private System.Windows.Forms.TextBox treatTimeLeble;
		private System.Windows.Forms.TextBox medNameOutput;
		private System.Windows.Forms.TextBox medDoesOutput;
		private System.Windows.Forms.TextBox treatTimeOutput;
		private System.Windows.Forms.Button saveChanges;
		private System.Windows.Forms.Button searchMed;
		private System.Windows.Forms.Button clear;
	}
}