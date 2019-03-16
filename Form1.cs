using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicDraw
{
    public partial class Form1 : Form
    {
        private int BeginInterval=0;
        private int EndInterval=0;
        private string Funcion;
        public Form1(string funcion)
        {
            InitializeComponent();

            Funcion = funcion;           
            Draws();
            // labelEquation.Text = $"{BeginInterval},{EndInterval},{Funcion}";
            
            

        }
           

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //// Draw the points.
            foreach (Point point in Points)
                e.Graphics.FillEllipse(Brushes.Black,
                    point.X - 3, point.Y - 3, 0, 0);
            if (Points.Count < 2) return;

            // Draw the curve.
            e.Graphics.DrawCurve(Pens.Blue, Points.ToArray());
            
        }
        private List<Point> Points = new List<Point>();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Points.Add(e.Location);
            Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();
        
        

        public void Draws()
        {
            
           BuildGraph buildGraph = new BuildGraph(pictureBox1.Height, pictureBox1.Width, pictureBox1, 26);
           EquationConvert equationConvert = new EquationConvert(Funcion);
            List<string> ter = equationConvert.GetArrayEquationConvert();
           labelEquation.Text = string.Join(":",ter);

        }
        
    }
    
}
