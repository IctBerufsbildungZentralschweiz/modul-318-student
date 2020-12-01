namespace Justtransport
{
  partial class JusttransportBoard
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
      this.btnStartEndConnection = new System.Windows.Forms.Button();
      this.btnConnectionFrom = new System.Windows.Forms.Button();
      this.tp1 = new System.Windows.Forms.TableLayoutPanel();
      this.txtStart = new System.Windows.Forms.TextBox();
      this.txtEnd = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.rbStartTime = new System.Windows.Forms.RadioButton();
      this.rbEndTime = new System.Windows.Forms.RadioButton();
      this.tp2 = new System.Windows.Forms.TableLayoutPanel();
      this.dpTime = new System.Windows.Forms.DateTimePicker();
      this.dpDate = new System.Windows.Forms.DateTimePicker();
      this.listConnection = new System.Windows.Forms.ListBox();
      this.btnKarte = new System.Windows.Forms.Button();
      this.btnVerbindung = new System.Windows.Forms.Button();
      this.tp1.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tp2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnStartEndConnection
      // 
      this.btnStartEndConnection.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.btnStartEndConnection.Location = new System.Drawing.Point(302, 12);
      this.btnStartEndConnection.Name = "btnStartEndConnection";
      this.btnStartEndConnection.Size = new System.Drawing.Size(104, 36);
      this.btnStartEndConnection.TabIndex = 0;
      this.btnStartEndConnection.Text = "Start u. End";
      this.btnStartEndConnection.UseVisualStyleBackColor = false;
      // 
      // btnConnectionFrom
      // 
      this.btnConnectionFrom.Location = new System.Drawing.Point(403, 12);
      this.btnConnectionFrom.Name = "btnConnectionFrom";
      this.btnConnectionFrom.Size = new System.Drawing.Size(117, 36);
      this.btnConnectionFrom.TabIndex = 0;
      this.btnConnectionFrom.Text = "Abfahrt von";
      this.btnConnectionFrom.UseVisualStyleBackColor = true;
      // 
      // tp1
      // 
      this.tp1.ColumnCount = 1;
      this.tp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tp1.Controls.Add(this.txtStart, 0, 0);
      this.tp1.Controls.Add(this.txtEnd, 0, 1);
      this.tp1.Location = new System.Drawing.Point(39, 54);
      this.tp1.Name = "tp1";
      this.tp1.RowCount = 2;
      this.tp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.51852F));
      this.tp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.48148F));
      this.tp1.Size = new System.Drawing.Size(343, 103);
      this.tp1.TabIndex = 14;
      // 
      // txtStart
      // 
      this.txtStart.Location = new System.Drawing.Point(3, 3);
      this.txtStart.Name = "txtStart";
      this.txtStart.Size = new System.Drawing.Size(279, 26);
      this.txtStart.TabIndex = 1;
      this.txtStart.Text = "Startort eingeben";
      this.txtStart.Click += new System.EventHandler(this.txtClearStart);
      // 
      // txtEnd
      // 
      this.txtEnd.Location = new System.Drawing.Point(3, 47);
      this.txtEnd.Name = "txtEnd";
      this.txtEnd.Size = new System.Drawing.Size(279, 26);
      this.txtEnd.TabIndex = 1;
      this.txtEnd.Text = "Endort eingeben";
      this.txtEnd.Click += new System.EventHandler(this.txtClearEnd);
      this.txtEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14837F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85163F));
      this.tableLayoutPanel3.Controls.Add(this.rbStartTime, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.rbEndTime, 1, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(417, 163);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(339, 38);
      this.tableLayoutPanel3.TabIndex = 19;
      // 
      // rbStartTime
      // 
      this.rbStartTime.AutoSize = true;
      this.rbStartTime.Location = new System.Drawing.Point(3, 3);
      this.rbStartTime.Name = "rbStartTime";
      this.rbStartTime.Size = new System.Drawing.Size(87, 24);
      this.rbStartTime.TabIndex = 4;
      this.rbStartTime.TabStop = true;
      this.rbStartTime.Text = "Abfahrt";
      this.rbStartTime.UseVisualStyleBackColor = true;
      // 
      // rbEndTime
      // 
      this.rbEndTime.AutoSize = true;
      this.rbEndTime.Location = new System.Drawing.Point(173, 3);
      this.rbEndTime.Name = "rbEndTime";
      this.rbEndTime.Size = new System.Drawing.Size(90, 24);
      this.rbEndTime.TabIndex = 4;
      this.rbEndTime.TabStop = true;
      this.rbEndTime.Text = "Ankunft";
      this.rbEndTime.UseVisualStyleBackColor = true;
      // 
      // tp2
      // 
      this.tp2.ColumnCount = 1;
      this.tp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp2.Controls.Add(this.dpTime, 0, 1);
      this.tp2.Controls.Add(this.dpDate, 0, 0);
      this.tp2.Location = new System.Drawing.Point(417, 54);
      this.tp2.Name = "tp2";
      this.tp2.RowCount = 2;
      this.tp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp2.Size = new System.Drawing.Size(339, 103);
      this.tp2.TabIndex = 18;
      // 
      // dpTime
      // 
      this.dpTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dpTime.Location = new System.Drawing.Point(174, 54);
      this.dpTime.Name = "dpTime";
      this.dpTime.Size = new System.Drawing.Size(162, 26);
      this.dpTime.TabIndex = 3;
      this.dpTime.Value = new System.DateTime(2020, 11, 26, 14, 46, 0, 0);
      // 
      // dpDate
      // 
      this.dpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dpDate.Location = new System.Drawing.Point(174, 3);
      this.dpDate.Name = "dpDate";
      this.dpDate.Size = new System.Drawing.Size(162, 26);
      this.dpDate.TabIndex = 2;
      // 
      // listConnection
      // 
      this.listConnection.FormattingEnabled = true;
      this.listConnection.ItemHeight = 20;
      this.listConnection.Location = new System.Drawing.Point(12, 219);
      this.listConnection.Name = "listConnection";
      this.listConnection.Size = new System.Drawing.Size(836, 324);
      this.listConnection.TabIndex = 21;
      // 
      // btnKarte
      // 
      this.btnKarte.Location = new System.Drawing.Point(636, 12);
      this.btnKarte.Name = "btnKarte";
      this.btnKarte.Size = new System.Drawing.Size(117, 36);
      this.btnKarte.TabIndex = 0;
      this.btnKarte.Text = "Karte";
      this.btnKarte.UseVisualStyleBackColor = true;
      this.btnKarte.Click += new System.EventHandler(this.btnCard);
      // 
      // btnVerbindung
      // 
      this.btnVerbindung.Location = new System.Drawing.Point(39, 173);
      this.btnVerbindung.Name = "btnVerbindung";
      this.btnVerbindung.Size = new System.Drawing.Size(343, 36);
      this.btnVerbindung.TabIndex = 0;
      this.btnVerbindung.Text = "Verbindungen anzeigen";
      this.btnVerbindung.UseVisualStyleBackColor = true;
      this.btnVerbindung.Click += new System.EventHandler(this.btnOutputShow);
      // 
      // JusttransportBoard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(866, 569);
      this.Controls.Add(this.listConnection);
      this.Controls.Add(this.tableLayoutPanel3);
      this.Controls.Add(this.tp2);
      this.Controls.Add(this.tp1);
      this.Controls.Add(this.btnVerbindung);
      this.Controls.Add(this.btnKarte);
      this.Controls.Add(this.btnConnectionFrom);
      this.Controls.Add(this.btnStartEndConnection);
      this.Name = "JusttransportBoard";
      this.Text = " Justtransport";
      this.tp1.ResumeLayout(false);
      this.tp1.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tp2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnStartEndConnection;
    private System.Windows.Forms.Button btnConnectionFrom;
    private System.Windows.Forms.TableLayoutPanel tp1;
    private System.Windows.Forms.TextBox txtStart;
    private System.Windows.Forms.TextBox txtEnd;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.RadioButton rbStartTime;
    private System.Windows.Forms.RadioButton rbEndTime;
    private System.Windows.Forms.TableLayoutPanel tp2;
    private System.Windows.Forms.DateTimePicker dpTime;
    private System.Windows.Forms.DateTimePicker dpDate;
    private System.Windows.Forms.ListBox listConnection;
    private System.Windows.Forms.Button btnKarte;
    private System.Windows.Forms.Button btnVerbindung;
  }
}