using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace elproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
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
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Delete All")
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
     if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "display") {
                checkBox1.Show();
                CheckBox2.Show();




            }




            else


                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Delete All")
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
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Delete All")
            {
                

                if (checkBox1.Checked == true&&CheckBox2.Checked==false)
                {
                    try
                    {
                        using (StreamWriter st = new StreamWriter("D:\\AssisDr.txt", false))
                        {
                            MessageBox.Show("Assistant Drs Data Deleted");






                        }



                    }
                    catch (Exception cs)
                    {
                        MessageBox.Show("An Error Occured");



                    }
                }
                else if (CheckBox2.Checked == true && checkBox1.Checked == false)
                {
                    MessageBox.Show("Receptionist Data Deleted");
                    try
                    {
                        using (StreamWriter st = new StreamWriter("D:\\Recep.txt", false))
                        {







                        }



                    }
                    catch (Exception cs)
                    {
                        MessageBox.Show("An Error Occured");



                    }
                }
            }
            else
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "display"&&checkBox1.Checked==true&CheckBox2.Checked==false)
            {
                Form6 fors = new Form6();
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
             
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }
            else
            {
               
                CheckBox2.Enabled = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
              
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
            else
            {
                
                checkBox1.Enabled = true;
            }
        }
    }
}
