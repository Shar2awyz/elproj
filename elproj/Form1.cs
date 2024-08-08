using System;
using System.Media;
using System.Windows.Forms;
namespace elproj
{
    public partial class Form1 : Form
    {
        private SoundPlayer _player;
        private SoundPlayer _player1;
        public Form1()
        {
            InitializeComponent();
            _player = new SoundPlayer(System.IO.Path.Combine(Application.StartupPath, "D:\\Downloads\\sou.wav"));
            _player1 = new SoundPlayer(System.IO.Path.Combine(Application.StartupPath, "D:\\Downloads\\lo.wav"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Hide();

            label4.Hide();
            label5.Hide();
            trackBar1.Hide();
            button2.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string specificword = "manager";
            string specificword2 = "employee";
            if (textBox1.Text == specificword)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else if (textBox1.Text == specificword2)
            {
                Form3 form1 = new Form3();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("incorrect password ,try again");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label3.Show();

            label4.Show();
            label5.Show();
            trackBar1.Show();
            button2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Maximum = 20;
            if (trackBar1.Value == trackBar1.Maximum)
            {
                _player.Play();
                MessageBox.Show("(^u^)شكرا يا وهدان ");
                MessageBox.Show("  ******       ******\r\n**    **     **    **\r\n**     **   **      **\r\n**      ** **        **\r\n **      **          **\r\n  **                 **\r\n    **             **\r\n      **         **\r\n        **     **\r\n          ** **\r\n            *");
              
            }
            else
           
            {
                _player1.Play();
                MessageBox.Show("لي كده بس كده يا وهدان");
               
              
            }
        }
    }
}
