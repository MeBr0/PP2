﻿namespace Graphics
{
    partial class Form1
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
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Picture.Location = new System.Drawing.Point(6, 6);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1036, 712);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 730);
            this.Controls.Add(this.Picture);
            this.Name = "Form1";
            this.Text = "Spaceship";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
    }
}
