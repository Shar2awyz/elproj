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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string filePath = @"D:\Patients.txt";


            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found: " + filePath);
                return;
            }


            string inputId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(inputId))
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            try
            {

                string[] lines = File.ReadAllLines(filePath);


                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Trim() == inputId)
                    {

                        string name = lines[i - 1].Trim();
                        string id = lines[i].Trim();
                        string Condition = lines[i + 1].Trim();
                      


                        textBox2.Text = $" {name}\n";


                        textBox3.Text = $" {id}\n";

                        textBox4.Text = $"{Condition}\n  ";

                       
                        return;
                    }
                }


                MessageBox.Show("Assistant Doctor not found.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
