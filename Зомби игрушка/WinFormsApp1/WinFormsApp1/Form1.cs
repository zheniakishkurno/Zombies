using Microsoft.VisualBasic.Logging;
using System;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Media;
using System.Security.Policy;
using System.Drawing.Drawing2D;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        int Tema = 1;
        int id;
        int score;
        int Gan;
        int Cash;
        Random random = new Random();
        string value = "";
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb";

        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            button4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.Location = new Point(245, 205);
            textBox2.Location = new Point(245, 295);
            button2.Location = new Point(444, 387);
            pictureBox2.Location = new Point(932, 295);
            pictureBox4.Location = new Point(174, 205);
            pictureBox5.Location = new Point(174, 295);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button4.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();

            textBox1.Location = new Point(245, 279);
            textBox2.Location = new Point(245, 369);
            button2.Location = new Point(444, 459);
            pictureBox2.Location = new Point(932, 369);
            pictureBox4.Location = new Point(174, 279);
            pictureBox5.Location = new Point(174, 369);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, pattern);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text != Convert.ToString(value))
            {
                MessageBox.Show("Неверный код подтверждения"); return;
            }
            if (textBox3.Text != textBox2.Text) { MessageBox.Show("Пороли не совпадают"); return; }

            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Все поля обязательны для заполнения"); return;
            }
            if (textBox2.TextLength < 5)
            {
                MessageBox.Show("Пароль должен быть создан не менее из 5 символов"); return;
            }

            string login = textBox1.Text;
            string password = textBox2.Text;
            string Email = textBox4.Text;

            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {

                dbConnection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Имя пользователя уже занято. Пожалуйста, выберите другое");
                        return;
                    }
                    else
                    {
                        Form2 f2 = new Form2(id, Tema, score, Cash);
                        f2.Show();
                        this.Hide();
                        GC.Collect(4, GCCollectionMode.Forced);
                        GC.GetTotalMemory(true);
                    }
                }

                query = "INSERT INTO Users VALUES (@ID,@Login, @Password, @Email)";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                {
                    string querySel = "Select count(*) from Users";
                    using (OleDbCommand cm = new OleDbCommand(querySel, dbConnection)) { id = (int)cm.ExecuteScalar(); }
                    id++;
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.ExecuteNonQuery();
                }
                query = "INSERT INTO Cash VALUES (@ID, @Cash)";
                using (OleDbCommand cm = new OleDbCommand(query, dbConnection))
                {
                    cm.Parameters.AddWithValue("@ID", id);
                    cm.Parameters.AddWithValue("@Cash", "0");
                    cm.ExecuteNonQuery();
                }
                query = "INSERT INTO Tema VALUES (@ID, @Tema)";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Tema", "1");
                    command.ExecuteNonQuery();
                }
                query = "INSERT INTO Gan VALUES (@ID, @Gan)";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Gan", "0");
                    command.ExecuteNonQuery();
                }
                query = "INSERT INTO Riting VALUES (@ID, @Login, @Cash)";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Cash", Cash);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Регистрацмя прошла успешно.");
                dbConnection.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                string query1 = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                using (OleDbCommand command1 = new OleDbCommand(query1, dbConnection))
                {
                    command1.Parameters.AddWithValue("@Email", email);
                    int count1 = (int)command1.ExecuteScalar();
                    if (count1 > 0)
                    {
                        MessageBox.Show("Аккаунт с такой почтой уже занят");
                        return;
                    }
                    else
                    {
                        if (IsValidEmail(email))
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                value += random.Next(1, 10).ToString();
                                value += (char)(random.Next('a', 'z'));
                            }
                            MailAddress from = new MailAddress("igruxaproject@gmail.com");
                            MailAddress to = new MailAddress(email);
                            // Создаем объект сообщения
                            MailMessage message = new MailMessage(from, to)
                            {
                                Subject = "Код подтвержедене",
                                Body = Convert.ToString(value)
                            };
                            // Создаем объект SmtpClient с настройками сервера
                            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                            {
                                EnableSsl = true,
                                Credentials = new NetworkCredential("igruxaproject@gmail.com", "aeoi wuux qnzc ilbx"),
                            };
                            smtpClient.Send(message);
                            MessageBox.Show("Кодовое cообщение отправлено!");
                        }
                        else
                        {
                            MessageBox.Show("Некоректно введина почта");
                        }
                    }

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.PasswordChar = '\0';
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Все поля обязательны для заполнения");
            }
            else
            {
                string login = textBox1.Text;
                string password = textBox2.Text;
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        dbConnection.Open();
                        string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";
                        using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                        {
                            command.Parameters.AddWithValue("@Login", login);
                            command.Parameters.AddWithValue("@Password", password);
                            int count = (int)command.ExecuteScalar();
                            if (count > 0)
                            {

                                MessageBox.Show("С успешный вход в аккаунт: " + login);
                                Form2 f2 = new Form2(id, Tema, score, Cash);
                                f2.Show();
                                this.Hide();
                                GC.Collect(4, GCCollectionMode.Forced);
                                GC.GetTotalMemory(true);
                            }
                            else
                            {
                                MessageBox.Show("Неврное имя пользователя или пароль");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при авторизации:" + ex.Message);
                    }
                    finally
                    {
                        dbConnection.Close();
                        GC.Collect(4, GCCollectionMode.Forced);
                        GC.GetTotalMemory(true);
                    }
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
