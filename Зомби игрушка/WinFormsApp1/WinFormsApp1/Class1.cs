using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    internal class Class1
    {
        public string driection;
        public int bulletleft;
        public int bullettop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bullettimer = new Timer();

        public void MakeBullet(Form form )
        {
            bullet.BackColor = Color.Black;
            bullet.BringToFront();
            bullet.Size = new Size(6, 6);
            bullet.Tag = "bullet";
            bullet.Left = bulletleft;
            bullet.Top = bullettop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bullettimer.Interval = speed;
            bullettimer.Tick += new EventHandler(BulletTimerEvent);
            bullettimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (driection == "left")
            {
                bullet.Left -= speed;
            }
            if (driection == "right") 
            {
                bullet.Left += speed;
            }
            if (driection == "up") 
            {
                bullet.Top -= speed;
            }
            if(driection == "down")
            {
                bullet.Top += speed;    
            }

            if (bullet.Left < 10 || bullet.Left > 1159 || bullet.Top < 10 || bullet.Top > 770)
            {
                bullettimer.Stop();
                bullettimer.Dispose();
                bullet.Dispose();
                bullettimer = null;
                bullet = null;
            }

        }
    }
}
