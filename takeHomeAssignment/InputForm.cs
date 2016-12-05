using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Brandon Roy
//Date:December 3 2016
//purpose:To demonstrate  that I know how to use multiple forms to interact with each other



namespace takeHomeAssignment
{
    public partial class InputForm : Form
    {


        const int  maxHours = 40;
        const int minimumHours = 0;



        public InputForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeNameTextbox.Clear();
            employeeNumberTextbox.Clear();
            hourWorkedTextbox.Clear();


            employeeNameTextbox.Focus();


        }

        private void InputForm_Load(object sender, EventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        

        


    }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if statement that checks if all fields have been filled out and will respond with a message.

            if (string.IsNullOrEmpty(employeeNameTextbox.Text))
            {

                MessageBox.Show("employee name must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (string.IsNullOrEmpty(employeeNumberTextbox.Text))

            {
                MessageBox.Show("Employee number field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (string.IsNullOrEmpty(hourWorkedTextbox.Text))

            {
                MessageBox.Show("Hours worked field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            int maxHours = 40;

            using (StreamWriter objWriter = new StreamWriter("test1.txt"))
            {
                objWriter.Write(employeeNameTextbox.Text + " ");
                objWriter.Write(employeeNumberTextbox.Text + " ");
                objWriter.Write(hourWorkedTextbox.Text + " ");
                

                MessageBox.Show("Details have been saved");
            }
            /*
            if
            (int.TryParse(this.hourWorkedTextbox.Text.Trim(), out maxHours))
            {
                if (maxHours > 0 && maxHours < 40)
                {
                    MessageBox.Show("Hours worked field must be between 0 and 40", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }*/



            employeeNameTextbox.Clear();
            employeeNumberTextbox.Clear();
            hourWorkedTextbox.Clear();


            employeeNameTextbox.Focus();
        }










        


        private void doneButton_Click(object sender, EventArgs e)
        {

            this.Hide();



            OutputForm form2 = new OutputForm();
            form2.ShowDialog();



            




       //     InputForm.Hide();
        }
    }
}
