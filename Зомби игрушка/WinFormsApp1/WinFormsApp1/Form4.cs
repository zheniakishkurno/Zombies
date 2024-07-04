using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Media;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        int score;
        int id;
        int Tema = 1;
        int Cash = 0;
        int Gan = 0;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb";
        public Form4(int id, int Tema, int score)
        {
            this.id = id;
            this.Tema = Tema;
            this.score = score;
            InitializeComponent();
        }

        

        private void Form4_Load(object sender, EventArgs e)
        {
            
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                string query = "SELECT Cash FROM Cash WHERE ID = id";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("ID", id);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Cash = Convert.ToInt32(reader["Cash"]);
                        }
                        else
                        {
                            Cash = 0;
                        }
                    }
                }
            }
            label8.Text = Cash.ToString();
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
                        label4.ForeColor = Color.White;
                        label5.ForeColor = Color.White;
                        label6.ForeColor = Color.White;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        break;
                    }
                case 2:
                    {
                        Image image = new Bitmap(@"C:\Колледж\Зомби игрушка\WinFormsApp1\2.png");
                        this.BackgroundImage = image;
                        label1.ForeColor = Color.White;
                        label2.ForeColor = Color.White;
                        label3.ForeColor = Color.White;
                        label4.ForeColor = Color.White;
                        label5.ForeColor = Color.White;
                        label6.ForeColor = Color.White;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        break;
                    }

            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cash >= 50)
            {
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    dbConnection.Open();
                    string query2 = "SELECT Gan FROM Gan WHERE ID = id";
                    using (OleDbCommand command = new OleDbCommand(query2, dbConnection))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Gan = Convert.ToInt32(reader["Gan"]);
                            }
                        }
                    }
                    if (Gan == 0)
                    {
                        string query = "UPDATE Cash SET Cash = Cash - 50 WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                        {
                            Cash -= 50;
                            command.Parameters.AddWithValue("@Cash", Cash);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                        label8.Text = Cash.ToString();
                        string query1 = "UPDATE Gan SET Gan = 1 WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query1, dbConnection))
                        {
                            command.Parameters.AddWithValue("@Gan", Gan);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Вы преобрели <GLOCK>");
                    }
                    else
                    {
                        MessageBox.Show("Это оружее уже преобретено");
                    }
                    dbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не достаточно средств");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
                if (Cash >= 150)
                {
                    using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                    {
                        dbConnection.Open();
                        string query2 = "SELECT Gan FROM Gan WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query2, dbConnection))
                        {
                            command.Parameters.AddWithValue("ID", id);
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Gan = Convert.ToInt32(reader["Gan"]);
                                }
                            }
                        }
                        if (Gan == 1)
                        {
                            string query = "UPDATE Cash SET Cash = Cash - 150 WHERE ID = id";
                            using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                            {
                                Cash -= 150;
                                command.Parameters.AddWithValue("@Cash", Cash);
                                command.Parameters.AddWithValue("@ID", id);
                                command.ExecuteNonQuery();
                            }
                            label8.Text = Cash.ToString();
                            string query1 = "UPDATE Gan SET Gan = 2 WHERE ID = id";
                            using (OleDbCommand command = new OleDbCommand(query1, dbConnection))
                            {
                            command.Parameters.AddWithValue("@Gan", Gan);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                            }
                        MessageBox.Show("Вы преобрели <UMP>");
                        }
                        else
                        {
                           if (Gan == 0)
                           {
                              MessageBox.Show("Вы не можете приобрести это оружее до тех, пор пока не приобретете предыдущее ");
                           }
                            else
                            {
                                MessageBox.Show("Это оружее уже преобретено");
                            }
                        }
                    dbConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("У вас не достаточно средств");
                }
            
        
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Cash >= 250)
            {
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    dbConnection.Open();
                    string query2 = "SELECT Gan FROM Gan WHERE ID = id";
                    using (OleDbCommand command = new OleDbCommand(query2, dbConnection))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Gan = Convert.ToInt32(reader["Gan"]);
                            }
                        }
                    }
                    if (Gan == 2)
                    {
                        string query = "UPDATE Cash SET Cash = Cash - 250 WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                        {
                            Cash -= 250;
                            command.Parameters.AddWithValue("@Cash", Cash);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                        label8.Text = Cash.ToString();

                        string query1 = "UPDATE Gan SET Gan = 3 WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query1, dbConnection))
                        {
                            command.Parameters.AddWithValue("@Gan", Gan);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Вы преобрели <ППД>");
                    }
                    else
                    {
                        if (Gan == 0 || Gan == 1)
                        {
                            MessageBox.Show("Вы не можете приобрести это оружее до тех, пор пока не приобретете предыдущее ");
                        }
                        else
                        {
                            MessageBox.Show("Это оружее уже преобретено");
                        }
                    }
                    dbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не достаточно средств");
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
    }
}
