namespace elproj
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 128);
            textBox1.Margin = new Padding(7, 6, 7, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 39);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 62);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 10;
            label4.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 262);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 11;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 326);
            textBox2.Margin = new Padding(7, 6, 7, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 39);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 542);
            textBox3.Margin = new Padding(7, 6, 7, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 39);
            textBox3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 480);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 15;
            label2.Text = "Condition";
            // 
            // button1
            // 
            button1.Location = new Point(1079, 745);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(154, 47);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1309, 745);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(154, 47);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.healthcare_and_medicine_concept_smart_medical_doctor_working_with_stethoscope_at_modern_hospital_free_photo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 960);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}