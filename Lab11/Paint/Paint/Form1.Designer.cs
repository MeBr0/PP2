namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Coordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.Pencil = new System.Windows.Forms.ToolStripButton();
            this.Eraser = new System.Windows.Forms.ToolStripButton();
            this.Brush = new System.Windows.Forms.ToolStripButton();
            this.Fill = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Triangle = new System.Windows.Forms.ToolStripButton();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.Width = new System.Windows.Forms.ToolStripSplitButton();
            this.px1 = new System.Windows.Forms.ToolStripMenuItem();
            this.px2 = new System.Windows.Forms.ToolStripMenuItem();
            this.px3 = new System.Windows.Forms.ToolStripMenuItem();
            this.px4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.CurrentColor = new System.Windows.Forms.ToolStripButton();
            this.Sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.Black = new System.Windows.Forms.ToolStripButton();
            this.Grey = new System.Windows.Forms.ToolStripButton();
            this.Brown = new System.Windows.Forms.ToolStripButton();
            this.Red = new System.Windows.Forms.ToolStripButton();
            this.Orange = new System.Windows.Forms.ToolStripButton();
            this.Yellow = new System.Windows.Forms.ToolStripButton();
            this.Green = new System.Windows.Forms.ToolStripButton();
            this.Cyan = new System.Windows.Forms.ToolStripButton();
            this.Blue = new System.Windows.Forms.ToolStripButton();
            this.Magenta = new System.Windows.Forms.ToolStripButton();
            this.Sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.Color_Dialog = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.StatusBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Coordinates});
            this.StatusBar.Location = new System.Drawing.Point(0, 706);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1244, 25);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // Coordinates
            // 
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(32, 20);
            this.Coordinates.Text = "0, 0";
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mainToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1244, 28);
            this.MenuBar.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileTool,
            this.OpenFileTool,
            this.SaveFileTool});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewFileTool
            // 
            this.NewFileTool.Name = "NewFileTool";
            this.NewFileTool.Size = new System.Drawing.Size(181, 26);
            this.NewFileTool.Text = "New File";
            this.NewFileTool.Click += new System.EventHandler(this.MenuClick);
            // 
            // OpenFileTool
            // 
            this.OpenFileTool.Name = "OpenFileTool";
            this.OpenFileTool.Size = new System.Drawing.Size(181, 26);
            this.OpenFileTool.Text = "Open File";
            this.OpenFileTool.Click += new System.EventHandler(this.MenuClick);
            // 
            // SaveFileTool
            // 
            this.SaveFileTool.Name = "SaveFileTool";
            this.SaveFileTool.Size = new System.Drawing.Size(181, 26);
            this.SaveFileTool.Text = "Save File";
            this.SaveFileTool.Click += new System.EventHandler(this.MenuClick);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 678);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // Tools
            // 
            this.Tools.ImageScalingSize = new System.Drawing.Size(27, 27);
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pencil,
            this.Eraser,
            this.Brush,
            this.Fill,
            this.Sep1,
            this.Line,
            this.Ellipse,
            this.Rectangle,
            this.Triangle,
            this.Sep2,
            this.Width,
            this.Sep3,
            this.CurrentColor,
            this.Sep4,
            this.Black,
            this.Grey,
            this.Brown,
            this.Red,
            this.Orange,
            this.Yellow,
            this.Green,
            this.Cyan,
            this.Blue,
            this.Magenta,
            this.Sep5,
            this.Color_Dialog});
            this.Tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Tools.Location = new System.Drawing.Point(3, 28);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(1241, 34);
            this.Tools.TabIndex = 18;
            this.Tools.Text = " q";
            // 
            // Pencil
            // 
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil.Name = "Pencil";
            this.Pencil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pencil.Size = new System.Drawing.Size(31, 31);
            this.Pencil.Text = "Pencil";
            this.Pencil.ToolTipText = "Pen";
            this.Pencil.Click += new System.EventHandler(this.BtnClick);
            // 
            // Eraser
            // 
            this.Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(31, 31);
            this.Eraser.Text = "Eraser";
            this.Eraser.ToolTipText = "Eraser";
            this.Eraser.Click += new System.EventHandler(this.BtnClick);
            // 
            // Brush
            // 
            this.Brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Brush.Image = ((System.Drawing.Image)(resources.GetObject("Brush.Image")));
            this.Brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(31, 31);
            this.Brush.Text = "Brush";
            this.Brush.ToolTipText = "Brush";
            this.Brush.Click += new System.EventHandler(this.BtnClick);
            // 
            // Fill
            // 
            this.Fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(31, 31);
            this.Fill.Text = "Fill";
            this.Fill.Click += new System.EventHandler(this.BtnClick);
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 34);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(31, 31);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.BtnClick);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(31, 31);
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.Click += new System.EventHandler(this.BtnClick);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(31, 31);
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.BtnClick);
            // 
            // Triangle
            // 
            this.Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(31, 31);
            this.Triangle.Text = "Triangle";
            this.Triangle.Click += new System.EventHandler(this.BtnClick);
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Size = new System.Drawing.Size(6, 34);
            // 
            // Width
            // 
            this.Width.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Width.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.px1,
            this.px2,
            this.px3,
            this.px4});
            this.Width.Image = ((System.Drawing.Image)(resources.GetObject("Width.Image")));
            this.Width.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(46, 31);
            this.Width.Text = "WidthLine";
            // 
            // px1
            // 
            this.px1.Name = "px1";
            this.px1.Size = new System.Drawing.Size(181, 26);
            this.px1.Text = "1px";
            this.px1.Click += new System.EventHandler(this.WidthClick);
            // 
            // px2
            // 
            this.px2.Name = "px2";
            this.px2.Size = new System.Drawing.Size(181, 26);
            this.px2.Text = "2px";
            this.px2.Click += new System.EventHandler(this.WidthClick);
            // 
            // px3
            // 
            this.px3.Name = "px3";
            this.px3.Size = new System.Drawing.Size(181, 26);
            this.px3.Text = "3px";
            this.px3.Click += new System.EventHandler(this.WidthClick);
            // 
            // px4
            // 
            this.px4.Name = "px4";
            this.px4.Size = new System.Drawing.Size(181, 26);
            this.px4.Text = "4px";
            this.px4.Click += new System.EventHandler(this.WidthClick);
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Size = new System.Drawing.Size(6, 34);
            // 
            // CurrentColor
            // 
            this.CurrentColor.AutoSize = false;
            this.CurrentColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrentColor.Enabled = false;
            this.CurrentColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(28, 28);
            this.CurrentColor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Sep4
            // 
            this.Sep4.Name = "Sep4";
            this.Sep4.Size = new System.Drawing.Size(6, 34);
            // 
            // Black
            // 
            this.Black.AutoSize = false;
            this.Black.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Black.Image = ((System.Drawing.Image)(resources.GetObject("Black.Image")));
            this.Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(31, 31);
            this.Black.Text = "Black";
            this.Black.Click += new System.EventHandler(this.ColorClick);
            // 
            // Grey
            // 
            this.Grey.AutoSize = false;
            this.Grey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Grey.Image = ((System.Drawing.Image)(resources.GetObject("Grey.Image")));
            this.Grey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(31, 31);
            this.Grey.Text = "Grey";
            this.Grey.Click += new System.EventHandler(this.ColorClick);
            // 
            // Brown
            // 
            this.Brown.AutoSize = false;
            this.Brown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Brown.Image = ((System.Drawing.Image)(resources.GetObject("Brown.Image")));
            this.Brown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(31, 31);
            this.Brown.Text = "Brown";
            this.Brown.Click += new System.EventHandler(this.ColorClick);
            // 
            // Red
            // 
            this.Red.AutoSize = false;
            this.Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(31, 31);
            this.Red.Text = "Red";
            this.Red.Click += new System.EventHandler(this.ColorClick);
            // 
            // Orange
            // 
            this.Orange.AutoSize = false;
            this.Orange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Orange.Image = ((System.Drawing.Image)(resources.GetObject("Orange.Image")));
            this.Orange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(31, 31);
            this.Orange.Text = "Orange";
            this.Orange.Click += new System.EventHandler(this.ColorClick);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = false;
            this.Yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Yellow.Image = ((System.Drawing.Image)(resources.GetObject("Yellow.Image")));
            this.Yellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(31, 31);
            this.Yellow.Text = "Yellow";
            this.Yellow.Click += new System.EventHandler(this.ColorClick);
            // 
            // Green
            // 
            this.Green.AutoSize = false;
            this.Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(31, 31);
            this.Green.Text = "Green";
            this.Green.Click += new System.EventHandler(this.ColorClick);
            // 
            // Cyan
            // 
            this.Cyan.AutoSize = false;
            this.Cyan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cyan.Image = ((System.Drawing.Image)(resources.GetObject("Cyan.Image")));
            this.Cyan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(31, 31);
            this.Cyan.Text = "Cyan";
            this.Cyan.Click += new System.EventHandler(this.ColorClick);
            // 
            // Blue
            // 
            this.Blue.AutoSize = false;
            this.Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Blue.Image = ((System.Drawing.Image)(resources.GetObject("Blue.Image")));
            this.Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(31, 31);
            this.Blue.Text = "Blue";
            this.Blue.Click += new System.EventHandler(this.ColorClick);
            // 
            // Magenta
            // 
            this.Magenta.AutoSize = false;
            this.Magenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Magenta.Image = ((System.Drawing.Image)(resources.GetObject("Magenta.Image")));
            this.Magenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(31, 31);
            this.Magenta.Text = "Magenta";
            this.Magenta.Click += new System.EventHandler(this.ColorClick);
            // 
            // Sep5
            // 
            this.Sep5.Name = "Sep5";
            this.Sep5.Size = new System.Drawing.Size(6, 34);
            // 
            // Color_Dialog
            // 
            this.Color_Dialog.Image = ((System.Drawing.Image)(resources.GetObject("Color_Dialog.Image")));
            this.Color_Dialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color_Dialog.Name = "Color_Dialog";
            this.Color_Dialog.Size = new System.Drawing.Size(121, 31);
            this.Color_Dialog.Text = "ColorDialog";
            this.Color_Dialog.Click += new System.EventHandler(this.BtnClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem1.Text = "1px";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.pxToolStripMenuItem.Text = "2px";
            // 
            // pxToolStripMenuItem1
            // 
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Size = new System.Drawing.Size(108, 26);
            this.pxToolStripMenuItem1.Text = "3px";
            // 
            // pxToolStripMenuItem2
            // 
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Size = new System.Drawing.Size(108, 26);
            this.pxToolStripMenuItem2.Text = "4px";
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.Location = new System.Drawing.Point(5, 65);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1239, 638);
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            this.Picture.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 731);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Paint";
            this.Text = "Paint";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFileTool;
        private System.Windows.Forms.ToolStripMenuItem OpenFileTool;
        private System.Windows.Forms.ToolStripMenuItem SaveFileTool;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel Coordinates;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.ToolStripButton Eraser;
        private System.Windows.Forms.ToolStripButton Brush;
        private System.Windows.Forms.ToolStripButton Fill;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Triangle;
        private System.Windows.Forms.ToolStripSeparator Sep2;
        private System.Windows.Forms.ToolStripSeparator Sep3;
        private System.Windows.Forms.ToolStripButton CurrentColor;
        private System.Windows.Forms.ToolStripButton Black;
        private System.Windows.Forms.ToolStripButton Grey;
        private System.Windows.Forms.ToolStripButton Brown;
        private System.Windows.Forms.ToolStripButton Red;
        private System.Windows.Forms.ToolStripButton Orange;
        private System.Windows.Forms.ToolStripButton Yellow;
        private System.Windows.Forms.ToolStripButton Green;
        private System.Windows.Forms.ToolStripButton Cyan;
        private System.Windows.Forms.ToolStripButton Blue;
        private System.Windows.Forms.ToolStripButton Magenta;
        private System.Windows.Forms.ToolStripSeparator Sep4;
        private System.Windows.Forms.ToolStripButton Color_Dialog;
        private System.Windows.Forms.ToolStripSplitButton WidthLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator Sep5;
        private System.Windows.Forms.ToolStripSplitButton Width;
        private System.Windows.Forms.ToolStripMenuItem px1;
        private System.Windows.Forms.ToolStripMenuItem px2;
        private System.Windows.Forms.ToolStripMenuItem px3;
        private System.Windows.Forms.ToolStripMenuItem px4;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

