namespace elproj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            trackBar1 = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(351, 410);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(145, 46);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 43);
            label1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 343);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 307);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(241, 32);
            label2.TabIndex = 4;
            label2.Text = "please enter your job";
            label2.Click += label2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(0, 0);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(208, 90);
            trackBar1.TabIndex = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 43);
            label3.Name = "label3";
            label3.Size = new Size(40, 32);
            label3.TabIndex = 6;
            label3.Text = "15";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 43);
            label4.Name = "label4";
            label4.Size = new Size(58, 32);
            label4.TabIndex = 7;
            label4.Text = "17.5";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 43);
            label5.Name = "label5";
            label5.Size = new Size(40, 32);
            label5.TabIndex = 8;
            label5.Text = "20";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 1);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "Rate Us";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(707, 477);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 32);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Rate Project";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hospital_building_for_healthcare_background_illustration_with_ambulance_car_doctor_patient_nurses_and_medical_clinic_exterior_free_vector;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(860, 518);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Main Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TrackBar trackBar1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}
