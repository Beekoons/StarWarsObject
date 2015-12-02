using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        public void ExhaustPort(float x, float y, float width, float height)
        {
            Pen expPen = new Pen(Color.White, 2);
            float xScale = width / 156;
            float yScale = height / 574;

            g.DrawLine(expPen, (41 * xScale) + x, (0 * yScale) + y, (41 * xScale) + x, (440 * yScale) + y);
            g.DrawLine(expPen, (113 * xScale) + x, (0 + yScale) + y, (113 * xScale) + x, (440 * yScale) + y);
            g.DrawArc(expPen, (5 * xScale) + x, (428 * yScale) + y, xScale*146, yScale*146, 300, 300);
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ExhaustPort(40, 0, 40, 100);
        }
    }
}
