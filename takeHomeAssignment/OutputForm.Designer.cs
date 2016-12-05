namespace takeHomeAssignment
{
    partial class OutputForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.employeeInformationLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.weeklyPayLabel = new System.Windows.Forms.Label();
            this.outputNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputEmployeeNameTextbox = new System.Windows.Forms.TextBox();
            this.outputEmployeeNumberTextbox = new System.Windows.Forms.TextBox();
            this.outputHoursWorkedTextbox = new System.Windows.Forms.TextBox();
            this.outputWeeklyPayTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(219, 448);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "&Next ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // employeeInformationLabel
            // 
            this.employeeInformationLabel.AutoSize = true;
            this.employeeInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.employeeInformationLabel.Location = new System.Drawing.Point(128, 40);
            this.employeeInformationLabel.Name = "employeeInformationLabel";
            this.employeeInformationLabel.Size = new System.Drawing.Size(247, 29);
            this.employeeInformationLabel.TabIndex = 2;
            this.employeeInformationLabel.Text = "Employee Information";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(72, 113);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLabel.TabIndex = 3;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Location = new System.Drawing.Point(72, 187);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.employeeNumberLabel.TabIndex = 4;
            this.employeeNumberLabel.Text = "Employee Number";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(72, 261);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.hoursWorkedLabel.TabIndex = 5;
            this.hoursWorkedLabel.Text = "Hours Worked";
            // 
            // weeklyPayLabel
            // 
            this.weeklyPayLabel.AutoSize = true;
            this.weeklyPayLabel.Location = new System.Drawing.Point(72, 316);
            this.weeklyPayLabel.Name = "weeklyPayLabel";
            this.weeklyPayLabel.Size = new System.Drawing.Size(64, 13);
            this.weeklyPayLabel.TabIndex = 6;
            this.weeklyPayLabel.Text = "Weekly Pay";
            // 
            // outputNameLabel
            // 
            this.outputNameLabel.AutoSize = true;
            this.outputNameLabel.Location = new System.Drawing.Point(460, 458);
            this.outputNameLabel.Name = "outputNameLabel";
            this.outputNameLabel.Size = new System.Drawing.Size(69, 13);
            this.outputNameLabel.TabIndex = 7;
            this.outputNameLabel.Text = "Brandon Roy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "@$10.50/hour";
            // 
            // outputEmployeeNameTextbox
            // 
            this.outputEmployeeNameTextbox.Location = new System.Drawing.Point(205, 106);
            this.outputEmployeeNameTextbox.Name = "outputEmployeeNameTextbox";
            this.outputEmployeeNameTextbox.ReadOnly = true;
            this.outputEmployeeNameTextbox.Size = new System.Drawing.Size(169, 20);
            this.outputEmployeeNameTextbox.TabIndex = 9;
            // 
            // outputEmployeeNumberTextbox
            // 
            this.outputEmployeeNumberTextbox.Location = new System.Drawing.Point(205, 187);
            this.outputEmployeeNumberTextbox.Name = "outputEmployeeNumberTextbox";
            this.outputEmployeeNumberTextbox.ReadOnly = true;
            this.outputEmployeeNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.outputEmployeeNumberTextbox.TabIndex = 10;
            // 
            // outputHoursWorkedTextbox
            // 
            this.outputHoursWorkedTextbox.Location = new System.Drawing.Point(205, 258);
            this.outputHoursWorkedTextbox.Name = "outputHoursWorkedTextbox";
            this.outputHoursWorkedTextbox.ReadOnly = true;
            this.outputHoursWorkedTextbox.Size = new System.Drawing.Size(100, 20);
            this.outputHoursWorkedTextbox.TabIndex = 11;
            // 
            // outputWeeklyPayTextBox
            // 
            this.outputWeeklyPayTextBox.Location = new System.Drawing.Point(205, 313);
            this.outputWeeklyPayTextBox.Name = "outputWeeklyPayTextBox";
            this.outputWeeklyPayTextBox.ReadOnly = true;
            this.outputWeeklyPayTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputWeeklyPayTextBox.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 478);
            this.Controls.Add(this.outputWeeklyPayTextBox);
            this.Controls.Add(this.outputHoursWorkedTextbox);
            this.Controls.Add(this.outputEmployeeNumberTextbox);
            this.Controls.Add(this.outputEmployeeNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputNameLabel);
            this.Controls.Add(this.weeklyPayLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.employeeNumberLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.employeeInformationLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutputForm";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label employeeInformationLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label weeklyPayLabel;
        private System.Windows.Forms.Label outputNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputEmployeeNameTextbox;
        private System.Windows.Forms.TextBox outputEmployeeNumberTextbox;
        private System.Windows.Forms.TextBox outputHoursWorkedTextbox;
        private System.Windows.Forms.TextBox outputWeeklyPayTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}