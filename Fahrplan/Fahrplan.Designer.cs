namespace Fahrplan
{
    partial class Fahrplan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNavVerbindung = new System.Windows.Forms.Button();
            this.btnNavPlan = new System.Windows.Forms.Button();
            this.btnNavInfo = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtAbfahrt = new System.Windows.Forms.TextBox();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.datDatum = new System.Windows.Forms.DateTimePicker();
            this.pnlAnkunft = new System.Windows.Forms.Panel();
            this.txtAnkunft = new System.Windows.Forms.TextBox();
            this.pnlAbfahrt = new System.Windows.Forms.Panel();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lstAnkunft = new System.Windows.Forms.ListBox();
            this.datZeit = new System.Windows.Forms.DateTimePicker();
            this.lstAbfahrt = new System.Windows.Forms.ListBox();
            this.pnlErgebnisse = new System.Windows.Forms.Panel();
            this.lstErgebnisse = new System.Windows.Forms.ListBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnRückfahrt = new System.Windows.Forms.Button();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlLayout.SuspendLayout();
            this.pnlAnkunft.SuspendLayout();
            this.pnlAbfahrt.SuspendLayout();
            this.pnlErgebnisse.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNavVerbindung
            // 
            this.btnNavVerbindung.BackColor = System.Drawing.Color.White;
            this.btnNavVerbindung.FlatAppearance.BorderSize = 0;
            this.btnNavVerbindung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNavVerbindung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavVerbindung.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavVerbindung.Location = new System.Drawing.Point(11, 11);
            this.btnNavVerbindung.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavVerbindung.Name = "btnNavVerbindung";
            this.btnNavVerbindung.Size = new System.Drawing.Size(110, 110);
            this.btnNavVerbindung.TabIndex = 0;
            this.btnNavVerbindung.Text = "<|||>";
            this.btnNavVerbindung.UseVisualStyleBackColor = false;
            this.btnNavVerbindung.Click += new System.EventHandler(this.btnNavVerbindung_Click);
            // 
            // btnNavPlan
            // 
            this.btnNavPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnNavPlan.FlatAppearance.BorderSize = 0;
            this.btnNavPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNavPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPlan.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavPlan.ForeColor = System.Drawing.Color.White;
            this.btnNavPlan.Location = new System.Drawing.Point(11, 135);
            this.btnNavPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavPlan.Name = "btnNavPlan";
            this.btnNavPlan.Size = new System.Drawing.Size(110, 110);
            this.btnNavPlan.TabIndex = 1;
            this.btnNavPlan.Text = "- - - - - -";
            this.btnNavPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNavPlan.UseVisualStyleBackColor = false;
            this.btnNavPlan.Click += new System.EventHandler(this.btnNavPlan_Click);
            // 
            // btnNavInfo
            // 
            this.btnNavInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnNavInfo.FlatAppearance.BorderSize = 0;
            this.btnNavInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNavInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInfo.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavInfo.ForeColor = System.Drawing.Color.White;
            this.btnNavInfo.Location = new System.Drawing.Point(11, 259);
            this.btnNavInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavInfo.Name = "btnNavInfo";
            this.btnNavInfo.Size = new System.Drawing.Size(110, 110);
            this.btnNavInfo.TabIndex = 2;
            this.btnNavInfo.Text = "i";
            this.btnNavInfo.UseVisualStyleBackColor = false;
            this.btnNavInfo.Click += new System.EventHandler(this.btnNavInfo_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(15, 16);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(147, 29);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "Verbindung";
            // 
            // txtAbfahrt
            // 
            this.txtAbfahrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAbfahrt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbfahrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbfahrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.txtAbfahrt.Location = new System.Drawing.Point(2, 6);
            this.txtAbfahrt.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbfahrt.Name = "txtAbfahrt";
            this.txtAbfahrt.Size = new System.Drawing.Size(156, 19);
            this.txtAbfahrt.TabIndex = 4;
            this.txtAbfahrt.TextChanged += new System.EventHandler(this.txtAbfahrt_TextChanged);
            // 
            // pnlLayout
            // 
            this.pnlLayout.BackColor = System.Drawing.Color.White;
            this.pnlLayout.Controls.Add(this.lblDate);
            this.pnlLayout.Controls.Add(this.lblNach);
            this.pnlLayout.Controls.Add(this.lblVon);
            this.pnlLayout.Controls.Add(this.datDatum);
            this.pnlLayout.Controls.Add(this.pnlAnkunft);
            this.pnlLayout.Controls.Add(this.pnlAbfahrt);
            this.pnlLayout.Controls.Add(this.btnSuchen);
            this.pnlLayout.Controls.Add(this.lstAnkunft);
            this.pnlLayout.Controls.Add(this.datZeit);
            this.pnlLayout.Controls.Add(this.lstAbfahrt);
            this.pnlLayout.Controls.Add(this.lblTitel);
            this.pnlLayout.Location = new System.Drawing.Point(118, 11);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(380, 358);
            this.pnlLayout.TabIndex = 6;
            // 
            // datDatum
            // 
            this.datDatum.CalendarForeColor = System.Drawing.Color.Black;
            this.datDatum.CalendarMonthBackground = System.Drawing.Color.White;
            this.datDatum.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.datDatum.CalendarTitleForeColor = System.Drawing.Color.White;
            this.datDatum.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datDatum.CustomFormat = "dd.MM.yy";
            this.datDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDatum.Location = new System.Drawing.Point(18, 272);
            this.datDatum.MaxDate = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            this.datDatum.Name = "datDatum";
            this.datDatum.Size = new System.Drawing.Size(160, 31);
            this.datDatum.TabIndex = 7;
            // 
            // pnlAnkunft
            // 
            this.pnlAnkunft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAnkunft.Controls.Add(this.txtAnkunft);
            this.pnlAnkunft.Location = new System.Drawing.Point(200, 80);
            this.pnlAnkunft.Name = "pnlAnkunft";
            this.pnlAnkunft.Size = new System.Drawing.Size(160, 30);
            this.pnlAnkunft.TabIndex = 14;
            // 
            // txtAnkunft
            // 
            this.txtAnkunft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAnkunft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnkunft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.txtAnkunft.Location = new System.Drawing.Point(2, 6);
            this.txtAnkunft.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnkunft.Name = "txtAnkunft";
            this.txtAnkunft.Size = new System.Drawing.Size(156, 19);
            this.txtAnkunft.TabIndex = 4;
            this.txtAnkunft.TextChanged += new System.EventHandler(this.txtAnkunft_TextChanged);
            // 
            // pnlAbfahrt
            // 
            this.pnlAbfahrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAbfahrt.Controls.Add(this.txtAbfahrt);
            this.pnlAbfahrt.Location = new System.Drawing.Point(18, 79);
            this.pnlAbfahrt.Name = "pnlAbfahrt";
            this.pnlAbfahrt.Size = new System.Drawing.Size(160, 30);
            this.pnlAbfahrt.TabIndex = 13;
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnSuchen.FlatAppearance.BorderSize = 0;
            this.btnSuchen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuchen.ForeColor = System.Drawing.Color.White;
            this.btnSuchen.Location = new System.Drawing.Point(200, 258);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(160, 75);
            this.btnSuchen.TabIndex = 12;
            this.btnSuchen.Text = "SUCHEN";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // lstAnkunft
            // 
            this.lstAnkunft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstAnkunft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnkunft.FormattingEnabled = true;
            this.lstAnkunft.ItemHeight = 20;
            this.lstAnkunft.Location = new System.Drawing.Point(200, 114);
            this.lstAnkunft.Name = "lstAnkunft";
            this.lstAnkunft.Size = new System.Drawing.Size(160, 120);
            this.lstAnkunft.TabIndex = 11;
            this.lstAnkunft.Click += new System.EventHandler(this.lstAnkunft_Click);
            // 
            // datZeit
            // 
            this.datZeit.CustomFormat = "HH:mm";
            this.datZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datZeit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datZeit.Location = new System.Drawing.Point(18, 302);
            this.datZeit.MaxDate = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            this.datZeit.Name = "datZeit";
            this.datZeit.ShowUpDown = true;
            this.datZeit.Size = new System.Drawing.Size(160, 31);
            this.datZeit.TabIndex = 8;
            // 
            // lstAbfahrt
            // 
            this.lstAbfahrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstAbfahrt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAbfahrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAbfahrt.FormattingEnabled = true;
            this.lstAbfahrt.ItemHeight = 20;
            this.lstAbfahrt.Location = new System.Drawing.Point(18, 115);
            this.lstAbfahrt.Name = "lstAbfahrt";
            this.lstAbfahrt.Size = new System.Drawing.Size(160, 120);
            this.lstAbfahrt.TabIndex = 6;
            this.lstAbfahrt.Click += new System.EventHandler(this.lstAbfahrt_Click);
            // 
            // pnlErgebnisse
            // 
            this.pnlErgebnisse.BackColor = System.Drawing.Color.White;
            this.pnlErgebnisse.Controls.Add(this.lstErgebnisse);
            this.pnlErgebnisse.Location = new System.Drawing.Point(504, 11);
            this.pnlErgebnisse.Name = "pnlErgebnisse";
            this.pnlErgebnisse.Size = new System.Drawing.Size(304, 167);
            this.pnlErgebnisse.TabIndex = 7;
            // 
            // lstErgebnisse
            // 
            this.lstErgebnisse.BackColor = System.Drawing.Color.White;
            this.lstErgebnisse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstErgebnisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstErgebnisse.FormattingEnabled = true;
            this.lstErgebnisse.HorizontalExtent = 200;
            this.lstErgebnisse.ItemHeight = 20;
            this.lstErgebnisse.Location = new System.Drawing.Point(11, -6);
            this.lstErgebnisse.Name = "lstErgebnisse";
            this.lstErgebnisse.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstErgebnisse.Size = new System.Drawing.Size(280, 180);
            this.lstErgebnisse.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.Controls.Add(this.btnMail);
            this.pnlDetail.Controls.Add(this.btnRückfahrt);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Location = new System.Drawing.Point(504, 184);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(304, 185);
            this.pnlDetail.TabIndex = 8;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.ForeColor = System.Drawing.Color.White;
            this.btnMail.Location = new System.Drawing.Point(205, 117);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(86, 43);
            this.btnMail.TabIndex = 16;
            this.btnMail.Text = "MAIL";
            this.btnMail.UseVisualStyleBackColor = false;
            // 
            // btnRückfahrt
            // 
            this.btnRückfahrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRückfahrt.FlatAppearance.BorderSize = 0;
            this.btnRückfahrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRückfahrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRückfahrt.ForeColor = System.Drawing.Color.Black;
            this.btnRückfahrt.Location = new System.Drawing.Point(11, 117);
            this.btnRückfahrt.Name = "btnRückfahrt";
            this.btnRückfahrt.Size = new System.Drawing.Size(197, 43);
            this.btnRückfahrt.TabIndex = 18;
            this.btnRückfahrt.Text = "RÜCKFAHRT";
            this.btnRückfahrt.UseVisualStyleBackColor = false;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoEllipsis = true;
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(6, 14);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetail.MaximumSize = new System.Drawing.Size(295, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(294, 29);
            this.lblDetail.TabIndex = 15;
            this.lblDetail.Text = "- - - - - - - - - - - - - - - - - -";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblVon.Location = new System.Drawing.Point(17, 60);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(33, 16);
            this.lblVon.TabIndex = 15;
            this.lblVon.Text = "von";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblNach.Location = new System.Drawing.Point(199, 60);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(41, 16);
            this.lblNach.TabIndex = 16;
            this.lblNach.Text = "nach";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblDate.Location = new System.Drawing.Point(17, 253);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(113, 16);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Datum / Uhrzeit";
            // 
            // Fahrplan
            // 
            this.AcceptButton = this.btnSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(832, 381);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlErgebnisse);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.btnNavInfo);
            this.Controls.Add(this.btnNavPlan);
            this.Controls.Add(this.btnNavVerbindung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Fahrplan";
            this.Text = "Form1";
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            this.pnlAnkunft.ResumeLayout(false);
            this.pnlAnkunft.PerformLayout();
            this.pnlAbfahrt.ResumeLayout(false);
            this.pnlAbfahrt.PerformLayout();
            this.pnlErgebnisse.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNavVerbindung;
        private System.Windows.Forms.Button btnNavPlan;
        private System.Windows.Forms.Button btnNavInfo;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtAbfahrt;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.DateTimePicker datZeit;
        private System.Windows.Forms.DateTimePicker datDatum;
        private System.Windows.Forms.ListBox lstAbfahrt;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.ListBox lstAnkunft;
        private System.Windows.Forms.Panel pnlAbfahrt;
        private System.Windows.Forms.Panel pnlAnkunft;
        private System.Windows.Forms.TextBox txtAnkunft;
        private System.Windows.Forms.Panel pnlErgebnisse;
        private System.Windows.Forms.ListBox lstErgebnisse;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnRückfahrt;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
    }
}

