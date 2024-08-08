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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string filePath = @"D:\AssisDr.txt";

            
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


                        textBox2.Text = $" {name}\n";


                        textBox3.Text =  $" {id}\n"  ;
                        
                        textBox4.Text =   $"{department}\n  ";

                        textBox5.Text = $"{bonus}";
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
