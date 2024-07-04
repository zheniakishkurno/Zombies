namespace WinFormsApp1
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            button1.ForeColor = Color.Black;
            button1.Location = new Point(392, 258);
            button1.Name = "button1";
            button1.Size = new Size(374, 83);
            button1.TabIndex = 1;
            button1.Text = "Играть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(392, 382);
            button2.Name = "button2";
            button2.Size = new Size(374, 83);
            button2.TabIndex = 2;
            button2.Text = "Магазин";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(392, 509);
            button3.Name = "button3";
            button3.Size = new Size(374, 83);
            button3.TabIndex = 3;
            button3.Text = "Настройки";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button4.FlatAppearance.MouseOverBackColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(392, 633);
            button4.Name = "button4";
            button4.Size = new Size(374, 83);
            button4.TabIndex = 4;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 770);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}