using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        private Color color = Color.Blue;
        int n;
        double leng;
        double th1;
        double th2;
        double per1;
        double per2;

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            int.TryParse(DepBox.Text, out int n);
            double.TryParse(LenBox.Text, out double leng);
            double.TryParse(Th1Box.Text, out double th1);
            double.TryParse(Th2Box.Text, out double th2);
            double.TryParse(P1Box.Text, out double per1);
            double.TryParse(P2Box.Text, out double per2);
            if (graphics == null) graphics = panel1.CreateGraphics();
            drawCayleyTree(n, panel1.Size.Width / 2, panel1.Size.Height, leng, -Math.PI / 2);
        }
        
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            color = dialog.Color;
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            Pen pen = new Pen(color,1);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
