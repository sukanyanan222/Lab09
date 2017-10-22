using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen[] objPen = new Pen[11];
            for (int i = 0; i < 11; i++)
            {
                objPen[i] = new Pen(Color.Blue, 9);
            }
            objPen[0].EndCap = System.Drawing.Drawing2D.LineCap.AnchorMask;
            objPen[1].EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            objPen[2].EndCap = System.Drawing.Drawing2D.LineCap.Custom;
            objPen[3].EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            objPen[4].EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            objPen[5].EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            objPen[6].EndCap = System.Drawing.Drawing2D.LineCap.Round;
            objPen[7].EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            objPen[8].EndCap = System.Drawing.Drawing2D.LineCap.Square;
            objPen[9].EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            objPen[10].EndCap = System.Drawing.Drawing2D.LineCap.Triangle;

            for (int i = 0; i < 11; i++)
            {

                g.DrawLine(objPen[i], 10, 10 + 20 * i, 200, 10 + 20 * i);
                objPen[i].Dispose();
            }


        }
    }
}
