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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.Coordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.pencil = new System.Windows.Forms.ToolStripButton();
            this.eraser = new System.Windows.Forms.ToolStripButton();
            this.brush = new System.Windows.Forms.ToolStripButton();
            this.fill = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.rectangle = new System.Windows.Forms.ToolStripButton();
            this.triangle = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.width = new System.Windows.Forms.ToolStripSplitButton();
            this.px1 = new System.Windows.Forms.ToolStripMenuItem();
            this.px2 = new System.Windows.Forms.ToolStripMenuItem();
            this.px3 = new System.Windows.Forms.ToolStripMenuItem();
            this.px4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.switcher = new System.Windows.Forms.ToolStripButton();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.currentColor = new System.Windows.Forms.ToolStripButton();
            this.sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.black = new System.Windows.Forms.ToolStripButton();
            this.grey = new System.Windows.Forms.ToolStripButton();
            this.brown = new System.Windows.Forms.ToolStripButton();
            this.red = new System.Windows.Forms.ToolStripButton();
            this.orange = new System.Windows.Forms.ToolStripButton();
            this.yellow = new System.Windows.Forms.ToolStripButton();
            this.green = new System.Windows.Forms.ToolStripButton();
            this.cyan = new System.Windows.Forms.ToolStripButton();
            this.blue = new System.Windows.Forms.ToolStripButton();
            this.magenta = new System.Windows.Forms.ToolStripButton();
            this.sep6 = new System.Windows.Forms.ToolStripSeparator();
            this.color_Dialog = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Coordinates});
            this.statusBar.Location = new System.Drawing.Point(0, 706);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1244, 25);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // Coordinates
            // 
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(32, 20);
            this.Coordinates.Text = "0, 0";
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mainToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1244, 28);
            this.menuBar.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileTool,
            this.openFileTool,
            this.saveFileTool});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileTool
            // 
            this.newFileTool.Name = "newFileTool";
            this.newFileTool.Size = new System.Drawing.Size(181, 26);
            this.newFileTool.Text = "New File";
            this.newFileTool.Click += new System.EventHandler(this.MenuClick);
            // 
            // openFileTool
            // 
            this.openFileTool.Name = "openFileTool";
            this.openFileTool.Size = new System.Drawing.Size(181, 26);
            this.openFileTool.Text = "Open File";
            this.openFileTool.Click += new System.EventHandler(this.MenuClick);
            // 
            // saveFileTool
            // 
            this.saveFileTool.Name = "saveFileTool";
            this.saveFileTool.Size = new System.Drawing.Size(181, 26);
            this.saveFileTool.Text = "Save File";
            this.saveFileTool.Click += new System.EventHandler(this.MenuClick);
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
            // tools
            // 
            this.tools.ImageScalingSize = new System.Drawing.Size(27, 27);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencil,
            this.eraser,
            this.brush,
            this.fill,
            this.sep1,
            this.line,
            this.ellipse,
            this.rectangle,
            this.triangle,
            this.sep2,
            this.width,
            this.sep3,
            this.switcher,
            this.sep4,
            this.currentColor,
            this.sep5,
            this.black,
            this.grey,
            this.brown,
            this.red,
            this.orange,
            this.yellow,
            this.green,
            this.cyan,
            this.blue,
            this.magenta,
            this.sep6,
            this.color_Dialog});
            this.tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tools.Location = new System.Drawing.Point(3, 28);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1241, 34);
            this.tools.TabIndex = 18;
            this.tools.Text = " q";
            // 
            // pencil
            // 
            this.pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencil.Name = "pencil";
            this.pencil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pencil.Size = new System.Drawing.Size(31, 31);
            this.pencil.Text = "Pencil";
            this.pencil.ToolTipText = "Pen";
            this.pencil.Click += new System.EventHandler(this.BtnClick);
            // 
            // eraser
            // 
            this.eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(31, 31);
            this.eraser.Text = "Eraser";
            this.eraser.ToolTipText = "Eraser";
            this.eraser.Click += new System.EventHandler(this.BtnClick);
            // 
            // brush
            // 
            this.brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brush.Image = ((System.Drawing.Image)(resources.GetObject("brush.Image")));
            this.brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(31, 31);
            this.brush.Text = "Brush";
            this.brush.ToolTipText = "Brush";
            this.brush.Click += new System.EventHandler(this.BtnClick);
            // 
            // fill
            // 
            this.fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fill.Image = ((System.Drawing.Image)(resources.GetObject("fill.Image")));
            this.fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(31, 31);
            this.fill.Text = "Fill";
            this.fill.Click += new System.EventHandler(this.BtnClick);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 34);
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(31, 31);
            this.line.Text = "Line";
            this.line.Click += new System.EventHandler(this.BtnClick);
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(31, 31);
            this.ellipse.Text = "Ellipse";
            this.ellipse.Click += new System.EventHandler(this.BtnClick);
            // 
            // rectangle
            // 
            this.rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(31, 31);
            this.rectangle.Text = "Rectangle";
            this.rectangle.Click += new System.EventHandler(this.BtnClick);
            // 
            // triangle
            // 
            this.triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(31, 31);
            this.triangle.Text = "Triangle";
            this.triangle.Click += new System.EventHandler(this.BtnClick);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 34);
            // 
            // width
            // 
            this.width.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.width.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.px1,
            this.px2,
            this.px3,
            this.px4});
            this.width.Image = ((System.Drawing.Image)(resources.GetObject("width.Image")));
            this.width.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(46, 31);
            this.width.Text = "WidthLine";
            // 
            // px1
            // 
            this.px1.Name = "px1";
            this.px1.Size = new System.Drawing.Size(108, 26);
            this.px1.Text = "1px";
            this.px1.Click += new System.EventHandler(this.WidthClick);
            // 
            // px2
            // 
            this.px2.Name = "px2";
            this.px2.Size = new System.Drawing.Size(108, 26);
            this.px2.Text = "2px";
            this.px2.Click += new System.EventHandler(this.WidthClick);
            // 
            // px3
            // 
            this.px3.Name = "px3";
            this.px3.Size = new System.Drawing.Size(108, 26);
            this.px3.Text = "3px";
            this.px3.Click += new System.EventHandler(this.WidthClick);
            // 
            // px4
            // 
            this.px4.Name = "px4";
            this.px4.Size = new System.Drawing.Size(108, 26);
            this.px4.Text = "4px";
            this.px4.Click += new System.EventHandler(this.WidthClick);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 34);
            // 
            // switcher
            // 
            this.switcher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.switcher.Image = ((System.Drawing.Image)(resources.GetObject("switcher.Image")));
            this.switcher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.switcher.Name = "switcher";
            this.switcher.Size = new System.Drawing.Size(47, 31);
            this.switcher.Text = "Edge";
            this.switcher.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switcher.Click += new System.EventHandler(this.Switcher);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(6, 34);
            // 
            // currentColor
            // 
            this.currentColor.AutoSize = false;
            this.currentColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.currentColor.Enabled = false;
            this.currentColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.currentColor.Name = "currentColor";
            this.currentColor.Size = new System.Drawing.Size(28, 28);
            this.currentColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sep5
            // 
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(6, 34);
            // 
            // black
            // 
            this.black.AutoSize = false;
            this.black.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.black.Image = ((System.Drawing.Image)(resources.GetObject("black.Image")));
            this.black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(31, 31);
            this.black.Text = "Black";
            this.black.Click += new System.EventHandler(this.ColorClick);
            // 
            // grey
            // 
            this.grey.AutoSize = false;
            this.grey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grey.Image = ((System.Drawing.Image)(resources.GetObject("grey.Image")));
            this.grey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(31, 31);
            this.grey.Text = "Grey";
            this.grey.Click += new System.EventHandler(this.ColorClick);
            // 
            // brown
            // 
            this.brown.AutoSize = false;
            this.brown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brown.Image = ((System.Drawing.Image)(resources.GetObject("brown.Image")));
            this.brown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(31, 31);
            this.brown.Text = "Brown";
            this.brown.Click += new System.EventHandler(this.ColorClick);
            // 
            // red
            // 
            this.red.AutoSize = false;
            this.red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(31, 31);
            this.red.Text = "Red";
            this.red.Click += new System.EventHandler(this.ColorClick);
            // 
            // orange
            // 
            this.orange.AutoSize = false;
            this.orange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orange.Image = ((System.Drawing.Image)(resources.GetObject("orange.Image")));
            this.orange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(31, 31);
            this.orange.Text = "Orange";
            this.orange.Click += new System.EventHandler(this.ColorClick);
            // 
            // yellow
            // 
            this.yellow.AutoSize = false;
            this.yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yellow.Image = ((System.Drawing.Image)(resources.GetObject("yellow.Image")));
            this.yellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(31, 31);
            this.yellow.Text = "Yellow";
            this.yellow.Click += new System.EventHandler(this.ColorClick);
            // 
            // green
            // 
            this.green.AutoSize = false;
            this.green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(31, 31);
            this.green.Text = "Green";
            this.green.Click += new System.EventHandler(this.ColorClick);
            // 
            // cyan
            // 
            this.cyan.AutoSize = false;
            this.cyan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cyan.Image = ((System.Drawing.Image)(resources.GetObject("cyan.Image")));
            this.cyan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(31, 31);
            this.cyan.Text = "Cyan";
            this.cyan.Click += new System.EventHandler(this.ColorClick);
            // 
            // blue
            // 
            this.blue.AutoSize = false;
            this.blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blue.Image = ((System.Drawing.Image)(resources.GetObject("blue.Image")));
            this.blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(31, 31);
            this.blue.Text = "Blue";
            this.blue.Click += new System.EventHandler(this.ColorClick);
            // 
            // magenta
            // 
            this.magenta.AutoSize = false;
            this.magenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.magenta.Image = ((System.Drawing.Image)(resources.GetObject("magenta.Image")));
            this.magenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.magenta.Name = "magenta";
            this.magenta.Size = new System.Drawing.Size(31, 31);
            this.magenta.Text = "Magenta";
            this.magenta.Click += new System.EventHandler(this.ColorClick);
            // 
            // sep6
            // 
            this.sep6.Name = "sep6";
            this.sep6.Size = new System.Drawing.Size(6, 34);
            // 
            // color_Dialog
            // 
            this.color_Dialog.Image = ((System.Drawing.Image)(resources.GetObject("color_Dialog.Image")));
            this.color_Dialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color_Dialog.Name = "color_Dialog";
            this.color_Dialog.Size = new System.Drawing.Size(121, 31);
            this.color_Dialog.Text = "ColorDialog";
            this.color_Dialog.Click += new System.EventHandler(this.BtnClick);
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
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            this.Picture.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "png";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 731);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Paint";
            this.Text = "Paint";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileTool;
        private System.Windows.Forms.ToolStripMenuItem openFileTool;
        private System.Windows.Forms.ToolStripMenuItem saveFileTool;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel Coordinates;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton pencil;
        private System.Windows.Forms.ToolStripButton eraser;
        private System.Windows.Forms.ToolStripButton brush;
        private System.Windows.Forms.ToolStripButton fill;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton line;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.ToolStripButton rectangle;
        private System.Windows.Forms.ToolStripButton triangle;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripButton currentColor;
        private System.Windows.Forms.ToolStripButton black;
        private System.Windows.Forms.ToolStripButton grey;
        private System.Windows.Forms.ToolStripButton brown;
        private System.Windows.Forms.ToolStripButton red;
        private System.Windows.Forms.ToolStripButton orange;
        private System.Windows.Forms.ToolStripButton yellow;
        private System.Windows.Forms.ToolStripButton green;
        private System.Windows.Forms.ToolStripButton cyan;
        private System.Windows.Forms.ToolStripButton blue;
        private System.Windows.Forms.ToolStripButton magenta;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripButton color_Dialog;
        private System.Windows.Forms.ToolStripSplitButton WidthLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator sep5;
        private System.Windows.Forms.ToolStripSplitButton width;
        private System.Windows.Forms.ToolStripMenuItem px1;
        private System.Windows.Forms.ToolStripMenuItem px2;
        private System.Windows.Forms.ToolStripMenuItem px3;
        private System.Windows.Forms.ToolStripMenuItem px4;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripButton switcher;
        private System.Windows.Forms.ToolStripSeparator sep6;
    }
}

