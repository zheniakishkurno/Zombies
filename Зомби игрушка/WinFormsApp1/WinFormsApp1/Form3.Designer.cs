namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 43);
            label1.TabIndex = 0;
            label1.Text = "Патроны: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(335, 9);
            label2.Name = "label2";
            label2.Size = new Size(214, 43);
            label2.TabIndex = 1;
            label2.Text = " Убито: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(613, 12);
            label3.Name = "label3";
            label3.Size = new Size(213, 43);
            label3.TabIndex = 2;
            label3.Text = "Здоровье:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(832, 15);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(306, 40);
            progressBar1.TabIndex = 3;
            progressBar1.Value = 100;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.up;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(550, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1159, 770);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1159, 770);
            MinimumSize = new Size(1159, 770);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            KeyDown += Form3_KeyDown;
            KeyUp += Form3_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}