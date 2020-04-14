using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            Bitmap bm = new Bitmap(picture.Width,picture.Height);
            Graphics graph = Graphics.FromImage(bm);
            Pen pen = new Pen(Color.DarkRed);
            Point[] trianglepoints =
            {
                 new Point(10,  10),
                 new Point(10, 100),
                 new Point(100,  50),
                 new Point(10, 10)
             };
            Point[] triangle2points =
        {
                 new Point(10,  300),
                 new Point(60, 300),
                 new Point(40,  280),
                 new Point(10, 300)
             };
            SolidBrush Brush = new SolidBrush(Color.Coral);
            SolidBrush bBrush = new SolidBrush(Color.Brown);
            SolidBrush cBrush = new SolidBrush(Color.Cyan);
            graph.DrawLines(pen,trianglepoints);
            graph.DrawRectangle(pen, 122, 122, 122, 122);
            graph.DrawEllipse(pen,300,145,78,178);
            graph.DrawEllipse(pen, 300, 5, 50, 50);
            graph.FillEllipse(Brush, 300, 5, 50, 50);
            //house
            graph.DrawLines(pen, triangle2points);
            
            graph.DrawRectangle(pen, 10, 300, 50, 35);
            graph.FillRectangle(Brush, 10, 300, 50, 35);
            graph.DrawRectangle(pen, 15,315, 10, 20);
            graph.FillRectangle(bBrush, 15, 315, 10, 20);
            graph.DrawRectangle(pen, 35, 315, 10, 10);
            graph.FillRectangle(cBrush, 35, 315, 10, 10);
            picture.Image = bm;
           
        }
    }
}
