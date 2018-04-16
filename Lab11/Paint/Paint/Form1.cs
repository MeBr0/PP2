using PaintApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    enum Tools
    {
        Pen,
        Fill,
        Rectangle,
        Ellipse,
        Triangle,
        Line,
        Eraser,
        Brush
    }

    enum BmpCreationMode
    {
        Fill,
        File,
        Init
    }

    enum FillMode
    {
        edge,
        fill
    }

    public partial class Paint : Form
    {
        Point first = default(Point);
        Point second = default(Point);
        Bitmap bm = default(Bitmap);
        Graphics g = default(Graphics);
        Pen pen = new Pen(Color.Black, 1);
        Pen white = new Pen(Color.White, 1);

        Tools current = Tools.Pen;
        FillMode fillMode = FillMode.edge;

        public Paint()
        {
            InitializeComponent();

            SetupPictureBox(BmpCreationMode.Init, "");

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            first = e.Location;
            second = first;

            if (current == Tools.Fill)
            {
                MapFill mf = new MapFill();
                mf.Fill(g, first, pen.Color, ref bm);
                SetupPictureBox(BmpCreationMode.Fill, "");
            }
        }

        private void Switcher(object sender, EventArgs e)
        {
            if (fillMode == FillMode.edge)
            {
                fillMode = FillMode.fill;
                switcher.Text = "Fill";
            }

            else
            {
                fillMode = FillMode.edge;
                switcher.Text = "Edge";
            }
        }

        private void SetupPictureBox(BmpCreationMode mode, string fileName)
        {

            if (mode == BmpCreationMode.Init)
            {
                bm = new Bitmap(Picture.Width, Picture.Height);
            }
            else if (mode == BmpCreationMode.File)
            {
                bm = new Bitmap(Bitmap.FromFile(fileName));
            }

            g = Graphics.FromImage(bm);

            if (mode == BmpCreationMode.Init)
            {
                g.Clear(Color.White);
            }

            Picture.Image = bm;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            Coordinates.Text = e.X + ", " + e.Y;

            if(e.Button == MouseButtons.Left)
            {
                second = e.Location;

                if(current == Tools.Pen)
                {
                    g.DrawLine(pen, first, second);
                    first = second;
                }
                else if(current == Tools.Eraser)
                {
                    g.DrawLine(white, first, second);
                    first = second;
                }
                else if(current == Tools.Brush)
                {
                    g.DrawLine(pen, first, second);
                    first = second;
                }

                Picture.Refresh();
            }
        }

        private void ColorClick(object sender, EventArgs e)
        {
            ToolStripButton b = sender as ToolStripButton;

            switch (b.Name)
            {
                case "black":
                    pen.Color = Color.Black;
                    currentColor.BackColor = Color.Black;
                    break;
                case "grey":
                    pen.Color = Color.Gray;
                    currentColor.BackColor = Color.Gray;
                    break;
                case "brown":
                    pen.Color = Color.Brown;
                    currentColor.BackColor = Color.Brown;
                    break;
                case "red":
                    pen.Color = Color.Red;
                    currentColor.BackColor = Color.Red;
                    break;
                case "orange":
                    pen.Color = Color.Orange;
                    currentColor.BackColor = Color.Orange;
                    break;
                case "yellow":
                    pen.Color = Color.Yellow;
                    currentColor.BackColor = Color.Yellow;
                    break;
                case "green":
                    pen.Color = Color.Green;
                    currentColor.BackColor = Color.Green;
                    break;
                case "cyan":
                    pen.Color = Color.LightBlue;
                    currentColor.BackColor = Color.LightBlue;
                    break;
                case "blue":
                    pen.Color = Color.Blue;
                    currentColor.BackColor = Color.Blue;
                    break;
                case "magenta":
                    pen.Color = Color.Magenta;
                    currentColor.BackColor = Color.Magenta;
                    break;
            }
 
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            switch (current)
            {
                case Tools.Rectangle:
                    if (fillMode == FillMode.edge)
                        e.Graphics.DrawRectangle(pen, Math.Min(first.X, second.X), Math.Min(first.Y, second.Y), Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));

                    else
                        e.Graphics.FillRectangle(pen.Brush, Math.Min(first.X, second.X), Math.Min(first.Y, second.Y), Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));
                    break;
                case Tools.Ellipse:
                    if (fillMode == FillMode.edge)
                        e.Graphics.DrawEllipse(pen, GetRectangle(first, second));

                    else
                        e.Graphics.FillEllipse(pen.Brush, GetRectangle(first, second));
                    break;
                case Tools.Triangle:
                    if (fillMode == FillMode.edge)
                        e.Graphics.DrawPolygon(pen, GetPointsTriangle(first, second));

                    else
                        e.Graphics.FillPolygon(pen.Brush, GetPointsTriangle(first, second));
                    break;
                case Tools.Line:
                    e.Graphics.DrawLine(pen, first, second);
                    break;
            }
        }

        private RectangleF GetRectangle(PointF a, PointF b) =>
            new RectangleF(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y), Math.Abs(a.X - b.X), Math.Abs(a.Y - b.Y));

        private PointF[] GetPointsRectangle(PointF a, PointF b)
        {
            PointF[] X = { new PointF(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y)),
            new PointF(Math.Max(a.X, b.X), Math.Min(a.Y, b.Y)),
            new PointF(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y)),
            new PointF(Math.Min(a.X, b.X), Math.Max(a.Y, b.Y))};

            return X;
        }

        private PointF[] GetPointsTriangle(PointF a, PointF b)
        {
            PointF[] X = { new PointF(Math.Min(a.X, b.X), Math.Max(a.Y, b.Y)),
            new PointF(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y)),
            new PointF(Math.Abs((a.X + b.X)/2), Math.Min(a.Y, b.Y))};

            return X;
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            switch (current)
            {
                case Tools.Rectangle:
                    if (fillMode == FillMode.edge)
                        g.DrawRectangle(pen, Math.Min(first.X, second.X), Math.Min(first.Y, second.Y), Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));

                    else
                        g.FillRectangle(pen.Brush, Math.Min(first.X, second.X), Math.Min(first.Y, second.Y), Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));
                    break;
                case Tools.Ellipse:
                    if (fillMode == FillMode.edge)
                        g.DrawEllipse(pen, GetRectangle(first, second));

                    else
                        g.FillEllipse(pen.Brush, GetRectangle(first, second));
                    break;
                case Tools.Triangle:
                    if (fillMode == FillMode.edge)
                        g.DrawPolygon(pen, GetPointsTriangle(first, second));

                    else
                        g.FillPolygon(pen.Brush, GetPointsTriangle(first, second));
                    break;
                case Tools.Line:
                    g.DrawLine(pen, first, second);
                    break;
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            ToolStripButton b = sender as ToolStripButton;

            switch (b.Name)
            {
                case "pencil":
                    current = Tools.Pen;
                    break;
                case "eraser":
                    current = Tools.Eraser;
                    break;
                case "brush":
                    current = Tools.Brush;
                    break;
                case "fill":
                    current = Tools.Fill;
                    break;
                case "rectangle":
                    current = Tools.Rectangle;
                    break;
                case "ellipse":
                    current = Tools.Ellipse;
                    break;
                case "triangle":
                    current = Tools.Triangle;
                    break;
                case "line":
                    current = Tools.Line;
                    break;
                case "color_Dialog":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        pen.Color = colorDialog.Color;
                        currentColor.BackColor = colorDialog.Color;
                    }
                    break;
            }
        }

        private void MenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem b = sender as ToolStripMenuItem;

            switch (b.Name)
            {
                case "newFileTool":
                    SetupPictureBox(BmpCreationMode.Init, "");
                    break;
                case "saveFileTool":
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        Picture.Image.Save(saveFile.FileName);
                    }
                    break;
                case "openFileTool":
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        SetupPictureBox(BmpCreationMode.File, openFile.FileName);
                    }
                    break;
            }
        }

        private void WidthClick(object sender, EventArgs e)
        {
            ToolStripMenuItem b = sender as ToolStripMenuItem;

            switch (b.Name)
            {
                case "px1":
                    pen.Width = 1;
                    white.Width = 1;
                    break;
                case "px2":
                    pen.Width = 2;
                    white.Width = 2;
                    break;
                case "px3":
                    pen.Width = 3;
                    white.Width = 3;
                    break;
                case "px4":
                    pen.Width = 4;
                    white.Width = 4;
                    break;
            }
        }
    }
}
