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
            try
            {
                using (StreamWriter st = new StreamWriter("D:\\Employeez.txt"))
                {
                    employee employees = new employee();
                    employees.Name=textBox1.Text;
                    employees.ID = textBox2.Text;
                    employees.Department=textBox3.Text;
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
            private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            form.Show();
            this.Hide();
        }
    }
}
