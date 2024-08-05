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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter st = new StreamWriter("D:\\Patients.txt",true))
                {
                    Patient Patients = new Patient();
                    Patients.Name = textBox1.Text;
                    Patients.ID = textBox2.Text;
                    Patients.Condition = textBox3.Text;
                    st.WriteLine(Patients.Name);
                    st.WriteLine(Patients.ID);
                    st.WriteLine(Patients.Condition);

                }
                MessageBox.Show("Submitted Successfully");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
