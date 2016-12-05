using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



//Brandon Roy
//Date:December 3 2016
//purpose:To demonstrate  that I know how to use multiple forms to interact with each other




namespace takeHomeAssignment
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            InputForm form1 = new InputForm();
            form1.Close();

            this.Close();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {






        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            //THis will load the txt file and fill the textboxes with the information


            //need to get it to show info and 
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            this.openFileDialog.InitialDirectory = "c:\\";
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            outputEmployeeNameTextbox.Text = File.ReadAllText(openFileDialog.FileName);
                            outputEmployeeNumberTextbox.Text = File.ReadAllText(openFileDialog.FileName);
                            outputHoursWorkedTextbox.Text = File.ReadAllText(openFileDialog.FileName);
                            outputWeeklyPayTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }




            }
        }
    }
}
