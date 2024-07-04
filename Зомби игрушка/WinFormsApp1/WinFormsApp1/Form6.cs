using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {

        int id;
        int Tema=1;
        public Form6(int id, int Tema)
        {
            InitializeComponent();
            this.id = id;
            this.Tema = Tema;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(id, Tema);
            f5.Show();
            this.Hide();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
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
    }
}
