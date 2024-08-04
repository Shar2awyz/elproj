namespace elproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
