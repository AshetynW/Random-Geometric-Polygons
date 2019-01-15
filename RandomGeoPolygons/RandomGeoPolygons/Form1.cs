using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGeoPolygons
{
    public partial class Form1 : Form
    {
        public Graphics graphicsObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void SidesTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void VertecesTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void AreaTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void MakeBtn_Click(object sender, EventArgs e)
        {
            Shape newShape = new Shape();

            PointF[] Points = newShape.ShapeCreateVerteces(newShape.Verteces);

            Pen myPen = new Pen(Color.Red, 3);
            
            graphicsObj = this.CreateGraphics();

            graphicsObj.Clear(Color.LightGray);

            Point start = new Point();
            start.X = 210;
            start.Y = 210;

            PointF last = start;

            VertecesTxt.Text = newShape.Verteces.ToString();
            SidesTxt.Text = newShape.Sides.ToString();

            foreach (PointF p in Points)
            {                
                if(last == start)
                {
                    myPen.Color = Color.LightGray;
                }
                else
                {
                    if (RndmColorChkBx.Checked ==true)
                    {
                        myPen.Color = newShape.randomizeColor();
                    }
                    else
                    {
                        myPen.Color = Color.BlueViolet;
                    }
                }
                //MessageBox.Show("putting: " + start.X + "," + start.Y + " to " + p.X + "," + p.Y);
                System.Threading.Thread.Sleep(50);
                graphicsObj.DrawLine(myPen, last, p);
                last = p;
            }

            graphicsObj.DrawPolygon(myPen, Points);
            newShape = null;
            graphicsObj = null;
            myPen = null;
        }

        private void RndmColorChkBx_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    class Shape
    {
        public string Name { get; set; }
        public int Sides { get; set; }
        public int Verteces { get; set; }
        public int Area { get; set; }
        public int CenterX = 210;
        public int CenterY = 210;

        public Shape()
        {
            Random side = new Random();
            Sides = side.Next(3, 500);
            Verteces = Sides;

            Name = ShapeName(Sides);
            ShapeCreateVerteces(Verteces);
        }
        public string ShapeName(int sides)
        {
            string sidesNum = sides.ToString();
            string digits = sidesNum.Length.ToString();
            return null;
        }
        public PointF[] ShapeCreateVerteces(int numOfVerteces)
        {
            //20-403
            double X;
            double Y;
            
            double Angle = 360 / numOfVerteces;
            double AngleActual = 0;
            
            PointF point = new Point();
            PointF[] Points = new PointF[numOfVerteces];

            for (int i = 0; i < numOfVerteces; i++)
            {
                X = CenterX+180*Math.Cos(AngleActual); 
                Y = CenterY+180*Math.Sin(AngleActual);
                point.X = (int)X;
                point.Y = (int)Y;

                Points[i] = point;
                AngleActual += Angle;
            }
            return Points;
        }
        public Color randomizeColor()
        {
            Random ColorIndex = new Random();

            Color[] colors = new Color[] { Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Coral, Color.Crimson, Color.Cyan, Color.DarkGreen, Color.DeepPink, Color.Firebrick, Color.ForestGreen, Color.Fuchsia, Color.Gold, Color.Green, Color.HotPink, Color.Indigo, Color.Lavender, Color.LawnGreen, Color.LemonChiffon, Color.LimeGreen, Color.MediumVioletRed, Color.NavajoWhite, Color.Orange, Color.PaleVioletRed, Color.PowderBlue, Color.SeaGreen, Color.Turquoise, Color.Violet };
            return colors[ColorIndex.Next(0,colors.Length)];
        }
    }
}
