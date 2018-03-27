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

    public partial class Paint : Form
    {
        PointF first = default(PointF);
        PointF second = default(PointF);
        Bitmap bm = default(Bitmap);
        Graphics g = default(Graphics);
        Pen pen = new Pen(Color.Black, 1);
        Pen white = new Pen(Color.White, 1);

        Tools current = global::Paint.Tools.Pen;

        public Paint()
        {
            InitializeComponent();

            SetupPictureBox(true, "");

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            first = e.Location;

            if(current == global::Paint.Tools.Fill)
            {

            }
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            Coordinates.Text = e.X + ", " + e.Y;

            if(e.Button == MouseButtons.Left)
            {
                second = e.Location;

                if(current == global::Paint.Tools.Pen)
                {
                    g.DrawLine(pen, first, second);
                    first = second;
                }
                else if(current == global::Paint.Tools.Eraser)
                {
                    g.DrawLine(white, first, second);
                    first = second;
                }
                else if(current == global::Paint.Tools.Brush)
                {
                    g.DrawLine(pen, first, second);
                    first = second;
                }

                Picture.Refresh();
            }
        }

        private void SetupPictureBox(bool isFirst, string fileName)
        {
            if (isFirst)
            {
                bm = new Bitmap(Picture.Width, Picture.Height);
            }
            else
            {
                bm = new Bitmap(Bitmap.FromFile(OpenFile.FileName));
            }

            g = Graphics.FromImage(bm);

            if (isFirst)
            {
                g.Clear(Color.White);
            }

            Picture.Image = bm;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


        }

        private void ColorClick(object sender, EventArgs e)
        {
            ToolStripButton b = sender as ToolStripButton;

            switch (b.Name)
            {
                case "Black":
                    pen.Color = Color.Black;
                    CurrentColor.BackColor = Color.Black;
                    break;
                case "Grey":
                    pen.Color = Color.Gray;
                    CurrentColor.BackColor = Color.Gray;
                    break;
                case "Brown":
                    pen.Color = Color.Brown;
                    CurrentColor.BackColor = Color.Brown;
                    break;
                case "Red":
                    pen.Color = Color.Red;
                    CurrentColor.BackColor = Color.Red;
                    break;
                case "Orange":
                    pen.Color = Color.Orange;
                    CurrentColor.BackColor = Color.Orange;
                    break;
                case "Yellow":
                    pen.Color = Color.Yellow;
                    CurrentColor.BackColor = Color.Yellow;
                    break;
                case "Green":
                    pen.Color = Color.Green;
                    CurrentColor.BackColor = Color.Green;
                    break;
                case "Cyan":
                    pen.Color = Color.LightBlue;
                    CurrentColor.BackColor = Color.LightBlue;
                    break;
                case "Blue":
                    pen.Color = Color.Blue;
                    CurrentColor.BackColor = Color.Blue;
                    break;
                case "Magenta":
                    pen.Color = Color.Magenta;
                    CurrentColor.BackColor = Color.Magenta;
                    break;
            }
 
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            switch (current)
            {
                case global::Paint.Tools.Rectangle:
                    e.Graphics.DrawRectangle(pen, Math.Min(first.X, second.X), Math.Min(first.Y, second.Y), Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));
                    break;
                case global::Paint.Tools.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle(first, second));
                    break;
                case global::Paint.Tools.Triangle:
                    e.Graphics.DrawPolygon(pen, GetPointsTriangle(first, second));
                    break;
                case global::Paint.Tools.Line:
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
                case global::Paint.Tools.Rectangle:
                    g.DrawRectangle(pen, Math.Min(first.X, second.X), Math.Min(first.Y, second.Y), Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));
                    break;
                case global::Paint.Tools.Ellipse:
                    g.DrawEllipse(pen, GetRectangle(first, second));
                    break;
                case global::Paint.Tools.Triangle:
                    g.DrawPolygon(pen, GetPointsTriangle(first, second));
                    break;
                case global::Paint.Tools.Line:
                    g.DrawLine(pen, first, second);
                    break;
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            ToolStripButton b = sender as ToolStripButton;

            switch (b.Name)
            {
                case "Pencil":
                    current = global::Paint.Tools.Pen;
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    break;
                case "Eraser":
                    current = global::Paint.Tools.Eraser;
                    break;
                case "Brush":
                    current = global::Paint.Tools.Brush;
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    break;
                case "Fill":
                    current = global::Paint.Tools.Fill;
                    break;
                case "Rectangle":
                    current = global::Paint.Tools.Rectangle;
                    break;
                case "Ellipse":
                    current = global::Paint.Tools.Ellipse;
                    break;
                case "Triangle":
                    current = global::Paint.Tools.Triangle;
                    break;
                case "Line":
                    current = global::Paint.Tools.Line;
                    break;
                case "Color_Dialog":
                    if (ColorDialog.ShowDialog() == DialogResult.OK)
                    {
                        pen.Color = ColorDialog.Color;
                        CurrentColor.BackColor = ColorDialog.Color;
                    }
                    break;
            }
        }

        private void MenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem b = sender as ToolStripMenuItem;

            switch (b.Name)
            {
                case "SaveFileTool":
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        Picture.Image.Save(SaveFile.FileName);
                    }
                    break;
                case "OpenFileTool":
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        SetupPictureBox(false, OpenFile.FileName);
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
