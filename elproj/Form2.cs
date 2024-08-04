using System;
using System.Windows.Forms;

namespace elproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Hide();
            CheckBox2.Hide();

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "add employee")
            {
                checkBox1.Show();
                CheckBox2.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle combo box selection change here
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "add employee")
            {
                checkBox1.Show();
                CheckBox2.Show();
            }
            else
            {
                checkBox1.Hide();
                CheckBox2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fors = new Form1();
            fors.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "add employee")
            {
                Form4 fors = new Form4();
                fors.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void Receptionist_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
