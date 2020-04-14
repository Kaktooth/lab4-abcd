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
    public partial class Form3 : Form
    {
        private int x=20;
       string p="p";
        int c = 0;
        Bitmap p1= (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p1.jpg", true);//path from folder pigeon
        Bitmap p2 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p2.jpg", true);
        Bitmap p3 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p3.jpg", true);
        Bitmap p4 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p4.jpg", true);
        Bitmap p5 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p5.jpg", true);
        Bitmap p6 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p6.jpg", true);
        Bitmap p7 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p7.jpg", true);
        Bitmap p8 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p8.jpg", true);
        Bitmap p9 = (Bitmap)Image.FromFile(@"C:\Users\Xiaomi\source\repos\lab4\pigeon\p9.jpg", true);
        public Form3()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            if (c > 9)
            {
                c = 1;
            }
            c += 1;
            Invalidate();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            
            PointF point= new PointF(x, 10);
           
           if (c == 1)
            {
                e.Graphics.DrawImage(p1, point);
            }
           else if (c == 2)
            {
                e.Graphics.DrawImage(p2, point);
            }
           else if (c == 3)
            {
                e.Graphics.DrawImage(p3, point);
            }
           else if (c == 4)
            {
                e.Graphics.DrawImage(p4, point);
            }
           else if (c == 5)
            {
                e.Graphics.DrawImage(p5, point);
            }
           else if (c == 6)
            {
                e.Graphics.DrawImage(p6, point);
            }
           else if (c == 7)
            {
                e.Graphics.DrawImage(p7, point);
            }
           else if (c == 8)
            {
                e.Graphics.DrawImage(p8, point);
            }
           else if (c == 9)
            {
                e.Graphics.DrawImage(p9, point);
            }
            else if (c == 10)
            {
                e.Graphics.DrawImage(p9, point);
            }
        }

    }
}
