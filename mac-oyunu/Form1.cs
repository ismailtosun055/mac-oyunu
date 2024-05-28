using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mac_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele=new Random();
        int bjk, gs, fb, ts,gspuan=0,fbpuan=0,bjkpuan=0,tspuan=0;
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text= rastgele.Next(0,4).ToString();
            label7.Text = rastgele.Next(0, 4).ToString();
            label6.Text = rastgele.Next(0, 4).ToString();
            label8.Text = rastgele.Next(0, 4).ToString();
            button1.Enabled=false;
            gs = Convert.ToInt32(label5);
            fb = Convert.ToInt32(label7);
            bjk = Convert.ToInt32(label6);
            ts = Convert.ToInt32(label8);
            if (gs > fb)
            {
                gspuan = gspuan+3;
            }
            else if (fb > gs)
            {
                fbpuan = fbpuan+3;
            }
            else if (ts > bjk)
            {
                tspuan = tspuan+3;
            }
            else if (bjk > ts)
            {
                bjkpuan =bjkpuan+ 3;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = rastgele.Next(0, 4).ToString();
            label10.Text = rastgele.Next(0, 4).ToString();
            label11.Text = rastgele.Next(0, 4).ToString();
            label14.Text = rastgele.Next(0, 4).ToString();
            button2.Enabled = false;
            gs = Convert.ToInt32(label9);
            fb = Convert.ToInt32(label10);
            bjk = Convert.ToInt32(label11);
            ts = Convert.ToInt32(label14);
            if (gs > fb)
            {
                gspuan = gspuan + 3;
            }
            else if (fb > gs)
            {
                fbpuan = fbpuan + 3;
            }
            else if (ts > bjk)
            {
                tspuan = tspuan + 3;
            }
            else if (bjk > ts)
            {
                bjkpuan = bjkpuan + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label25.Text = rastgele.Next(0, 4).ToString();
            label26.Text = rastgele.Next(0, 4).ToString();
            label27.Text = rastgele.Next(0, 4).ToString();
            label30.Text = rastgele.Next(0, 4).ToString();
            button4.Enabled = false;
            gs = Convert.ToInt32(label25);
            fb = Convert.ToInt32(label26);
            bjk = Convert.ToInt32(label27);
            ts = Convert.ToInt32(label30);
            if (gs > fb)
            {
                gspuan = gspuan + 3;
            }
            else if (fb > gs)
            {
                fbpuan = fbpuan + 3;
            }
            else if (ts > bjk)
            {
                tspuan = tspuan + 3;
            }
            else if (bjk > ts)
            {
                bjkpuan = bjkpuan + 3;
            }
            else if (gspuan>fbpuan && gspuan > bjkpuan && gspuan > tspuan)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\ismai\\OneDrive\\Masaüstü\\kodlar\\C#\\form dersleri\\takımlar\\gs.png");
            }
            else if (fbpuan > gspuan && fbpuan > bjkpuan && fbpuan > tspuan)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\ismai\\OneDrive\\Masaüstü\\kodlar\\C#\\form dersleri\\takımlar\\fb.png");
            }
            else if (bjkpuan > gspuan && bjkpuan > fbpuan && bjkpuan > tspuan)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\ismai\\OneDrive\\Masaüstü\\kodlar\\C#\\form dersleri\\takımlar\\bj.png");
            }
            else if (tspuan > gspuan && tspuan > fbpuan && tspuan > bjkpuan)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\ismai\\OneDrive\\Masaüstü\\kodlar\\C#\\form dersleri\\takımlar\\ts.png");
            }
        }
    }
}
