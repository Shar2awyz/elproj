namespace elproj
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add patient ", "Search patient ", "display ", "Delete All" });
            comboBox1.Location = new Point(500, 307);
            comboBox1.Margin = new Padding(6, 6, 6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(518, 418);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(154, 47);
            button1.TabIndex = 1;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(878, 570);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(154, 47);
            button2.TabIndex = 2;
            button2.Text = "Main Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1101, 680);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}