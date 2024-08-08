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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(checkBox1.Checked&&checkBox2.Checked==false) {
                try
                {
                    using (StreamWriter st = new StreamWriter("D:\\AssisDr.txt", true))
                    {

                        AssisDr employees = new AssisDr();
                        employees.Name = textBox1.Text;
                        employees.ID = textBox2.Text;
                        employees.Department = textBox3.Text;
                        employees.setBonus(textBox4.Text);
                        st.WriteLine(employees.Name);
                        st.WriteLine(employees.ID);
                        st.WriteLine(employees.Department);
                        st.WriteLine(employees.getBonus());

                    }
                    MessageBox.Show("Submitted Successfully");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
           else
                  if (checkBox2.Checked && checkBox1.Checked == false)
            {
                try
                {
                    using (StreamWriter st = new StreamWriter("D:\\Recep.txt", true))
                    {

                        Receptionist employees = new Receptionist();
                        employees.Name = textBox1.Text;
                        employees.ID = textBox2.Text;
                        employees.Department = textBox3.Text;
                        employees.setBonus(textBox4.Text);
                        st.WriteLine(employees.Name);
                        st.WriteLine(employees.ID);
                        st.WriteLine(employees.Department);
                        st.WriteLine(employees.getBonus());

                    }
                    MessageBox.Show("Submitted Successfully");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
                checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox1.Checked = false;

        }
    }
}
