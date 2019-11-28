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
            this.pnlAnkunft = new System.Windows.Forms.Panel();
            this.txtAnkunft = new System.Windows.Forms.TextBox();
            this.pnlAbfahrt = new System.Windows.Forms.Panel();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lstAnkunft = new System.Windows.Forms.ListBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            this.datZeit = new System.Windows.Forms.DateTimePicker();
            this.datDatum = new System.Windows.Forms.DateTimePicker();
            this.lstAbfahrt = new System.Windows.Forms.ListBox();
            this.pnlLayout.SuspendLayout();
            this.pnlAnkunft.SuspendLayout();
            this.pnlAbfahrt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNavVerbindung
            // 
            this.btnNavVerbindung.BackColor = System.Drawing.Color.White;
            this.btnNavVerbindung.FlatAppearance.BorderSize = 0;
            this.btnNavVerbindung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavVerbindung.Location = new System.Drawing.Point(11, 11);
            this.btnNavVerbindung.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavVerbindung.Name = "btnNavVerbindung";
            this.btnNavVerbindung.Size = new System.Drawing.Size(110, 110);
            this.btnNavVerbindung.TabIndex = 0;
            this.btnNavVerbindung.Text = "Verbindung";
            this.btnNavVerbindung.UseVisualStyleBackColor = false;
            // 
            // btnNavPlan
            // 
            this.btnNavPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnNavPlan.FlatAppearance.BorderSize = 0;
            this.btnNavPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPlan.ForeColor = System.Drawing.Color.White;
            this.btnNavPlan.Location = new System.Drawing.Point(11, 135);
            this.btnNavPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavPlan.Name = "btnNavPlan";
            this.btnNavPlan.Size = new System.Drawing.Size(110, 110);
            this.btnNavPlan.TabIndex = 1;
            this.btnNavPlan.Text = "Abfahrtsplan";
            this.btnNavPlan.UseVisualStyleBackColor = false;
            // 
            // btnNavInfo
            // 
            this.btnNavInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnNavInfo.FlatAppearance.BorderSize = 0;
            this.btnNavInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInfo.ForeColor = System.Drawing.Color.White;
            this.btnNavInfo.Location = new System.Drawing.Point(11, 259);
            this.btnNavInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavInfo.Name = "btnNavInfo";
            this.btnNavInfo.Size = new System.Drawing.Size(110, 110);
            this.btnNavInfo.TabIndex = 2;
            this.btnNavInfo.Text = "button1";
            this.btnNavInfo.UseVisualStyleBackColor = false;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(21, 27);
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
            this.txtAbfahrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbfahrt.Location = new System.Drawing.Point(11, 6);
            this.txtAbfahrt.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbfahrt.Name = "txtAbfahrt";
            this.txtAbfahrt.Size = new System.Drawing.Size(139, 19);
            this.txtAbfahrt.TabIndex = 4;
            // 
            // pnlLayout
            // 
            this.pnlLayout.BackColor = System.Drawing.Color.White;
            this.pnlLayout.Controls.Add(this.pnlAnkunft);
            this.pnlLayout.Controls.Add(this.pnlAbfahrt);
            this.pnlLayout.Controls.Add(this.btnSuchen);
            this.pnlLayout.Controls.Add(this.lstAnkunft);
            this.pnlLayout.Controls.Add(this.btnAn);
            this.pnlLayout.Controls.Add(this.btnAb);
            this.pnlLayout.Controls.Add(this.datZeit);
            this.pnlLayout.Controls.Add(this.datDatum);
            this.pnlLayout.Controls.Add(this.lstAbfahrt);
            this.pnlLayout.Controls.Add(this.lblTitel);
            this.pnlLayout.Location = new System.Drawing.Point(118, 11);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(380, 358);
            this.pnlLayout.TabIndex = 6;
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
            this.txtAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnkunft.Location = new System.Drawing.Point(11, 6);
            this.txtAnkunft.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnkunft.Name = "txtAnkunft";
            this.txtAnkunft.Size = new System.Drawing.Size(139, 19);
            this.txtAnkunft.TabIndex = 4;
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
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // btnAn
            // 
            this.btnAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAn.FlatAppearance.BorderSize = 0;
            this.btnAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAn.ForeColor = System.Drawing.Color.Black;
            this.btnAn.Location = new System.Drawing.Point(95, 290);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(55, 43);
            this.btnAn.TabIndex = 10;
            this.btnAn.Text = "AN";
            this.btnAn.UseVisualStyleBackColor = false;
            // 
            // btnAb
            // 
            this.btnAb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnAb.FlatAppearance.BorderSize = 0;
            this.btnAb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAb.ForeColor = System.Drawing.Color.White;
            this.btnAb.Location = new System.Drawing.Point(40, 290);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(55, 43);
            this.btnAb.TabIndex = 9;
            this.btnAb.Text = "AB";
            this.btnAb.UseVisualStyleBackColor = false;
            // 
            // datZeit
            // 
            this.datZeit.CustomFormat = "HH:MM";
            this.datZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datZeit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datZeit.Location = new System.Drawing.Point(118, 258);
            this.datZeit.Name = "datZeit";
            this.datZeit.ShowUpDown = true;
            this.datZeit.Size = new System.Drawing.Size(60, 26);
            this.datZeit.TabIndex = 8;
            // 
            // datDatum
            // 
            this.datDatum.CalendarMonthBackground = System.Drawing.Color.White;
            this.datDatum.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.datDatum.CalendarTitleForeColor = System.Drawing.Color.White;
            this.datDatum.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDatum.Location = new System.Drawing.Point(18, 258);
            this.datDatum.Name = "datDatum";
            this.datDatum.Size = new System.Drawing.Size(100, 26);
            this.datDatum.TabIndex = 7;
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
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(510, 382);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.btnNavInfo);
            this.Controls.Add(this.btnNavPlan);
            this.Controls.Add(this.btnNavVerbindung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fahrplan";
            this.Text = "Form1";
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            this.pnlAnkunft.ResumeLayout(false);
            this.pnlAnkunft.PerformLayout();
            this.pnlAbfahrt.ResumeLayout(false);
            this.pnlAbfahrt.PerformLayout();
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
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnAb;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.ListBox lstAnkunft;
        private System.Windows.Forms.Panel pnlAbfahrt;
        private System.Windows.Forms.Panel pnlAnkunft;
        private System.Windows.Forms.TextBox txtAnkunft;
    }
}

