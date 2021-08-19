using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 그러데이션_그리기
{
    public partial class Form1 : Form
    {
        public int x, y;
        public int nBright = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen mypen = new Pen(Color.FromArgb(nBright, 100, 100, 100), 0.1f);
            for (y=0; y < pictureBox1.Height; y +=3 )
            {
                for (x=0; x< pictureBox1.Width; x++)
                {
                    g.DrawLine(mypen,x, y,x + 1, y + 1);
                }
            }
            pictureBox1.Invalidate();
        }
    }
}
