using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoPractice3App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        int counter = 3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            
                while (regNoTextBox.Text != string.Empty && firstNameTextBox.Text != string.Empty &&
lastNameTextBox.Text != string.Empty)
                {

                    Student aStudent = new Student();
                    aStudent.regNo = regNoTextBox.Text;
                    aStudent.firstName = firstNameTextBox.Text;
                    aStudent.lastName = lastNameTextBox.Text;

                    if (counter>0)
                    {
                     students.Add(aStudent);
                     counter--;
                        MessageBox.Show("Information Saved");
                        regNoTextBox.Text = string.Empty;
                        firstNameTextBox.Text = string.Empty;
                        lastNameTextBox.Text = string.Empty;   
                    }
                    else
                    {
                        MessageBox.Show("Only 3 Entry");
                        break;
                    }
                }
               

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string heading = "Registration No:\tFullName:\n";
            String astring = "";
            foreach (Student astudent in students)
            {
                astring += (astudent.regNo + "\t" + astudent.GetFullName() + "\n");
            }
            MessageBox.Show(heading + astring);

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            MessageBox.Show("All data cleared");

        }
    }
}
