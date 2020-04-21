using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }
        Random rnd;
        Thread TRed;
        Thread TGreen;
        private void button1_Click(object sender, EventArgs e)
        {
            TRed = new Thread(DrawRedRects);
            TRed.Start();
                
        }

        private void DrawRedRects()
        {
            Pen sPen = new Pen(Color.Red, 1);
            for (int i = 0; i < 25; i++)
            {

                CreateGraphics().DrawRectangle(sPen, new Rectangle(rnd.Next(0, this.Height), (rnd.Next(0, this.Width)), 10, 10));
                Thread.Sleep(125);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TGreen = new Thread(DrawGreenRects);
            TGreen.Start();
            
        }

        private void DrawGreenRects()
        {
            Pen sPen = new Pen(Color.Green, 1);
            for (int i = 0; i < 25; i++)
            {
                CreateGraphics().DrawRectangle(sPen, new Rectangle(rnd.Next(0, this.Height), (rnd.Next(0, this.Width)), 10, 10));
                Thread.Sleep(125);
            }
        }
    }
}
