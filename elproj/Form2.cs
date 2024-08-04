using System;
using System.Windows.Forms;

namespace elproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Ensure event handlers are connected
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            CheckBox2.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
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
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "add employee" && checkBox1.Checked == true)
            {
                Form4 fors = new Form4();
                fors.Show();
                this.Hide();
            }
            else
                MessageBox.Show("اصبر لسه");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Uncheck and disable CheckBox2 if CheckBox1 is checked
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }
            else
            {
                // Enable CheckBox2 if CheckBox1 is unchecked
                CheckBox2.Enabled = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                // Uncheck and disable checkBox1 if CheckBox2 is checked
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
            else
            {
                // Enable checkBox1 if CheckBox2 is unchecked
                checkBox1.Enabled = true;
            }
        }
    }
}
