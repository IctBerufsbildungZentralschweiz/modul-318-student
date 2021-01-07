namespace MeinFahrplan
{
    partial class Abfahrtstafel
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
            this.AdgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.dgvDatumZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvgZugname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbtnAbfahrtstafel = new System.Windows.Forms.Button();
            this.AcbStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdgvVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // AdgvVerbindungen
            // 
            this.AdgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdgvVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDatumZeit,
            this.AdvgZugname,
            this.dgvStart,
            this.dgvEnd});
            this.AdgvVerbindungen.Location = new System.Drawing.Point(36, 85);
            this.AdgvVerbindungen.Name = "AdgvVerbindungen";
            this.AdgvVerbindungen.Size = new System.Drawing.Size(474, 239);
            this.AdgvVerbindungen.TabIndex = 2;
            // 
            // dgvDatumZeit
            // 
            this.dgvDatumZeit.HeaderText = "Datum/Zeit";
            this.dgvDatumZeit.Name = "dgvDatumZeit";
            // 
            // AdvgZugname
            // 
            this.AdvgZugname.HeaderText = "Zugname";
            this.AdvgZugname.Name = "AdvgZugname";
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
            // AbtnAbfahrtstafel
            // 
            this.AbtnAbfahrtstafel.Location = new System.Drawing.Point(260, 41);
            this.AbtnAbfahrtstafel.Name = "AbtnAbfahrtstafel";
            this.AbtnAbfahrtstafel.Size = new System.Drawing.Size(75, 23);
            this.AbtnAbfahrtstafel.TabIndex = 1;
            this.AbtnAbfahrtstafel.Text = "Suchen";
            this.AbtnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.AbtnAbfahrtstafel.Click += new System.EventHandler(this.AbtnAbfahrtstafel_Click);
            // 
            // AcbStart
            // 
            this.AcbStart.FormattingEnabled = true;
            this.AcbStart.Location = new System.Drawing.Point(110, 41);
            this.AcbStart.Name = "AcbStart";
            this.AcbStart.Size = new System.Drawing.Size(121, 21);
            this.AcbStart.TabIndex = 0;
            this.AcbStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AcbStart_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start-Station:";
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcbStart);
            this.Controls.Add(this.AbtnAbfahrtstafel);
            this.Controls.Add(this.AdgvVerbindungen);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.AdgvVerbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdgvVerbindungen;
        private System.Windows.Forms.Button AbtnAbfahrtstafel;
        private System.Windows.Forms.ComboBox AcbStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDatumZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvgZugname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEnd;
        private System.Windows.Forms.Label label1;
    }
}