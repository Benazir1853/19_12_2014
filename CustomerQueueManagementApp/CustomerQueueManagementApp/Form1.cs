using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Customer> customers= new Queue<Customer>();
        private int counter = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();


            aCustomer = customers.Dequeue();
            serialDequeueTextBox.Text = aCustomer.serial;
            nameDequeueTextBox.Text = aCustomer.name;
            complainDequeueTextBox.Text = aCustomer.complain;


            customerListView.Items.RemoveAt(0);
        }

        private void nameEnqueueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            while (nameEnqueueTextBox.Text != string.Empty && complainEnqueueTextBox.Text != string.Empty)
            {
                

                //user interfacing;
                string name = nameEnqueueTextBox.Text;
                string complain = complainEnqueueTextBox.Text;
                counter = counter + 1;
                MessageBox.Show(counter+" " + name +" "+ complain);


                //setting  info to individual.
                Customer aCustomer = new Customer();
                aCustomer.serial = counter.ToString();
                aCustomer.name = name;
                aCustomer.complain = complain;

                customers.Enqueue(aCustomer);//doing enqueue.



                ListViewItem aListViewItem = new ListViewItem();


                aListViewItem.Text = aCustomer.serial;
                aListViewItem.SubItems.Add(aCustomer.name);
                aListViewItem.SubItems.Add(aCustomer.complain);

                
                
                customerListView.Items.Add(aListViewItem);



                nameEnqueueTextBox.Text = string.Empty;
                complainEnqueueTextBox.Text = string.Empty;
            }
        }

        private void customerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerListView.Columns.Add("Serial No");
            customerListView.Columns.Add("Name");
            customerListView.Columns.Add("Complains");
        }
    }
}
