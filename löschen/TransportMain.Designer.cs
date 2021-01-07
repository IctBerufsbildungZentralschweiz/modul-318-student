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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportMain));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.gbDatumZeit.SuspendLayout();
            this.gbOrt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgvVerbindungen.Location = new System.Drawing.Point(16, 238);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.Size = new System.Drawing.Size(724, 209);
            this.dgvVerbindungen.TabIndex = 10;
            // 
            // dgvDatumZeit
            // 
            this.dgvDatumZeit.HeaderText = "Datum/Zeit";
            this.dgvDatumZeit.Name = "dgvDatumZeit";
            // 
            // dgvStart
            // 
            this.dgvStart.HeaderText = "Start-Station";
            this.dgvStart.Name = "dgvStart";
            // 
            // dgvEnd
            // 
            this.dgvEnd.HeaderText = "End-Station";
            this.dgvEnd.Name = "dgvEnd";
            // 
            // dgvPlatform
            // 
            this.dgvPlatform.HeaderText = "Platform";
            this.dgvPlatform.Name = "dgvPlatform";
            // 
            // dgvAnkunftZeit
            // 
            this.dgvAnkunftZeit.HeaderText = "Ankufts Zeit";
            this.dgvAnkunftZeit.Name = "dgvAnkunftZeit";
            // 
            // dgvDuratoin
            // 
            this.dgvDuratoin.HeaderText = "Reisezeit";
            this.dgvDuratoin.Name = "dgvDuratoin";
            // 
            // gbDatumZeit
            // 
            this.gbDatumZeit.Controls.Add(this.label4);
            this.gbDatumZeit.Controls.Add(this.label3);
            this.gbDatumZeit.Controls.Add(this.dtpZeit);
            this.gbDatumZeit.Controls.Add(this.dtpDate);
            this.gbDatumZeit.Location = new System.Drawing.Point(18, 79);
            this.gbDatumZeit.Name = "gbDatumZeit";
            this.gbDatumZeit.Size = new System.Drawing.Size(234, 143);
            this.gbDatumZeit.TabIndex = 1;
            this.gbDatumZeit.TabStop = false;
            this.gbDatumZeit.Text = "Datum/Zeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum:";
            // 
            // dtpZeit
            // 
            this.dtpZeit.Checked = false;
            this.dtpZeit.CustomFormat = "HH:mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(54, 93);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(95, 20);
            this.dtpZeit.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(54, 48);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2020, 12, 15, 11, 9, 51, 0);
            // 
            // gbOrt
            // 
            this.gbOrt.Controls.Add(this.label2);
            this.gbOrt.Controls.Add(this.label1);
            this.gbOrt.Controls.Add(this.cbEndStation);
            this.gbOrt.Controls.Add(this.cbStartStatoin);
            this.gbOrt.Location = new System.Drawing.Point(280, 79);
            this.gbOrt.Name = "gbOrt";
            this.gbOrt.Size = new System.Drawing.Size(239, 143);
            this.gbOrt.TabIndex = 2;
            this.gbOrt.TabStop = false;
            this.gbOrt.Text = "Ort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End-Station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start-Station:";
            // 
            // cbEndStation
            // 
            this.cbEndStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEndStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEndStation.FormattingEnabled = true;
            this.cbEndStation.Location = new System.Drawing.Point(78, 84);
            this.cbEndStation.Name = "cbEndStation";
            this.cbEndStation.Size = new System.Drawing.Size(121, 21);
            this.cbEndStation.TabIndex = 4;
            this.cbEndStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // cbStartStatoin
            // 
            this.cbStartStatoin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStartStatoin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbStartStatoin.FormattingEnabled = true;
            this.cbStartStatoin.Location = new System.Drawing.Point(78, 42);
            this.cbStartStatoin.Name = "cbStartStatoin";
            this.cbStartStatoin.Size = new System.Drawing.Size(121, 21);
            this.cbStartStatoin.TabIndex = 3;
            this.cbStartStatoin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Location = new System.Drawing.Point(536, 149);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(205, 23);
            this.btnVerbindung.TabIndex = 6;
            this.btnVerbindung.Text = "Verbindungen suchen";
            this.btnVerbindung.UseVisualStyleBackColor = true;
            this.btnVerbindung.Click += new System.EventHandler(this.BtnVerbindung_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(536, 188);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(205, 23);
            this.btnAbfahrtstafel.TabIndex = 8;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.BtnAbfahrtstafel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TransportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(783, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.gbOrt);
            this.Controls.Add(this.gbDatumZeit);
            this.Controls.Add(this.dgvVerbindungen);
            this.MaximumSize = new System.Drawing.Size(799, 522);
            this.MinimumSize = new System.Drawing.Size(799, 522);
            this.Name = "TransportMain";
            this.Text = "Transport-App";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.gbDatumZeit.ResumeLayout(false);
            this.gbDatumZeit.PerformLayout();
            this.gbOrt.ResumeLayout(false);
            this.gbOrt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

