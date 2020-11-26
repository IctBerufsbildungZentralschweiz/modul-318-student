namespace Justtransport
{
  partial class anzeigVerbindung
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Startort = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Endort = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Verbindung = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Datum,
            this.Startort,
            this.Endort,
            this.Verbindung,
            this.Gleis});
      this.dataGridView1.Location = new System.Drawing.Point(-4, 142);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 62;
      this.dataGridView1.RowTemplate.Height = 28;
      this.dataGridView1.Size = new System.Drawing.Size(943, 311);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // Abfahrt
      // 
      this.Abfahrt.HeaderText = "Abfahrt";
      this.Abfahrt.MinimumWidth = 8;
      this.Abfahrt.Name = "Abfahrt";
      this.Abfahrt.Width = 98;
      // 
      // Ankunft
      // 
      this.Ankunft.HeaderText = "Ankunft";
      this.Ankunft.MinimumWidth = 8;
      this.Ankunft.Name = "Ankunft";
      this.Ankunft.Width = 101;
      // 
      // Datum
      // 
      this.Datum.HeaderText = "Datum";
      this.Datum.MinimumWidth = 8;
      this.Datum.Name = "Datum";
      this.Datum.Width = 93;
      // 
      // Startort
      // 
      this.Startort.HeaderText = "Startort";
      this.Startort.MinimumWidth = 8;
      this.Startort.Name = "Startort";
      this.Startort.Width = 99;
      // 
      // Endort
      // 
      this.Endort.HeaderText = "Endort";
      this.Endort.MinimumWidth = 8;
      this.Endort.Name = "Endort";
      this.Endort.Width = 93;
      // 
      // Verbindung
      // 
      this.Verbindung.HeaderText = "Verbindung";
      this.Verbindung.MinimumWidth = 8;
      this.Verbindung.Name = "Verbindung";
      this.Verbindung.Width = 127;
      // 
      // Gleis
      // 
      this.Gleis.HeaderText = "Gleis";
      this.Gleis.MinimumWidth = 8;
      this.Gleis.Name = "Gleis";
      this.Gleis.Width = 81;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(418, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Ort / Ort";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(402, 101);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Datum / Zeit";
      // 
      // anzeigVerbindung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(938, 454);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "anzeigVerbindung";
      this.Text = "StartEndstation";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    private System.Windows.Forms.DataGridViewTextBoxColumn Startort;
    private System.Windows.Forms.DataGridViewTextBoxColumn Endort;
    private System.Windows.Forms.DataGridViewTextBoxColumn Verbindung;
    private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}