namespace BattleShip
{
    partial class main
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchPanel = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.switcherText = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Location = new System.Drawing.Point(30, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 370);
            this.mainPanel.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(840, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.StartGame);
            // 
            // switchPanel
            // 
            this.switchPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.switchPanel.Location = new System.Drawing.Point(455, 60);
            this.switchPanel.Name = "switchPanel";
            this.switchPanel.Size = new System.Drawing.Size(40, 37);
            this.switchPanel.TabIndex = 2;
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameStatus,
            this.switcherText});
            this.status.Location = new System.Drawing.Point(0, 481);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(840, 25);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // switcherText
            // 
            this.switcherText.Name = "switcherText";
            this.switcherText.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.switcherText.Size = new System.Drawing.Size(214, 20);
            this.switcherText.Text = "Ship Direction: Up-to-Down";
            // 
            // gameStatus
            // 
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.gameStatus.Size = new System.Drawing.Size(197, 20);
            this.gameStatus.Text = "GameMode: Construction";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 506);
            this.Controls.Add(this.status);
            this.Controls.Add(this.switchPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menu);
            this.Name = "main";
            this.Text = "BattleShip";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.Panel switchPanel;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel gameStatus;
        private System.Windows.Forms.ToolStripStatusLabel switcherText;
    }
}

