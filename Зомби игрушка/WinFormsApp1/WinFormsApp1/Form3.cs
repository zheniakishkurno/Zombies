using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        int id;
        int Tema = 1;
        bool goLeft, goRight, goUp, goDown, GeamOver;
        string facingn = "up";
        int haelth = 100;
        int pleyerspeed = 10;
        int ammo;
        int zombiSpeed = 3;
        int score;
        int Cash;
        int Gan;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb";
        Random random = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();


        public Form3(int id, int Tema)
        {
            this.id = id;
            this.Tema = Tema;
            InitializeComponent();
            gaemOver();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            if (haelth > 1)
            {
                progressBar1.Value = haelth;
            }
            else
            {
                GeamOver = true;
                pictureBox1.Image = Properties.Resources.dead;
                timer1.Stop();
            }
            label1.Text = "Патроны: " + ammo;
            label2.Text = " Убито: " + score;

            if (goLeft == true && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= pleyerspeed;
            }
            if (goRight == true && pictureBox1.Left + pictureBox1.Width < this.ClientSize.Width)
            {
                pictureBox1.Left += pleyerspeed;
            }
            if (goUp == true && pictureBox1.Top > 60)
            {
                pictureBox1.Top -= pleyerspeed;
            }
            if (goDown == true && pictureBox1.Top + pictureBox1.Height < this.ClientSize.Height)
            {
                pictureBox1.Top += pleyerspeed;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        if (Gan == 0)
                            ammo += 7;
                        if (Gan == 1)
                            ammo += 17;
                        if (Gan == 2)
                            ammo += 30;
                        if (Gan == 3)
                            ammo += 40;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "zombi")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        haelth -= 1;
                    }
                    if (x.Left > pictureBox1.Left)
                    {
                        x.Left -= zombiSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < pictureBox1.Left)
                    {
                        x.Left += zombiSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > pictureBox1.Top)
                    {
                        x.Top -= zombiSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                    if (x.Top < pictureBox1.Top)
                    {
                        x.Top += zombiSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && control != x && control != pictureBox1)
                        {
                            PictureBox otherPb = control as PictureBox;
                            if (x.Bounds.IntersectsWith(otherPb.Bounds) && otherPb.Tag != "bullet")
                            {
                                if (x.Left < otherPb.Left)
                                {
                                    x.Left = otherPb.Left - x.Width;
                                }
                                else if (x.Left > otherPb.Left)
                                {
                                    x.Left = otherPb.Left + otherPb.Width;
                                }
                                if (x.Top < otherPb.Top)
                                {
                                    x.Top = otherPb.Top - x.Height;
                                }
                                else if (x.Top > otherPb.Top)
                                {
                                    x.Top = otherPb.Top + otherPb.Height;
                                }
                            }
                        }
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombi")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            makeZombi();
                        }
                    }
                }
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            if (GeamOver == true)
            {
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facingn = "left";
                pictureBox1.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facingn = "right";
                pictureBox1.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facingn = "up";
                pictureBox1.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facingn = "down";
                pictureBox1.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Пауза. Желаете вернуться в главное меню?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                    {
                        dbConnection.Open();
                        string query = "UPDATE Cash SET Cash = Cash + @score WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                        {
                            Cash += score;
                            command.Parameters.AddWithValue("@score", score);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                            dbConnection.Close();
                        }
                    }
                    Form2 f2 = new Form2(id, Tema, score, Cash);
                    f2.Show();
                    this.Hide();
                    GC.Collect(4, GCCollectionMode.Forced);
                    GC.GetTotalMemory(true);
                    timer1.Start();


                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && GeamOver == false)
            {
                ammo--;
                shootBullet(facingn);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
            if (GeamOver == true)
            {
                DialogResult result2 = MessageBox.Show("Игра окончена, Колличество заработаных манет - " + score + ". Желаете вернуться в главное меню?", "Сообщение", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                    {
                        dbConnection.Open();
                        string query = "UPDATE Cash SET Cash = Cash + @score WHERE ID = id";
                        using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                        {
                            Cash += score;
                            command.Parameters.AddWithValue("@score", score);
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                            dbConnection.Close();
                        }
                    }
                    Form2 f2 = new Form2(id, Tema, score, Cash);
                    f2.Show();
                    this.Hide();
                    GC.Collect(4, GCCollectionMode.Forced);
                    GC.GetTotalMemory(true);
                }
                else
                {
                    gaemOver();
                    GC.Collect(4, GCCollectionMode.Forced);
                    GC.GetTotalMemory(true);
                }
            }
        }

        private void shootBullet(string deriction)
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            Class1 shootbullet = new Class1();
            shootbullet.driection = deriction;
            shootbullet.bulletleft = pictureBox1.Left + (pictureBox1.Width / 2);
            shootbullet.bullettop = pictureBox1.Top + (pictureBox1.Height / 2);
            shootbullet.MakeBullet(this);
        }

        private void makeZombi()
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BringToFront();
            PictureBox zombi = new PictureBox();
            zombi.Tag = "zombi";
            zombi.Image = Properties.Resources.zdown;
            zombi.BackgroundImageLayout = ImageLayout.None;
            zombi.BackColor = Color.Transparent;
            zombi.Left = random.Next(0, 900);
            zombi.Top = random.Next(0, 800);
            zombi.SizeMode = PictureBoxSizeMode.AutoSize;
            zombi.BringToFront();
            zombiesList.Add(zombi);
            this.Controls.Add(zombi);

        }
        private void DropAmmo()
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = random.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = random.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            pictureBox1.BringToFront();
        }

        private void gaemOver()
        {
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            pictureBox1.Image = Properties.Resources.up;
            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for (int i = 0; i < 3; i++)
            {
                makeZombi();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            GeamOver = false;

            haelth = 100;
            score = 0;
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
                dbConnection.Close();
            }
            if (Gan == 0)
                ammo = 7;
            if (Gan == 1)
                ammo = 17;
            if (Gan == 2)
                ammo = 30;
            if (Gan == 3)
                ammo = 40;

            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
