namespace takeHomeAssignment
{
    partial class InputForm
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
            this.employeeInformationlabel = new System.Windows.Forms.Label();
            this.employeeNamelabel = new System.Windows.Forms.Label();
            this.EmployeeNumberLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hourWorkedTextbox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextbox = new System.Windows.Forms.TextBox();
            this.employeeNameTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeInformationlabel
            // 
            this.employeeInformationlabel.AutoSize = true;
            this.employeeInformationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.employeeInformationlabel.Location = new System.Drawing.Point(117, 41);
            this.employeeInformationlabel.Name = "employeeInformationlabel";
            this.employeeInformationlabel.Size = new System.Drawing.Size(247, 29);
            this.employeeInformationlabel.TabIndex = 0;
            this.employeeInformationlabel.Text = "Employee Information";
            // 
            // employeeNamelabel
            // 
            this.employeeNamelabel.AutoSize = true;
            this.employeeNamelabel.Location = new System.Drawing.Point(20, 46);
            this.employeeNamelabel.Name = "employeeNamelabel";
            this.employeeNamelabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNamelabel.TabIndex = 2;
            this.employeeNamelabel.Text = "Employee Name";
            // 
            // EmployeeNumberLabel
            // 
            this.EmployeeNumberLabel.AutoSize = true;
            this.EmployeeNumberLabel.Location = new System.Drawing.Point(20, 102);
            this.EmployeeNumberLabel.Name = "EmployeeNumberLabel";
            this.EmployeeNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.EmployeeNumberLabel.TabIndex = 3;
            this.EmployeeNumberLabel.Text = "Employee N&umber";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(20, 153);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(73, 13);
            this.hoursWorkedLabel.TabIndex = 4;
            this.hoursWorkedLabel.Text = "&Hours worked";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(480, 448);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Brandon Roy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hourWorkedTextbox);
            this.groupBox1.Controls.Add(this.employeeNumberTextbox);
            this.groupBox1.Controls.Add(this.employeeNameTextbox);
            this.groupBox1.Controls.Add(this.employeeNamelabel);
            this.groupBox1.Controls.Add(this.EmployeeNumberLabel);
            this.groupBox1.Controls.Add(this.hoursWorkedLabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please provide the employee\'s information";
            // 
            // hourWorkedTextbox
            // 
            this.hourWorkedTextbox.Location = new System.Drawing.Point(136, 146);
            this.hourWorkedTextbox.Name = "hourWorkedTextbox";
            this.hourWorkedTextbox.Size = new System.Drawing.Size(100, 20);
            this.hourWorkedTextbox.TabIndex = 7;
            // 
            // employeeNumberTextbox
            // 
            this.employeeNumberTextbox.Location = new System.Drawing.Point(136, 99);
            this.employeeNumberTextbox.Name = "employeeNumberTextbox";
            this.employeeNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.employeeNumberTextbox.TabIndex = 6;
            // 
            // employeeNameTextbox
            // 
            this.employeeNameTextbox.Location = new System.Drawing.Point(136, 46);
            this.employeeNameTextbox.Name = "employeeNameTextbox";
            this.employeeNameTextbox.Size = new System.Drawing.Size(183, 20);
            this.employeeNameTextbox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(42, 420);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(155, 420);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(263, 420);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "&Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(364, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 467);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.employeeInformationlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Form";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeInformationlabel;
        private System.Windows.Forms.Label employeeNamelabel;
        private System.Windows.Forms.Label EmployeeNumberLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox hourWorkedTextbox;
        private System.Windows.Forms.TextBox employeeNumberTextbox;
        private System.Windows.Forms.TextBox employeeNameTextbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

