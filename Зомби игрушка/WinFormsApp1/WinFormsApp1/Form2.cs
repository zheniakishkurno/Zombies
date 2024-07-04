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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Media;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        int id;
        int Tema = 1;
        int score;
        int Cash;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb";
        public Form2(int id, int Tema, int score, int Cash)
        {
            InitializeComponent();
            this.id = id;
            this.Tema = Tema;
            this.score = score;
            this.Cash = Cash;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);

                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    dbConnection.Open();
                    string query = "SELECT Tema FROM Tema WHERE ID = id";
                    using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Tema = reader.GetInt32(0);
                        }
                    }
                    dbConnection.Close();
                }
  
                GC.Collect(4, GCCollectionMode.Forced);
                GC.GetTotalMemory(true);
            switch (Tema)
            {
                case 1:
                    {
                        Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\1.jpg");
                        this.BackgroundImage = image;
                         
                        break;
                    }
                case 2:
                    {
                        Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\2.png");
                        this.BackgroundImage = image;
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(id,Tema);
            f3.Show();
            this.Hide();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(id, Tema, score);
            f4.Show();
            this.Hide();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(id,Tema);
            f5.Show();
            this.Hide();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }
    }
}
