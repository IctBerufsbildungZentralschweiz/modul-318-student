namespace Justtransport
{
  partial class Justtransport
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.startEnd = new System.Windows.Forms.TabPage();
      this.btnVerbin = new System.Windows.Forms.Button();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.rbAbfahrt = new System.Windows.Forms.RadioButton();
      this.rbAnkunft = new System.Windows.Forms.RadioButton();
      this.tp2 = new System.Windows.Forms.TableLayoutPanel();
      this.dpTime = new System.Windows.Forms.DateTimePicker();
      this.dpDate = new System.Windows.Forms.DateTimePicker();
      this.tp1 = new System.Windows.Forms.TableLayoutPanel();
      this.txtStartort = new System.Windows.Forms.TextBox();
      this.txtEndort = new System.Windows.Forms.TextBox();
      this.btnKarte = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.rbAbfahrt2 = new System.Windows.Forms.RadioButton();
      this.rbAnkunft2 = new System.Windows.Forms.RadioButton();
      this.btnVerbindung2 = new System.Windows.Forms.Button();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.dpTime2 = new System.Windows.Forms.DateTimePicker();
      this.dpDate2 = new System.Windows.Forms.DateTimePicker();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.txtAbfahrtort = new System.Windows.Forms.TextBox();
      this.btnKarte2 = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.startEnd.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tp2.SuspendLayout();
      this.tp1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel6.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.tabControl1.Controls.Add(this.startEnd);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(5, 4);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(789, 347);
      this.tabControl1.TabIndex = 0;
      // 
      // startEnd
      // 
      this.startEnd.BackColor = System.Drawing.Color.Gainsboro;
      this.startEnd.Controls.Add(this.btnVerbin);
      this.startEnd.Controls.Add(this.tableLayoutPanel3);
      this.startEnd.Controls.Add(this.tp2);
      this.startEnd.Controls.Add(this.tp1);
      this.startEnd.Location = new System.Drawing.Point(4, 29);
      this.startEnd.Name = "startEnd";
      this.startEnd.Padding = new System.Windows.Forms.Padding(3);
      this.startEnd.Size = new System.Drawing.Size(781, 314);
      this.startEnd.TabIndex = 0;
      this.startEnd.Text = "Start und Ende";
      // 
      // btnVerbin
      // 
      this.btnVerbin.BackColor = System.Drawing.Color.Silver;
      this.btnVerbin.Location = new System.Drawing.Point(411, 248);
      this.btnVerbin.Name = "btnVerbin";
      this.btnVerbin.Size = new System.Drawing.Size(336, 36);
      this.btnVerbin.TabIndex = 16;
      this.btnVerbin.Text = "Verbindungen anzeigen";
      this.btnVerbin.UseVisualStyleBackColor = false;
      this.btnVerbin.Click += new System.EventHandler(this.BtnVerbindung);
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14837F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85163F));
      this.tableLayoutPanel3.Controls.Add(this.rbAbfahrt, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.rbAnkunft, 1, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(411, 122);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(339, 38);
      this.tableLayoutPanel3.TabIndex = 15;
      // 
      // rbAbfahrt
      // 
      this.rbAbfahrt.AutoSize = true;
      this.rbAbfahrt.Location = new System.Drawing.Point(3, 3);
      this.rbAbfahrt.Name = "rbAbfahrt";
      this.rbAbfahrt.Size = new System.Drawing.Size(87, 24);
      this.rbAbfahrt.TabIndex = 4;
      this.rbAbfahrt.TabStop = true;
      this.rbAbfahrt.Text = "Abfahrt";
      this.rbAbfahrt.UseVisualStyleBackColor = true;
      // 
      // rbAnkunft
      // 
      this.rbAnkunft.AutoSize = true;
      this.rbAnkunft.Location = new System.Drawing.Point(173, 3);
      this.rbAnkunft.Name = "rbAnkunft";
      this.rbAnkunft.Size = new System.Drawing.Size(90, 24);
      this.rbAnkunft.TabIndex = 4;
      this.rbAnkunft.TabStop = true;
      this.rbAnkunft.Text = "Ankunft";
      this.rbAnkunft.UseVisualStyleBackColor = true;
      // 
      // tp2
      // 
      this.tp2.ColumnCount = 1;
      this.tp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp2.Controls.Add(this.dpTime, 0, 1);
      this.tp2.Controls.Add(this.dpDate, 0, 0);
      this.tp2.Location = new System.Drawing.Point(411, 13);
      this.tp2.Name = "tp2";
      this.tp2.RowCount = 2;
      this.tp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp2.Size = new System.Drawing.Size(339, 103);
      this.tp2.TabIndex = 14;
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
      // tp1
      // 
      this.tp1.ColumnCount = 1;
      this.tp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tp1.Controls.Add(this.txtStartort, 0, 0);
      this.tp1.Controls.Add(this.txtEndort, 0, 1);
      this.tp1.Controls.Add(this.btnKarte, 0, 2);
      this.tp1.Location = new System.Drawing.Point(30, 13);
      this.tp1.Name = "tp1";
      this.tp1.RowCount = 3;
      this.tp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.67241F));
      this.tp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.32758F));
      this.tp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tp1.Size = new System.Drawing.Size(343, 288);
      this.tp1.TabIndex = 13;
      // 
      // txtStartort
      // 
      this.txtStartort.Location = new System.Drawing.Point(3, 3);
      this.txtStartort.Name = "txtStartort";
      this.txtStartort.Size = new System.Drawing.Size(279, 26);
      this.txtStartort.TabIndex = 1;
      this.txtStartort.Text = "Startort eingeben";
      this.txtStartort.Click += new System.EventHandler(this.txtclear);
      // 
      // txtEndort
      // 
      this.txtEndort.Location = new System.Drawing.Point(3, 44);
      this.txtEndort.Name = "txtEndort";
      this.txtEndort.Size = new System.Drawing.Size(279, 26);
      this.txtEndort.TabIndex = 1;
      this.txtEndort.Text = "Endort eingeben";
      this.txtEndort.Click += new System.EventHandler(this.txtclear2);
      // 
      // btnKarte
      // 
      this.btnKarte.BackColor = System.Drawing.Color.Silver;
      this.btnKarte.Location = new System.Drawing.Point(3, 235);
      this.btnKarte.Name = "btnKarte";
      this.btnKarte.Size = new System.Drawing.Size(279, 36);
      this.btnKarte.TabIndex = 12;
      this.btnKarte.Text = "Karte anzeigen";
      this.btnKarte.UseVisualStyleBackColor = false;
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
      this.tabPage2.Controls.Add(this.tableLayoutPanel4);
      this.tabPage2.Controls.Add(this.btnVerbindung2);
      this.tabPage2.Controls.Add(this.tableLayoutPanel5);
      this.tabPage2.Controls.Add(this.tableLayoutPanel6);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(781, 314);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Abfahrt von";
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14837F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85163F));
      this.tableLayoutPanel4.Controls.Add(this.rbAbfahrt2, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.rbAnkunft2, 1, 0);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(411, 122);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(339, 38);
      this.tableLayoutPanel4.TabIndex = 15;
      // 
      // rbAbfahrt2
      // 
      this.rbAbfahrt2.AutoSize = true;
      this.rbAbfahrt2.Location = new System.Drawing.Point(3, 3);
      this.rbAbfahrt2.Name = "rbAbfahrt2";
      this.rbAbfahrt2.Size = new System.Drawing.Size(87, 24);
      this.rbAbfahrt2.TabIndex = 4;
      this.rbAbfahrt2.TabStop = true;
      this.rbAbfahrt2.Text = "Abfahrt";
      this.rbAbfahrt2.UseVisualStyleBackColor = true;
      // 
      // rbAnkunft2
      // 
      this.rbAnkunft2.AutoSize = true;
      this.rbAnkunft2.Location = new System.Drawing.Point(173, 3);
      this.rbAnkunft2.Name = "rbAnkunft2";
      this.rbAnkunft2.Size = new System.Drawing.Size(90, 24);
      this.rbAnkunft2.TabIndex = 4;
      this.rbAnkunft2.TabStop = true;
      this.rbAnkunft2.Text = "Ankunft";
      this.rbAnkunft2.UseVisualStyleBackColor = true;
      // 
      // btnVerbindung2
      // 
      this.btnVerbindung2.BackColor = System.Drawing.Color.Silver;
      this.btnVerbindung2.Location = new System.Drawing.Point(411, 248);
      this.btnVerbindung2.Name = "btnVerbindung2";
      this.btnVerbindung2.Size = new System.Drawing.Size(336, 36);
      this.btnVerbindung2.TabIndex = 0;
      this.btnVerbindung2.Text = "Verbindungen anzeigen";
      this.btnVerbindung2.UseVisualStyleBackColor = false;
      this.btnVerbindung2.Click += new System.EventHandler(this.BtnVerbindung2);
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 1;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel5.Controls.Add(this.dpTime2, 0, 1);
      this.tableLayoutPanel5.Controls.Add(this.dpDate2, 0, 0);
      this.tableLayoutPanel5.Location = new System.Drawing.Point(411, 13);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 2;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(339, 103);
      this.tableLayoutPanel5.TabIndex = 14;
      // 
      // dpTime2
      // 
      this.dpTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dpTime2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dpTime2.Location = new System.Drawing.Point(174, 54);
      this.dpTime2.Name = "dpTime2";
      this.dpTime2.Size = new System.Drawing.Size(162, 26);
      this.dpTime2.TabIndex = 3;
      // 
      // dpDate2
      // 
      this.dpDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dpDate2.Location = new System.Drawing.Point(174, 3);
      this.dpDate2.Name = "dpDate2";
      this.dpDate2.Size = new System.Drawing.Size(162, 26);
      this.dpDate2.TabIndex = 2;
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.ColumnCount = 1;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.Controls.Add(this.txtAbfahrtort, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnKarte2, 0, 2);
      this.tableLayoutPanel6.Location = new System.Drawing.Point(30, 13);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 3;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.67241F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.32758F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(343, 288);
      this.tableLayoutPanel6.TabIndex = 13;
      // 
      // txtAbfahrtort
      // 
      this.txtAbfahrtort.Location = new System.Drawing.Point(3, 3);
      this.txtAbfahrtort.Name = "txtAbfahrtort";
      this.txtAbfahrtort.Size = new System.Drawing.Size(279, 26);
      this.txtAbfahrtort.TabIndex = 1;
      this.txtAbfahrtort.Text = "Startort eingeben";
      // 
      // btnKarte2
      // 
      this.btnKarte2.BackColor = System.Drawing.Color.Silver;
      this.btnKarte2.Location = new System.Drawing.Point(3, 235);
      this.btnKarte2.Name = "btnKarte2";
      this.btnKarte2.Size = new System.Drawing.Size(279, 36);
      this.btnKarte2.TabIndex = 12;
      this.btnKarte2.Text = "Karte anzeigen";
      this.btnKarte2.UseVisualStyleBackColor = false;
      // 
      // Justtransport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 359);
      this.Controls.Add(this.tabControl1);
      this.Name = "Justtransport";
      this.Text = "Justtransport";
      this.tabControl1.ResumeLayout(false);
      this.startEnd.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tp2.ResumeLayout(false);
      this.tp1.ResumeLayout(false);
      this.tp1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel6.ResumeLayout(false);
      this.tableLayoutPanel6.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage startEnd;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.RadioButton rbAbfahrt2;
    private System.Windows.Forms.RadioButton rbAnkunft2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.DateTimePicker dpTime2;
    private System.Windows.Forms.DateTimePicker dpDate2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TextBox txtAbfahrtort;
    private System.Windows.Forms.Button btnVerbindung2;
    private System.Windows.Forms.Button btnKarte2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.RadioButton rbAbfahrt;
    private System.Windows.Forms.RadioButton rbAnkunft;
    private System.Windows.Forms.TableLayoutPanel tp2;
    private System.Windows.Forms.DateTimePicker dpTime;
    private System.Windows.Forms.DateTimePicker dpDate;
    private System.Windows.Forms.TableLayoutPanel tp1;
    private System.Windows.Forms.TextBox txtStartort;
    private System.Windows.Forms.TextBox txtEndort;
    private System.Windows.Forms.Button btnVerbindung;
    private System.Windows.Forms.Button btnKarte;
    private System.Windows.Forms.Button btnVerbin;
  }
}