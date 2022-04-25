using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic2gether_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Canva.Width, Canva.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Canva.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        private bool isMouse = false;
        Point px, py;
        int index_Pen;
        Pen pencil = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 30);

        private void ColorChange(object sender, EventArgs e)
        {
            if(ChColor.ShowDialog() == DialogResult.OK)  
            {
                Color color = ChColor.Color;
                BColore.BackColor = color;
                pencil.Color = color;
            }

        }
        private void BColorLilChange(object sender, EventArgs e)
        {
            if (ChColor.ShowDialog() == DialogResult.OK)
            {
                Color color = ChColor.Color;
                BColorLil.BackColor = color;
                pencil.Color = color;
            }
        }

        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            py = e.Location;
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
        }

        private void BPen_Click(object sender, EventArgs e)
        {
                index_Pen = 1;
        }

        private void BErase_Click(object sender, EventArgs e)
        {
            index_Pen = 2;
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouse)
            {
                if (index_Pen == 1)
                {
                    px = e.Location;
                    g.DrawLine(pencil, px, py);
                    py = px;
                }
                if (index_Pen == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;

                    
                }
            }
            Canva.Refresh();

        }
    }
}
