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
            this.AdgvVerbindungen.Location = new System.Drawing.Point(48, 105);
            this.AdgvVerbindungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdgvVerbindungen.Name = "AdgvVerbindungen";
            this.AdgvVerbindungen.RowHeadersWidth = 51;
            this.AdgvVerbindungen.Size = new System.Drawing.Size(632, 294);
            this.AdgvVerbindungen.TabIndex = 2;
            // 
            // dgvDatumZeit
            // 
            this.dgvDatumZeit.HeaderText = "Datum/Zeit";
            this.dgvDatumZeit.MinimumWidth = 6;
            this.dgvDatumZeit.Name = "dgvDatumZeit";
            this.dgvDatumZeit.Width = 125;
            // 
            // AdvgZugname
            // 
            this.AdvgZugname.HeaderText = "Zugname";
            this.AdvgZugname.MinimumWidth = 6;
            this.AdvgZugname.Name = "AdvgZugname";
            this.AdvgZugname.Width = 125;
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
            // AbtnAbfahrtstafel
            // 
            this.AbtnAbfahrtstafel.Location = new System.Drawing.Point(347, 50);
            this.AbtnAbfahrtstafel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AbtnAbfahrtstafel.Name = "AbtnAbfahrtstafel";
            this.AbtnAbfahrtstafel.Size = new System.Drawing.Size(100, 28);
            this.AbtnAbfahrtstafel.TabIndex = 1;
            this.AbtnAbfahrtstafel.Text = "Suchen";
            this.AbtnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.AbtnAbfahrtstafel.Click += new System.EventHandler(this.AbtnAbfahrtstafel_Click);
            // 
            // AcbStart
            // 
            this.AcbStart.FormattingEnabled = true;
            this.AcbStart.Location = new System.Drawing.Point(147, 50);
            this.AcbStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcbStart.Name = "AcbStart";
            this.AcbStart.Size = new System.Drawing.Size(160, 24);
            this.AcbStart.TabIndex = 0;
            this.AcbStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AcbStart_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start-Station:";
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcbStart);
            this.Controls.Add(this.AbtnAbfahrtstafel);
            this.Controls.Add(this.AdgvVerbindungen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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