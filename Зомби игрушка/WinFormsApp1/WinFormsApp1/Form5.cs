using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Media;
using System.Numerics;
using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        private SoundPlayer player;

        int Gan;
        int score;
        int id;
        int Tema = 1;
        int ammo;
        int Cash;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb";
        public Form5(int id, int Tema)
        {
            this.id = id;
            this.Tema = Tema;
            InitializeComponent();
            
        }

        private void Play()
        {
            string soundFile = @"C:\Колледж\Зомби игрушка\WinFormsApp1\phonk.wav"; 
            player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void Stop()
        {
            if (player != null)
            {
                player.Stop();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            switch (Tema)
            {
                case 1:
                    {
                        Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\1.jpg");
                        this.BackgroundImage = image;
                        label1.ForeColor = Color.White;
                        label2.ForeColor = Color.White;
                        label3.ForeColor = Color.White;
                        label5.ForeColor = Color.White;
                        break;
                    }
                case 2:
                    {
                        Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\2.png");
                        this.BackgroundImage = image;
                        label1.ForeColor = Color.White;
                        label2.ForeColor = Color.White;
                        label3.ForeColor = Color.White;
                        label5.ForeColor = Color.White;
                        break;
                    }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(id, Tema, score, Cash);
            f2.Show();
            this.Hide();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }
        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                try
                {
                    dbConnection.Open();
                    string query = "UPDATE Tema SET Tema = 1 WHERE ID = id";
                    using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                    {
                        Tema = 1;
                        command.Parameters.AddWithValue("@Tema", Tema);
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }
                    Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\1.jpg");
                    this.BackgroundImage = image;
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.label5.ForeColor = Color.White;
                    dbConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                try
                {
                    dbConnection.Open();
                    string query = "UPDATE Tema SET Tema = 2 WHERE ID = id";
                    using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                    {
                        Tema = 2;
                        command.Parameters.AddWithValue("@Tema", Tema);
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }
                    Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\2.png");
                    this.BackgroundImage = image;
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.label5.ForeColor = Color.White;
                    dbConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            Stop();
        }
    }
}
