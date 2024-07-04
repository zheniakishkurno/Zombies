namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(174, 56);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(553, 449);
            label1.Name = "label1";
            label1.Size = new Size(531, 50);
            label1.TabIndex = 1;
            label1.Text = "Выйти из аккаунта";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(61, 288);
            label2.Name = "label2";
            label2.Size = new Size(387, 50);
            label2.TabIndex = 2;
            label2.Text = "Сменить тему";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(108, 368);
            button2.Name = "button2";
            button2.Size = new Size(245, 90);
            button2.TabIndex = 3;
            button2.Text = "Светлая";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(108, 533);
            button3.Name = "button3";
            button3.Size = new Size(245, 90);
            button3.TabIndex = 4;
            button3.Text = "Темная";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button4.FlatAppearance.MouseOverBackColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(694, 533);
            button4.Name = "button4";
            button4.Size = new Size(277, 90);
            button4.TabIndex = 5;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(313, 66);
            label3.Name = "label3";
            label3.Size = new Size(547, 93);
            label3.TabIndex = 6;
            label3.Text = "Настройки";
            label3.TextAlign = ContentAlignment.BottomLeft;
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(649, 288);
            label5.Name = "label5";
            label5.Size = new Size(211, 50);
            label5.TabIndex = 10;
            label5.Text = "Музыка";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(911, 278);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(911, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 770);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}