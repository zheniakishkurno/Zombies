namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(245, 205);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(665, 53);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(245, 295);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(665, 53);
            textBox2.TabIndex = 2;
            textBox2.Visible = false;
            textBox2.Click += textBox2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(245, 387);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(665, 53);
            textBox3.TabIndex = 3;
            textBox3.Visible = false;
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkGray;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(245, 483);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(665, 52);
            textBox4.TabIndex = 4;
            textBox4.Visible = false;
            textBox4.Click += textBox4_Click;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.DarkGray;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(36, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(446, 62);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "Зарегистрироваться";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.DarkGray;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(750, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(379, 62);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Авторизировться";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(334, 649);
            button1.Name = "button1";
            button1.Size = new Size(494, 83);
            button1.TabIndex = 7;
            button1.Text = "Зарегистрироваться ";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(444, 387);
            button2.Name = "button2";
            button2.Size = new Size(265, 83);
            button2.TabIndex = 8;
            button2.Text = "Войти";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(12, 676);
            button3.Name = "button3";
            button3.Size = new Size(183, 82);
            button3.TabIndex = 9;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkGray;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            textBox5.Location = new Point(245, 567);
            textBox5.MaxLength = 6;
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(218, 52);
            textBox5.TabIndex = 10;
            textBox5.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button4.FlatAppearance.MouseOverBackColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(469, 567);
            button4.Name = "button4";
            button4.Size = new Size(446, 52);
            button4.TabIndex = 11;
            button4.Text = "код подтвержления";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(932, 295);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(932, 387);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Silver;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(174, 205);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Silver;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(174, 295);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Silver;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(174, 387);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Silver;
            pictureBox7.ErrorImage = (Image)resources.GetObject("pictureBox7.ErrorImage");
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(174, 483);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(55, 52);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1159, 770);
            ControlBox = false;
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox5;
        private Button button4;
        protected TextBox textBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private BindingSource bindingSource1;
    }
}
