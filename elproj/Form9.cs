using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace elproj
{
    public partial class Form9: Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox13.ReadOnly = true;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox14.ReadOnly = true;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox15.ReadOnly = true;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox16.ReadOnly = true;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox17.ReadOnly = true;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox18.ReadOnly = true;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            textBox19.ReadOnly = true;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox20.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("D:\\Recep.txt"))
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
                    textBox13.Text = sr.ReadLine();
                    textBox14.Text = sr.ReadLine();
                    textBox15.Text = sr.ReadLine();
                    textBox16.Text = sr.ReadLine();
                    textBox17.Text = sr.ReadLine();
                    textBox18.Text = sr.ReadLine();
                    textBox19.Text = sr.ReadLine();
                    textBox20.Text = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
