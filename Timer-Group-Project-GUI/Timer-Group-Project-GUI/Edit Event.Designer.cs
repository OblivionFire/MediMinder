namespace Timer_Group_Project_GUI
{
	partial class Edit_Event
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
            this.currentEventsTitle = new System.Windows.Forms.TextBox();
            this.currentEvents = new System.Windows.Forms.RichTextBox();
            this.currentMedsTitle = new System.Windows.Forms.TextBox();
            this.currentTimers = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.searchMed = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.treatTimeOutput = new System.Windows.Forms.TextBox();
            this.medNameOutput = new System.Windows.Forms.TextBox();
            this.treatTimeLeble = new System.Windows.Forms.TextBox();
            this.nameOfMedLable2 = new System.Windows.Forms.TextBox();
            this.nameOfMedInput = new System.Windows.Forms.TextBox();
            this.nameOfMedLable = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMedicationTitle
            // 
            this.addMedicationTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addMedicationTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addMedicationTitle.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.addMedicationTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.addMedicationTitle.Location = new System.Drawing.Point(44, 12);
            this.addMedicationTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMedicationTitle.Name = "addMedicationTitle";
            this.addMedicationTitle.Size = new System.Drawing.Size(1048, 99);
            this.addMedicationTitle.TabIndex = 6;
            this.addMedicationTitle.Text = "Edit Event";
            this.addMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentEventsTitle
            // 
            this.currentEventsTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentEventsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentEventsTitle.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.currentEventsTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.currentEventsTitle.Location = new System.Drawing.Point(689, 128);
            this.currentEventsTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentEventsTitle.Name = "currentEventsTitle";
            this.currentEventsTitle.Size = new System.Drawing.Size(382, 45);
            this.currentEventsTitle.TabIndex = 18;
            this.currentEventsTitle.Text = "Current Events";
            this.currentEventsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentEvents
            // 
            this.currentEvents.Location = new System.Drawing.Point(689, 191);
            this.currentEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentEvents.Name = "currentEvents";
            this.currentEvents.Size = new System.Drawing.Size(384, 232);
            this.currentEvents.TabIndex = 19;
            this.currentEvents.Text = "";
            // 
            // currentMedsTitle
            // 
            this.currentMedsTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentMedsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentMedsTitle.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.currentMedsTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.currentMedsTitle.Location = new System.Drawing.Point(689, 434);
            this.currentMedsTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentMedsTitle.Name = "currentMedsTitle";
            this.currentMedsTitle.Size = new System.Drawing.Size(382, 45);
            this.currentMedsTitle.TabIndex = 16;
            this.currentMedsTitle.Text = "Current Medications";
            this.currentMedsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentTimers
            // 
            this.currentTimers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimers.Location = new System.Drawing.Point(688, 506);
            this.currentTimers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentTimers.Name = "currentTimers";
            this.currentTimers.Size = new System.Drawing.Size(388, 172);
            this.currentTimers.TabIndex = 17;
            this.currentTimers.Text = "";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.clear.Location = new System.Drawing.Point(294, 541);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 35);
            this.clear.TabIndex = 30;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // searchMed
            // 
            this.searchMed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchMed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.searchMed.Location = new System.Drawing.Point(294, 263);
            this.searchMed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchMed.Name = "searchMed";
            this.searchMed.Size = new System.Drawing.Size(112, 35);
            this.searchMed.TabIndex = 21;
            this.searchMed.Text = "Search";
            this.searchMed.UseVisualStyleBackColor = false;
            this.searchMed.Click += new System.EventHandler(this.searchMed_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.saveChanges.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.saveChanges.Location = new System.Drawing.Point(268, 480);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(165, 35);
            this.saveChanges.TabIndex = 25;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // treatTimeOutput
            // 
            this.treatTimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatTimeOutput.Location = new System.Drawing.Point(388, 420);
            this.treatTimeOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treatTimeOutput.Name = "treatTimeOutput";
            this.treatTimeOutput.Size = new System.Drawing.Size(148, 28);
            this.treatTimeOutput.TabIndex = 24;
            this.treatTimeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medNameOutput
            // 
            this.medNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameOutput.Location = new System.Drawing.Point(145, 420);
            this.medNameOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medNameOutput.Name = "medNameOutput";
            this.medNameOutput.Size = new System.Drawing.Size(168, 28);
            this.medNameOutput.TabIndex = 22;
            this.medNameOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treatTimeLeble
            // 
            this.treatTimeLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.treatTimeLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treatTimeLeble.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.treatTimeLeble.ForeColor = System.Drawing.SystemColors.Window;
            this.treatTimeLeble.Location = new System.Drawing.Point(353, 371);
            this.treatTimeLeble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treatTimeLeble.Name = "treatTimeLeble";
            this.treatTimeLeble.Size = new System.Drawing.Size(237, 23);
            this.treatTimeLeble.TabIndex = 29;
            this.treatTimeLeble.Text = "Event Time (ex. 12:00 PM)";
            this.treatTimeLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameOfMedLable2
            // 
            this.nameOfMedLable2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameOfMedLable2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfMedLable2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nameOfMedLable2.ForeColor = System.Drawing.SystemColors.Window;
            this.nameOfMedLable2.Location = new System.Drawing.Point(145, 371);
            this.nameOfMedLable2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameOfMedLable2.Name = "nameOfMedLable2";
            this.nameOfMedLable2.Size = new System.Drawing.Size(166, 23);
            this.nameOfMedLable2.TabIndex = 27;
            this.nameOfMedLable2.Text = "Event";
            this.nameOfMedLable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameOfMedInput
            // 
            this.nameOfMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfMedInput.Location = new System.Drawing.Point(220, 206);
            this.nameOfMedInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameOfMedInput.Name = "nameOfMedInput";
            this.nameOfMedInput.Size = new System.Drawing.Size(262, 33);
            this.nameOfMedInput.TabIndex = 20;
            // 
            // nameOfMedLable
            // 
            this.nameOfMedLable.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameOfMedLable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfMedLable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nameOfMedLable.ForeColor = System.Drawing.SystemColors.Window;
            this.nameOfMedLable.Location = new System.Drawing.Point(216, 164);
            this.nameOfMedLable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameOfMedLable.Name = "nameOfMedLable";
            this.nameOfMedLable.Size = new System.Drawing.Size(269, 30);
            this.nameOfMedLable.TabIndex = 26;
            this.nameOfMedLable.Text = "Name of Event to Edit";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.Location = new System.Drawing.Point(22, 648);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 35);
            this.Exit.TabIndex = 31;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1174, 695);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.searchMed);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.treatTimeOutput);
            this.Controls.Add(this.medNameOutput);
            this.Controls.Add(this.treatTimeLeble);
            this.Controls.Add(this.nameOfMedLable2);
            this.Controls.Add(this.nameOfMedInput);
            this.Controls.Add(this.nameOfMedLable);
            this.Controls.Add(this.currentEventsTitle);
            this.Controls.Add(this.currentEvents);
            this.Controls.Add(this.currentMedsTitle);
            this.Controls.Add(this.currentTimers);
            this.Controls.Add(this.addMedicationTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Edit_Event";
            this.Text = "Edit_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox addMedicationTitle;
        private System.Windows.Forms.TextBox currentEventsTitle;
        private System.Windows.Forms.RichTextBox currentEvents;
        private System.Windows.Forms.TextBox currentMedsTitle;
        private System.Windows.Forms.RichTextBox currentTimers;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button searchMed;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.TextBox treatTimeOutput;
        private System.Windows.Forms.TextBox medNameOutput;
        private System.Windows.Forms.TextBox treatTimeLeble;
        private System.Windows.Forms.TextBox nameOfMedLable2;
        private System.Windows.Forms.TextBox nameOfMedInput;
        private System.Windows.Forms.TextBox nameOfMedLable;
        private System.Windows.Forms.Button Exit;
    }
}