namespace TelBook
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.telNumberLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.sortAsc = new System.Windows.Forms.Button();
            this.sortDesc = new System.Windows.Forms.Button();
            this.sortLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid.GridColor = System.Drawing.SystemColors.Window;
            this.grid.Location = new System.Drawing.Point(25, 65);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(600, 500);
            this.grid.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search.Location = new System.Drawing.Point(25, 15);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(600, 40);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.Search);
            // 
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightBtn.Location = new System.Drawing.Point(625, 65);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(20, 500);
            this.rightBtn.TabIndex = 3;
            this.rightBtn.Text = ">";
            this.rightBtn.UseVisualStyleBackColor = false;
            this.rightBtn.Click += new System.EventHandler(this.RightClick);
            // 
            // leftBtn
            // 
            this.leftBtn.BackColor = System.Drawing.Color.Transparent;
            this.leftBtn.Location = new System.Drawing.Point(5, 65);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(20, 500);
            this.leftBtn.TabIndex = 4;
            this.leftBtn.Text = "<";
            this.leftBtn.UseVisualStyleBackColor = false;
            this.leftBtn.Click += new System.EventHandler(this.LeftClick);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameText.Location = new System.Drawing.Point(650, 90);
            this.nameText.Multiline = true;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(239, 31);
            this.nameText.TabIndex = 5;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(650, 70);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 17);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name:";
            // 
            // numberText
            // 
            this.numberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numberText.Location = new System.Drawing.Point(650, 145);
            this.numberText.Multiline = true;
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(239, 31);
            this.numberText.TabIndex = 7;
            // 
            // telNumberLbl
            // 
            this.telNumberLbl.AutoSize = true;
            this.telNumberLbl.Location = new System.Drawing.Point(650, 125);
            this.telNumberLbl.Name = "telNumberLbl";
            this.telNumberLbl.Size = new System.Drawing.Size(134, 17);
            this.telNumberLbl.TabIndex = 8;
            this.telNumberLbl.Text = "Telephone Number:";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.Snow;
            this.createBtn.Location = new System.Drawing.Point(688, 179);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(160, 35);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Create New Number";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.CreateClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Snow;
            this.deleteBtn.Location = new System.Drawing.Point(688, 220);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 35);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete Number";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteClick);
            // 
            // sortAsc
            // 
            this.sortAsc.BackColor = System.Drawing.Color.Snow;
            this.sortAsc.Location = new System.Drawing.Point(691, 37);
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(70, 30);
            this.sortAsc.TabIndex = 12;
            this.sortAsc.Text = "ASC";
            this.sortAsc.UseVisualStyleBackColor = false;
            this.sortAsc.Click += new System.EventHandler(this.SortClickAsc);
            // 
            // sortDesc
            // 
            this.sortDesc.BackColor = System.Drawing.Color.Snow;
            this.sortDesc.Location = new System.Drawing.Point(767, 37);
            this.sortDesc.Name = "sortDesc";
            this.sortDesc.Size = new System.Drawing.Size(70, 30);
            this.sortDesc.TabIndex = 13;
            this.sortDesc.Text = "DESC";
            this.sortDesc.UseVisualStyleBackColor = false;
            this.sortDesc.Click += new System.EventHandler(this.SortClickDesc);
            // 
            // sortLbl
            // 
            this.sortLbl.Location = new System.Drawing.Point(688, 9);
            this.sortLbl.Name = "sortLbl";
            this.sortLbl.Size = new System.Drawing.Size(160, 25);
            this.sortLbl.TabIndex = 14;
            this.sortLbl.Text = "Sort Contacts by Date";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Snow;
            this.saveBtn.Location = new System.Drawing.Point(688, 261);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(160, 35);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 576);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.sortLbl);
            this.Controls.Add(this.sortDesc);
            this.Controls.Add(this.sortAsc);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.telNumberLbl);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.grid);
            this.Name = "Main";
            this.Text = "TelBook";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label telNumberLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button sortAsc;
        private System.Windows.Forms.Button sortDesc;
        private System.Windows.Forms.Label sortLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}

