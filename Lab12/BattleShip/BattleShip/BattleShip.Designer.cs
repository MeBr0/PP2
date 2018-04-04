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
            this.status = new System.Windows.Forms.StatusStrip();
            this.gameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameStatus});
            this.status.Location = new System.Drawing.Point(0, 660);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1125, 25);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
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
            this.ClientSize = new System.Drawing.Size(1125, 685);
            this.Controls.Add(this.status);
            this.Name = "main";
            this.Text = "BattleShip";
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel gameStatus;
    }
}

