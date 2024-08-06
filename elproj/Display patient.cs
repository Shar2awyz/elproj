using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace elproj
{
    public partial class Display_patient : Form
    {
        public Display_patient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.ReadOnly = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.ReadOnly = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.ReadOnly = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.ReadOnly = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.ReadOnly = true;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.ReadOnly = true;
        }

        

    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("D:\\AssisDr.txt"))
                {
                    textBox1.Text = sr.ReadLine();
                    textBox2.Text = sr.ReadLine();
                    textBox3.Text = sr.ReadLine();
                    textBox4.Text = sr.ReadLine();
                    textBox5.Text = sr.ReadLine();
                    textBox6.Text = sr.ReadLine();
                    textBox7.Text = sr.ReadLine();
                    textBox8.Text = sr.ReadLine();
                    textBox9.Text = sr.ReadLine();
                    textBox10.Text = sr.ReadLine();
                    textBox11.Text = sr.ReadLine();
                    textBox12.Text = sr.ReadLine();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

    }
}
