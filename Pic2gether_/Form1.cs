using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

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
        int x, y, sX, sY, cX, cY;
        Pen pencil = new Pen(Color.Black, 1);
        Brush pencilLIL = new SolidBrush(Color.Empty);
        Brush point = new SolidBrush(Color.Black);
        Pen erase = new Pen(Color.White, 30);
        Brush erase_pen = new SolidBrush(Color.White);


        private void ColorChange(object sender, EventArgs e)
        {
            if(ChColor.ShowDialog() == DialogResult.OK)  
            {
                Color color = ChColor.Color;
                BColore.BackColor = color;
                pencil.Color = color;
                point = new SolidBrush(Color.FromArgb(color.R, color.G, color.B));
            }

        }


        private void BColorLilChange(object sender, EventArgs e)
        {
            if (ChColor.ShowDialog() == DialogResult.OK)
            {
                Color color = ChColor.Color;
                BColorLil.BackColor = color;
                pencilLIL = new SolidBrush(Color.FromArgb(color.R,color.G,color.B));
            }
        }

        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            if (selectedState == "Прозрачность")
                pencilLIL = new SolidBrush(Color.Empty);
            if (selectedState == "Заливка") {
                Color color = ChColor.Color;
                BColorLil.BackColor = color;
                pencilLIL = new SolidBrush(Color.FromArgb(color.R, color.G, color.B));
                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox2.SelectedItem.ToString();
            selectedState = selectedState.Substring(0, selectedState.IndexOf(' '));
            int px = Convert.ToInt32(selectedState);
            pencil.Width = px;
            erase.Width = px;
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;

            sX = x - cX;
            sY = y - cY;

            if (index_Pen == 3)
            {
                g.DrawEllipse(pencil, cX, cY, sX, sY);
                g.FillEllipse(pencilLIL, cX, cY, sX, sY);
            }

            if (index_Pen == 4)
            {
                g.DrawEllipse(pencil, cX, cY, sX, sX);
                g.FillEllipse(pencilLIL, cX, cY, sX, sX);
            }

            if (index_Pen == 5)
            {
                g.DrawRectangle(pencil, cX, cY, sX, sX);
                g.FillRectangle(pencilLIL, cX, cY, sX, sX);
            }

            if (index_Pen == 6)
            {
                g.DrawRectangle(pencil, cX, cY, sX, sY);
                g.FillRectangle(pencilLIL, cX, cY, sX, sY);
            }

            if (index_Pen == 7)
            {
                g.DrawLine(pencil, cX, cY, x, y);
            }
        }

        private void BPen_Click(object sender, EventArgs e)
        {
            index_Pen = 1;
        }

        private void BErase_Click(object sender, EventArgs e)
        {
            index_Pen = 2;
        }
        private void bEllipse_Click(object sender, EventArgs e)
        {
            index_Pen = 3;
        }

        private void bCircle_Click(object sender, EventArgs e)
        {
            index_Pen = 4;
        }

        private void bSquare_Click(object sender, EventArgs e)
        {
            index_Pen = 5;
        }

        private void bRectangle_Click(object sender, EventArgs e)
        {
            index_Pen = 6;
        }
        private void bLine_Click(object sender, EventArgs e)
        {
            index_Pen = 7;
        }
        private void BFill_Click(object sender, EventArgs e)
        {
            index_Pen = 8;
        }

        private void Canva_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(isMouse)
            {
                if (index_Pen == 3)
                {
                    g.DrawEllipse(pencil, cX, cY, sX, sY);
                    g.FillEllipse(pencilLIL, cX, cY, sX, sY);
                }

                if (index_Pen == 4)
                {
                    g.DrawEllipse(pencil, cX, cY, sX, sX);
                    g.FillEllipse(pencilLIL, cX, cY, sX, sX);
                }

                if (index_Pen == 5)
                {
                    g.DrawRectangle(pencil, cX, cY, sX, sX);
                    g.FillRectangle(pencilLIL, cX, cY, sX, sX);
                }

                if (index_Pen == 6)
                {
                    g.DrawRectangle(pencil, cX, cY, sX, sY);
                    g.FillRectangle(pencilLIL, cX, cY, sX, sY);
                }

                if (index_Pen == 7)
                {
                    g.DrawLine(pencil, cX, cY, x, y);
                }
            }

        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_c, Color new_c)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_c)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_c);
            }    
        }

        public void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);

            if (old_color == new_color) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y<bm.Height-1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_color);

                }
            }
        }


        static Point set_point (PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY)); 
        }

        private void Canva_MouseClick(object sender, MouseEventArgs e)
        {
            if (index_Pen == 8)
            {
                Point point = set_point(Canva, e.Location);
                Fill(bm, point.X, point.Y, BColorLil.BackColor);
            }
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouse)
            {

                if (index_Pen == 1)
                {
                    px = e.Location;
                    if (pencil.Width < 5)
                    {
                        g.DrawLine(pencil, px, py);
                        py = px;
                    }
                    else
                        g.FillEllipse(point, px.X-pencil.Width/2, px.Y-pencil.Width/2, pencil.Width, pencil.Width);
                }
                if (index_Pen == 2)
                {
                    px = e.Location;
                    if (erase.Width < 5)
                    {
                        g.DrawLine(erase, px, py);
                        py = px;
                    }
                    else
                        g.FillEllipse(erase_pen, px.X - pencil.Width / 2, px.Y - pencil.Width / 2, pencil.Width, pencil.Width);
                }

            }
            Canva.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X-cX;
            sY = e.Y-cY;


           }

        private void bClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Canva.Image = bm;
            index_Pen = 0;
        }


        private void bSave_Click(object sender, EventArgs e)
        {

            Bitmap pngSave = (Bitmap)Canva.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "png";
            sfd.FileName = "Picture.png";
            sfd.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                pngSave.Save(sfd.FileName);
        }


    }
}
