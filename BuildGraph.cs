using System.Drawing;
using System.Windows.Forms;

namespace GraphicDraw
{
    class BuildGraph
    {
        private double PointX {get;set;}
        private double PointY { get; set;}
        private int HeightPanel { get; set; }
        private int WidthPanel { get; set; }
        private int grids { get; set; }
        protected PictureBox panelGraph;
        protected Pen pen;
        protected Graphics graph;
        protected Bitmap bmp;

        public BuildGraph(int height , int width , PictureBox panelGraph , int grids)
        {
            HeightPanel = height;
            WidthPanel = width;
            this.panelGraph = panelGraph;
            this.grids = grids;
            BuildGrids();
            BuildCoordinatesLines();
            DisposeObject();
        }

       protected  void BuildGrids()
        {
            int scale =  HeightPanel /grids;
            pen = new Pen(Color.FromKnownColor(KnownColor.ControlDarkDark),1);
            bmp = new Bitmap(HeightPanel, WidthPanel);

            this.graph = Graphics.FromImage(bmp);
            for (int i = 0; i <= HeightPanel; i++)
            {
                graph.DrawLine(pen, new Point(0, i * scale), new Point(WidthPanel, i * scale));
            }
            
            for (int i = 0; i <= WidthPanel; i++)
            {
                graph.DrawLine(pen, new Point(i * scale, 0), new Point(i * scale, HeightPanel));
            }
            panelGraph.Image = bmp;
            
        }
        protected void BuildCoordinatesLines()
        {
            pen = new Pen(Color.Black, 3);
            //AXIS X
            graph.DrawLine(pen, new Point(25, panelGraph.Height / 2), new Point(panelGraph.Width-25, panelGraph.Height / 2));
            //AXIS Y
            graph.DrawLine(pen, new Point(panelGraph.Width / 2, 25), new Point(panelGraph.Width / 2, panelGraph.Height-25));
            
        }
        public void DisposeObject()
        {
            pen.Dispose();
            graph.Dispose();
        }
    }
}
