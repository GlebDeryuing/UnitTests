using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Line line = new Line(double.Parse(A1t.Text), double.Parse(A2t.Text), double.Parse(B1t.Text), double.Parse(B2t.Text));
            PointF F = new PointF(float.Parse(A3t.Text), float.Parse(B3t.Text));
            Distlabel.Text = line.Distance(F).ToString();
        }

        private void rectbutton_Click(object sender, EventArgs e)
        {
            Rect line = new Rect(double.Parse(A1t.Text), double.Parse(A2t.Text), double.Parse(B1t.Text), double.Parse(B2t.Text));
            PointF F = new PointF(float.Parse(A3t.Text), float.Parse(B3t.Text));
            Distlabel.Text = line.Distance(F).ToString();
        }
    }
}
