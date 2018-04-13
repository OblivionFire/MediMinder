namespace Timer_Group_Project_GUI
{
	partial class Remove_Medication
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
            this.currentTimersTitle = new System.Windows.Forms.TextBox();
            this.currentTimers = new System.Windows.Forms.RichTextBox();
            this.removeMedicationTitle = new System.Windows.Forms.TextBox();
            this.searchMed = new System.Windows.Forms.Button();
            this.nameOfMedInput = new System.Windows.Forms.TextBox();
            this.nameOfMedLable = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.treatTimeOutput = new System.Windows.Forms.TextBox();
            this.medDoesOutput = new System.Windows.Forms.TextBox();
            this.medNameOutput = new System.Windows.Forms.TextBox();
            this.treatTimeLeble = new System.Windows.Forms.TextBox();
            this.doesOfMedLeble = new System.Windows.Forms.TextBox();
            this.nameOfMedLable2 = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTimersTitle
            // 
            this.currentTimersTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimersTitle.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.currentTimersTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimersTitle.Location = new System.Drawing.Point(912, 152);
            this.currentTimersTitle.Margin = new System.Windows.Forms.Padding(6);
            this.currentTimersTitle.Name = "currentTimersTitle";
            this.currentTimersTitle.Size = new System.Drawing.Size(510, 66);
            this.currentTimersTitle.TabIndex = 12;
            this.currentTimersTitle.Text = "Current Timers";
            this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentTimers
            // 
            this.currentTimers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentTimers.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimers.Location = new System.Drawing.Point(912, 231);
            this.currentTimers.Margin = new System.Windows.Forms.Padding(6);
            this.currentTimers.Name = "currentTimers";
            this.currentTimers.Size = new System.Drawing.Size(510, 552);
            this.currentTimers.TabIndex = 13;
            this.currentTimers.Text = "";
            // 
            // removeMedicationTitle
            // 
            this.removeMedicationTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.removeMedicationTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMedicationTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.removeMedicationTitle.Location = new System.Drawing.Point(24, 23);
            this.removeMedicationTitle.Margin = new System.Windows.Forms.Padding(6);
            this.removeMedicationTitle.Name = "removeMedicationTitle";
            this.removeMedicationTitle.Size = new System.Drawing.Size(1398, 125);
            this.removeMedicationTitle.TabIndex = 11;
            this.removeMedicationTitle.Text = "Remove Medication";
            this.removeMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchMed
            // 
            this.searchMed.Location = new System.Drawing.Point(412, 309);
            this.searchMed.Margin = new System.Windows.Forms.Padding(6);
            this.searchMed.Name = "searchMed";
            this.searchMed.Size = new System.Drawing.Size(150, 44);
            this.searchMed.TabIndex = 1;
            this.searchMed.Text = "Search";
            this.searchMed.UseVisualStyleBackColor = true;
            this.searchMed.Click += new System.EventHandler(this.searchMed_Click);
            // 
            // nameOfMedInput
            // 
            this.nameOfMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfMedInput.Location = new System.Drawing.Point(506, 231);
            this.nameOfMedInput.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfMedInput.Name = "nameOfMedInput";
            this.nameOfMedInput.Size = new System.Drawing.Size(348, 41);
            this.nameOfMedInput.TabIndex = 0;
            // 
            // nameOfMedLable
            // 
            this.nameOfMedLable.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameOfMedLable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfMedLable.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.nameOfMedLable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nameOfMedLable.Location = new System.Drawing.Point(24, 231);
            this.nameOfMedLable.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfMedLable.Name = "nameOfMedLable";
            this.nameOfMedLable.Size = new System.Drawing.Size(446, 34);
            this.nameOfMedLable.TabIndex = 16;
            this.nameOfMedLable.Text = "Name of Medication to Remove";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.Location = new System.Drawing.Point(24, 742);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 44);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // treatTimeOutput
            // 
            this.treatTimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatTimeOutput.Location = new System.Drawing.Point(636, 497);
            this.treatTimeOutput.Margin = new System.Windows.Forms.Padding(6);
            this.treatTimeOutput.Name = "treatTimeOutput";
            this.treatTimeOutput.Size = new System.Drawing.Size(196, 35);
            this.treatTimeOutput.TabIndex = 1;
            this.treatTimeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medDoesOutput
            // 
            this.medDoesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDoesOutput.Location = new System.Drawing.Point(378, 497);
            this.medDoesOutput.Margin = new System.Windows.Forms.Padding(6);
            this.medDoesOutput.Name = "medDoesOutput";
            this.medDoesOutput.Size = new System.Drawing.Size(216, 35);
            this.medDoesOutput.TabIndex = 0;
            this.medDoesOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medNameOutput
            // 
            this.medNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameOutput.Location = new System.Drawing.Point(106, 499);
            this.medNameOutput.Margin = new System.Windows.Forms.Padding(6);
            this.medNameOutput.Name = "medNameOutput";
            this.medNameOutput.Size = new System.Drawing.Size(222, 35);
            this.medNameOutput.TabIndex = 2;
            this.medNameOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treatTimeLeble
            // 
            this.treatTimeLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.treatTimeLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treatTimeLeble.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.treatTimeLeble.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.treatTimeLeble.Location = new System.Drawing.Point(636, 441);
            this.treatTimeLeble.Margin = new System.Windows.Forms.Padding(6);
            this.treatTimeLeble.Name = "treatTimeLeble";
            this.treatTimeLeble.Size = new System.Drawing.Size(196, 30);
            this.treatTimeLeble.TabIndex = 23;
            this.treatTimeLeble.Text = "Treatment Time";
            this.treatTimeLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doesOfMedLeble
            // 
            this.doesOfMedLeble.BackColor = System.Drawing.Color.DarkSlateGray;
            this.doesOfMedLeble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doesOfMedLeble.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.doesOfMedLeble.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.doesOfMedLeble.Location = new System.Drawing.Point(378, 441);
            this.doesOfMedLeble.Margin = new System.Windows.Forms.Padding(6);
            this.doesOfMedLeble.Name = "doesOfMedLeble";
            this.doesOfMedLeble.Size = new System.Drawing.Size(216, 30);
            this.doesOfMedLeble.TabIndex = 22;
            this.doesOfMedLeble.Text = "Medication Dose";
            this.doesOfMedLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doesOfMedLeble.TextChanged += new System.EventHandler(this.doesOfMedLeble_TextChanged);
            // 
            // nameOfMedLable2
            // 
            this.nameOfMedLable2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameOfMedLable2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfMedLable2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nameOfMedLable2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nameOfMedLable2.Location = new System.Drawing.Point(106, 443);
            this.nameOfMedLable2.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfMedLable2.Name = "nameOfMedLable2";
            this.nameOfMedLable2.Size = new System.Drawing.Size(222, 30);
            this.nameOfMedLable2.TabIndex = 21;
            this.nameOfMedLable2.Text = "Medication Name";
            this.nameOfMedLable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.remove.Location = new System.Drawing.Point(412, 607);
            this.remove.Margin = new System.Windows.Forms.Padding(6);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(150, 44);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clear.Location = new System.Drawing.Point(412, 663);
            this.clear.Margin = new System.Windows.Forms.Padding(6);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(150, 44);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Remove_Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1450, 810);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.treatTimeOutput);
            this.Controls.Add(this.medDoesOutput);
            this.Controls.Add(this.medNameOutput);
            this.Controls.Add(this.treatTimeLeble);
            this.Controls.Add(this.doesOfMedLeble);
            this.Controls.Add(this.nameOfMedLable2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.searchMed);
            this.Controls.Add(this.nameOfMedInput);
            this.Controls.Add(this.nameOfMedLable);
            this.Controls.Add(this.currentTimersTitle);
            this.Controls.Add(this.currentTimers);
            this.Controls.Add(this.removeMedicationTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Remove_Medication";
            this.Text = "Remove_Medication";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox currentTimersTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox removeMedicationTitle;
		private System.Windows.Forms.Button searchMed;
		private System.Windows.Forms.TextBox nameOfMedInput;
		private System.Windows.Forms.TextBox nameOfMedLable;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox treatTimeOutput;
		private System.Windows.Forms.TextBox medDoesOutput;
		private System.Windows.Forms.TextBox medNameOutput;
		private System.Windows.Forms.TextBox treatTimeLeble;
		private System.Windows.Forms.TextBox doesOfMedLeble;
		private System.Windows.Forms.TextBox nameOfMedLable2;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.Button clear;
	}
}