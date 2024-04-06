using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrier
{
    public partial class Form1 : Form
    {
        int Yint;
        int Xint;
        int Yint2;
        int Xint2;
        bool Syvaryn = false;
        bool Karan = false;
        bool clicked1 = false;
        bool clicked2 = false;
        public Form1()
        { 
            InitializeComponent();
            this.KeyPreview = true;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Karan = true;
            clicked1 = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox1.Location.X+65, pictureBox1.Location.Y-78);
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (clicked1 == true)
            {
                Xint = Cursor.Position.X - 85; 
                Yint = Cursor.Position.Y - 26;
            }

            if (clicked2 == true)
            {
                Xint2 = Cursor.Position.X - 85;
                Yint2 = Cursor.Position.Y - 26;
            }

            clicked1 = false;
            clicked2 = false;

        }

        public async void timer1_Tick(object sender, EventArgs e)
        {
        await Task.Delay(5);
            if (Karan == true)
            {
                if (pictureBox1.Location.X != Xint || pictureBox1.Location.Y != Yint)
                {
                if (pictureBox1.Location.X > Xint)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                }
                else if (pictureBox1.Location.X < Xint)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                }

                if (pictureBox1.Location.Y > Yint)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-1);
                }
                else if (pictureBox1.Location.Y < Yint)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Syvaryn = true;
            clicked2 = true;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox3.Location.X + 65, pictureBox3.Location.Y - 78);
            pictureBox4.Visible = true;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.BorderStyle = BorderStyle.None;

        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            await Task.Delay(5);
                if (pictureBox3.Location.X != Xint2 || pictureBox3.Location.Y != Yint)
                {
                    if (pictureBox3.Location.X > Xint2)
                    {
                        pictureBox3.Location = new Point(pictureBox3.Location.X - 1, pictureBox3.Location.Y);
                    }
                    else if (pictureBox3.Location.X < Xint2)
                    {
                        pictureBox3.Location = new Point(pictureBox3.Location.X + 1, pictureBox3.Location.Y);
                    }

                    if (pictureBox3.Location.Y > Yint2)
                    {
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 1);
                    }
                    else if (pictureBox3.Location.Y < Yint2)
                    {
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 1);
                    }
                }
        }
    }
}
