using System;
using System.IO;
using System.Windows.Forms;

namespace elproj
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\\Recep.txt";

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
                        string department = lines[i + 1].Trim();
                        string bonus = lines[i + 2].Trim();

                       
                        textBox2.Text = name;
                        textBox3.Text = id;
                        textBox4.Text = department;
                        textBox5.Text = bonus;
                        return;
                    }
                }

                MessageBox.Show("Receptionist not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
           
        }
    }
}
