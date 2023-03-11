namespace Pruebita1
{
    partial class Quote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quote));
            this.btnSaludar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.ChkA = new System.Windows.Forms.CheckBox();
            this.LblNation = new System.Windows.Forms.Label();
            this.RbSingle = new System.Windows.Forms.RadioButton();
            this.RbMarried = new System.Windows.Forms.RadioButton();
            this.ChkO = new System.Windows.Forms.CheckBox();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.CmbPosition = new System.Windows.Forms.ComboBox();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaludar.Location = new System.Drawing.Point(35, 572);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(127, 47);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Location = new System.Drawing.Point(156, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblName.Location = new System.Drawing.Point(75, 50);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name:";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSaludo.Location = new System.Drawing.Point(502, 559);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 5;
            // 
            // ChkA
            // 
            this.ChkA.AutoSize = true;
            this.ChkA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ChkA.Location = new System.Drawing.Point(156, 184);
            this.ChkA.Name = "ChkA";
            this.ChkA.Size = new System.Drawing.Size(72, 17);
            this.ChkA.TabIndex = 4;
            this.ChkA.Text = "Australian";
            this.ChkA.UseVisualStyleBackColor = false;
            // 
            // LblNation
            // 
            this.LblNation.AutoSize = true;
            this.LblNation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblNation.Location = new System.Drawing.Point(75, 184);
            this.LblNation.Name = "LblNation";
            this.LblNation.Size = new System.Drawing.Size(59, 13);
            this.LblNation.TabIndex = 5;
            this.LblNation.Text = "Nationality:";
            // 
            // RbSingle
            // 
            this.RbSingle.AutoSize = true;
            this.RbSingle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RbSingle.Location = new System.Drawing.Point(78, 218);
            this.RbSingle.Name = "RbSingle";
            this.RbSingle.Size = new System.Drawing.Size(54, 17);
            this.RbSingle.TabIndex = 6;
            this.RbSingle.TabStop = true;
            this.RbSingle.Text = "Single";
            this.RbSingle.UseVisualStyleBackColor = false;
            // 
            // RbMarried
            // 
            this.RbMarried.AutoSize = true;
            this.RbMarried.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RbMarried.Location = new System.Drawing.Point(178, 218);
            this.RbMarried.Name = "RbMarried";
            this.RbMarried.Size = new System.Drawing.Size(60, 17);
            this.RbMarried.TabIndex = 7;
            this.RbMarried.TabStop = true;
            this.RbMarried.Text = "Married";
            this.RbMarried.UseVisualStyleBackColor = false;
            // 
            // ChkO
            // 
            this.ChkO.AutoSize = true;
            this.ChkO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ChkO.Location = new System.Drawing.Point(234, 184);
            this.ChkO.Name = "ChkO";
            this.ChkO.Size = new System.Drawing.Size(52, 17);
            this.ChkO.TabIndex = 9;
            this.ChkO.Text = "Other";
            this.ChkO.UseVisualStyleBackColor = false;
            // 
            // dt1
            // 
            this.dt1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dt1.Location = new System.Drawing.Point(156, 136);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(200, 20);
            this.dt1.TabIndex = 10;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDate.Location = new System.Drawing.Point(75, 143);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(68, 13);
            this.LblDate.TabIndex = 11;
            this.LblDate.Text = "Date of birth:";
            // 
            // CmbPosition
            // 
            this.CmbPosition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Location = new System.Drawing.Point(156, 265);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(247, 21);
            this.CmbPosition.TabIndex = 12;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblPosition.Location = new System.Drawing.Point(75, 268);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(47, 13);
            this.LblPosition.TabIndex = 13;
            this.LblPosition.Text = "Position:";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblSecond.Location = new System.Drawing.Point(75, 93);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(76, 13);
            this.LblSecond.TabIndex = 14;
            this.LblSecond.Text = "Second name:";
            // 
            // txbSurname
            // 
            this.txbSurname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSurname.Location = new System.Drawing.Point(156, 86);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(256, 20);
            this.txbSurname.TabIndex = 15;
            // 
            // txtreason
            // 
            this.txtreason.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtreason.Location = new System.Drawing.Point(197, 400);
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(389, 20);
            this.txtreason.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(75, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reason of visit:";
            // 
            // Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.LblNation);
            this.Controls.Add(this.ChkA);
            this.Controls.Add(this.ChkO);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.LblSecond);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.CmbPosition);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.RbMarried);
            this.Controls.Add(this.RbSingle);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Quote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUOTE";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Quote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.CheckBox ChkA;
        private System.Windows.Forms.Label LblNation;
        private System.Windows.Forms.RadioButton RbSingle;
        private System.Windows.Forms.RadioButton RbMarried;
        private System.Windows.Forms.CheckBox ChkO;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.Label label1;
    }
}

