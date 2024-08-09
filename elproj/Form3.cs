using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elproj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fors = new Form1();
            fors.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Add patient ")
            {
                Form5 form = new Form5();
                form.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "display ")
            {
                Form7 form = new Form7();
                form.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Delete All")
            {

                try
                {
                    using (StreamWriter st = new StreamWriter("D:\\Patients.txt", false))
                    {
                        MessageBox.Show("Patients Data Deleted");

                    }

                }
                catch (Exception cs)
                {
                    MessageBox.Show("An Error Occured");

                }

            }
            else
                  if ((comboBox1.SelectedItem.ToString() == "Search patient ")) {
            Form11 form = new Form11(); 
                form.Show();
                this.Hide();
            
            }
        }
    }
}
