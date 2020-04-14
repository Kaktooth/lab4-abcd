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
    public partial class Form2 : Form
    {
        private int x;
        int rad=50;
        int cordx=20;
        int cordy=30;
        Random random = new Random();
        SolidBrush xbrush = new SolidBrush(Color.Black);
        public Form2()
        {
            InitializeComponent();
           
        }
     
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 550)
            {

                
                cordy = random.Next(300);
                x = 0;
                this.xbrush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                rad = random.Next(100);
               
            }
            x += 10;
            Invalidate();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.FillEllipse(xbrush, x, cordy, rad, rad);
        }
    }
}
