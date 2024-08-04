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
            StreamWriter st = new StreamWriter("Documents\\Employee.txt");
            
            employee employees = new employee();
            employees.setName(textBox1.Text);
         
            st.WriteLine(employees.getName());


          


          








            MessageBox.Show("Submitted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            form.Show();
            this.Hide();
        }
    }
}
