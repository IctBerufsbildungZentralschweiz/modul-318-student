namespace MeinFahrplan
{
    partial class TransportMain
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
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.dgvDatumZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnkunftZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDuratoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatumZeit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbOrt = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEndStation = new System.Windows.Forms.ComboBox();
            this.cbStartStatoin = new System.Windows.Forms.ComboBox();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.gbDatumZeit.SuspendLayout();
            this.gbOrt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerbindungen
            // 
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDatumZeit,
            this.dgvStart,
            this.dgvEnd,
            this.dgvPlatform,
            this.dgvAnkunftZeit,
            this.dgvDuratoin});
            this.dgvVerbindungen.Location = new System.Drawing.Point(21, 293);
            this.dgvVerbindungen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.RowHeadersWidth = 51;
            this.dgvVerbindungen.Size = new System.Drawing.Size(965, 257);
            this.dgvVerbindungen.TabIndex = 10;
            // 
            // dgvDatumZeit
            // 
            this.dgvDatumZeit.HeaderText = "Datum/Zeit";
            this.dgvDatumZeit.MinimumWidth = 6;
            this.dgvDatumZeit.Name = "dgvDatumZeit";
            this.dgvDatumZeit.Width = 125;
            // 
            // dgvStart
            // 
            this.dgvStart.HeaderText = "Start-Station";
            this.dgvStart.MinimumWidth = 6;
            this.dgvStart.Name = "dgvStart";
            this.dgvStart.Width = 125;
            // 
            // dgvEnd
            // 
            this.dgvEnd.HeaderText = "End-Station";
            this.dgvEnd.MinimumWidth = 6;
            this.dgvEnd.Name = "dgvEnd";
            this.dgvEnd.Width = 125;
            // 
            // dgvPlatform
            // 
            this.dgvPlatform.HeaderText = "Platform";
            this.dgvPlatform.MinimumWidth = 6;
            this.dgvPlatform.Name = "dgvPlatform";
            this.dgvPlatform.Width = 125;
            // 
            // dgvAnkunftZeit
            // 
            this.dgvAnkunftZeit.HeaderText = "Ankufts Zeit";
            this.dgvAnkunftZeit.MinimumWidth = 6;
            this.dgvAnkunftZeit.Name = "dgvAnkunftZeit";
            this.dgvAnkunftZeit.Width = 125;
            // 
            // dgvDuratoin
            // 
            this.dgvDuratoin.HeaderText = "Reisezeit";
            this.dgvDuratoin.MinimumWidth = 6;
            this.dgvDuratoin.Name = "dgvDuratoin";
            this.dgvDuratoin.Width = 125;
            // 
            // gbDatumZeit
            // 
            this.gbDatumZeit.Controls.Add(this.label4);
            this.gbDatumZeit.Controls.Add(this.label3);
            this.gbDatumZeit.Controls.Add(this.dtpZeit);
            this.gbDatumZeit.Controls.Add(this.dtpDate);
            this.gbDatumZeit.Location = new System.Drawing.Point(24, 97);
            this.gbDatumZeit.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatumZeit.Name = "gbDatumZeit";
            this.gbDatumZeit.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatumZeit.Size = new System.Drawing.Size(312, 176);
            this.gbDatumZeit.TabIndex = 1;
            this.gbDatumZeit.TabStop = false;
            this.gbDatumZeit.Text = "Datum/Zeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum:";
            // 
            // dtpZeit
            // 
            this.dtpZeit.Checked = false;
            this.dtpZeit.CustomFormat = "HH:mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(72, 114);
            this.dtpZeit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(125, 22);
            this.dtpZeit.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(72, 59);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(125, 22);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2020, 12, 15, 11, 9, 51, 0);
            // 
            // gbOrt
            // 
            this.gbOrt.Controls.Add(this.label2);
            this.gbOrt.Controls.Add(this.label1);
            this.gbOrt.Controls.Add(this.cbEndStation);
            this.gbOrt.Controls.Add(this.cbStartStatoin);
            this.gbOrt.Location = new System.Drawing.Point(373, 97);
            this.gbOrt.Margin = new System.Windows.Forms.Padding(4);
            this.gbOrt.Name = "gbOrt";
            this.gbOrt.Padding = new System.Windows.Forms.Padding(4);
            this.gbOrt.Size = new System.Drawing.Size(319, 176);
            this.gbOrt.TabIndex = 2;
            this.gbOrt.TabStop = false;
            this.gbOrt.Text = "Ort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "End-Station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start-Station:";
            // 
            // cbEndStation
            // 
            this.cbEndStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEndStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEndStation.FormattingEnabled = true;
            this.cbEndStation.Location = new System.Drawing.Point(104, 103);
            this.cbEndStation.Margin = new System.Windows.Forms.Padding(4);
            this.cbEndStation.Name = "cbEndStation";
            this.cbEndStation.Size = new System.Drawing.Size(160, 24);
            this.cbEndStation.TabIndex = 4;
            this.cbEndStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // cbStartStatoin
            // 
            this.cbStartStatoin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStartStatoin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbStartStatoin.FormattingEnabled = true;
            this.cbStartStatoin.Location = new System.Drawing.Point(104, 52);
            this.cbStartStatoin.Margin = new System.Windows.Forms.Padding(4);
            this.cbStartStatoin.Name = "cbStartStatoin";
            this.cbStartStatoin.Size = new System.Drawing.Size(160, 24);
            this.cbStartStatoin.TabIndex = 3;
            this.cbStartStatoin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Location = new System.Drawing.Point(715, 183);
            this.btnVerbindung.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(273, 28);
            this.btnVerbindung.TabIndex = 6;
            this.btnVerbindung.Text = "Verbindungen suchen";
            this.btnVerbindung.UseVisualStyleBackColor = true;
            this.btnVerbindung.Click += new System.EventHandler(this.BtnVerbindung_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(715, 231);
            this.btnAbfahrtstafel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(273, 28);
            this.btnAbfahrtstafel.TabIndex = 8;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.BtnAbfahrtstafel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Willkommen Zur SBB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "FahrPlan";
            // 
            // TransportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.gbOrt);
            this.Controls.Add(this.gbDatumZeit);
            this.Controls.Add(this.dgvVerbindungen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1059, 632);
            this.MinimumSize = new System.Drawing.Size(1059, 632);
            this.Name = "TransportMain";
            this.Text = "Transport-App";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.gbDatumZeit.ResumeLayout(false);
            this.gbDatumZeit.PerformLayout();
            this.gbOrt.ResumeLayout(false);
            this.gbOrt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerbindungen;
        private System.Windows.Forms.GroupBox gbDatumZeit;
        private System.Windows.Forms.GroupBox gbOrt;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEndStation;
        private System.Windows.Forms.ComboBox cbStartStatoin;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDatumZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnkunftZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDuratoin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

