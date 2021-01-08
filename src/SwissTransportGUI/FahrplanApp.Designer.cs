namespace SwissTransportGUI
{
    partial class FahrplanApp
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lv_Connections = new System.Windows.Forms.ListView();
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Time = new System.Windows.Forms.TextBox();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time_ = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Cb_ConnectionTo = new System.Windows.Forms.ComboBox();
            this.Lbl_ConnectionTo = new System.Windows.Forms.Label();
            this.Lbl_ConnectionFrom = new System.Windows.Forms.Label();
            this.Cb_ConnectionFrom = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Search_DepBoard = new System.Windows.Forms.Button();
            this.lv_DepartureBoard = new System.Windows.Forms.ListView();
            this.cDepTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lbl_ConectionsFromDepBoard = new System.Windows.Forms.Label();
            this.Cb_ConnectionsFromDepBoard = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(18, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1797, 1050);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lv_Connections);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 45);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1781, 997);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungssuche";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lv_Connections
            // 
            this.Lv_Connections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDate,
            this.cDepartureTime,
            this.cDepartureStation,
            this.cArrivalStation,
            this.cArrivalTime,
            this.cDuration,
            this.cPlatform});
            this.Lv_Connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Connections.HideSelection = false;
            this.Lv_Connections.Location = new System.Drawing.Point(9, 312);
            this.Lv_Connections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lv_Connections.Name = "Lv_Connections";
            this.Lv_Connections.Size = new System.Drawing.Size(1765, 679);
            this.Lv_Connections.TabIndex = 8;
            this.Lv_Connections.TabStop = false;
            this.Lv_Connections.UseCompatibleStateImageBehavior = false;
            this.Lv_Connections.View = System.Windows.Forms.View.Details;
            this.Lv_Connections.SelectedIndexChanged += new System.EventHandler(this.Lv_Connections_SelectedIndexChanged);
            // 
            // cDate
            // 
            this.cDate.Text = "Datum";
            this.cDate.Width = 100;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Abfahrtszeit";
            this.cDepartureTime.Width = 153;
            // 
            // cDepartureStation
            // 
            this.cDepartureStation.Text = "Abfahrtsort";
            this.cDepartureStation.Width = 200;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Ankunft";
            this.cArrivalStation.Width = 200;
            // 
            // cArrivalTime
            // 
            this.cArrivalTime.Text = "Ankunft";
            this.cArrivalTime.Width = 143;
            // 
            // cDuration
            // 
            this.cDuration.Text = "Dauer";
            this.cDuration.Width = 100;
            // 
            // cPlatform
            // 
            this.cPlatform.Text = "Gleis";
            this.cPlatform.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Time);
            this.groupBox2.Controls.Add(this.Lbl_Time);
            this.groupBox2.Controls.Add(this.Lbl_Date);
            this.groupBox2.Controls.Add(this.Dtp_Date);
            this.groupBox2.Location = new System.Drawing.Point(9, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1766, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erweiterte Angaben";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Txt_Time
            // 
            this.Txt_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Time.Location = new System.Drawing.Point(592, 73);
            this.Txt_Time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Time.Name = "Txt_Time";
            this.Txt_Time.Size = new System.Drawing.Size(234, 38);
            this.Txt_Time.TabIndex = 7;
            this.Txt_Time.Text = "HH:mm";
            this.Txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Time.TextChanged += new System.EventHandler(this.Txt_Time_TextChanged);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(586, 38);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(71, 32);
            this.Lbl_Time.TabIndex = 6;
            this.Lbl_Time.Text = "Zeit:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(38, 38);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(106, 32);
            this.Lbl_Date.TabIndex = 5;
            this.Lbl_Date.Text = "Datum:";
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Location = new System.Drawing.Point(40, 75);
            this.Dtp_Date.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(493, 38);
            this.Dtp_Date.TabIndex = 0;
            this.Dtp_Date.ValueChanged += new System.EventHandler(this.Dtp_Date_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.time_);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.Cb_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionFrom);
            this.groupBox1.Controls.Add(this.Cb_ConnectionFrom);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1770, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angaben";
            // 
            // time_
            // 
            this.time_.AutoSize = true;
            this.time_.Location = new System.Drawing.Point(1364, 36);
            this.time_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_.Name = "time_";
            this.time_.Size = new System.Drawing.Size(181, 32);
            this.time_.TabIndex = 10;
            this.time_.Text = "Aktuelle Zeit:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(1364, 81);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(63, 32);
            this.time.TabIndex = 9;
            this.time.Text = "Zeit";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Btn_Search.Location = new System.Drawing.Point(906, 70);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(376, 53);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Suchen";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Cb_ConnectionTo
            // 
            this.Cb_ConnectionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Cb_ConnectionTo.FormattingEnabled = true;
            this.Cb_ConnectionTo.Location = new System.Drawing.Point(465, 77);
            this.Cb_ConnectionTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cb_ConnectionTo.Name = "Cb_ConnectionTo";
            this.Cb_ConnectionTo.Size = new System.Drawing.Size(364, 39);
            this.Cb_ConnectionTo.TabIndex = 3;
            this.Cb_ConnectionTo.TextUpdate += new System.EventHandler(this.Cb_ConnectionTo_TextUpdate);
            // 
            // Lbl_ConnectionTo
            // 
            this.Lbl_ConnectionTo.AutoSize = true;
            this.Lbl_ConnectionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Lbl_ConnectionTo.Location = new System.Drawing.Point(459, 36);
            this.Lbl_ConnectionTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ConnectionTo.Name = "Lbl_ConnectionTo";
            this.Lbl_ConnectionTo.Size = new System.Drawing.Size(89, 32);
            this.Lbl_ConnectionTo.TabIndex = 2;
            this.Lbl_ConnectionTo.Text = "Nach:";
            // 
            // Lbl_ConnectionFrom
            // 
            this.Lbl_ConnectionFrom.AutoSize = true;
            this.Lbl_ConnectionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Lbl_ConnectionFrom.Location = new System.Drawing.Point(38, 36);
            this.Lbl_ConnectionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ConnectionFrom.Name = "Lbl_ConnectionFrom";
            this.Lbl_ConnectionFrom.Size = new System.Drawing.Size(74, 32);
            this.Lbl_ConnectionFrom.TabIndex = 1;
            this.Lbl_ConnectionFrom.Text = "Von:";
            // 
            // Cb_ConnectionFrom
            // 
            this.Cb_ConnectionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Cb_ConnectionFrom.FormattingEnabled = true;
            this.Cb_ConnectionFrom.Location = new System.Drawing.Point(44, 77);
            this.Cb_ConnectionFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cb_ConnectionFrom.Name = "Cb_ConnectionFrom";
            this.Cb_ConnectionFrom.Size = new System.Drawing.Size(364, 39);
            this.Cb_ConnectionFrom.TabIndex = 0;
            this.Cb_ConnectionFrom.SelectedIndexChanged += new System.EventHandler(this.Cb_ConnectionFrom_SelectedIndexChanged);
            this.Cb_ConnectionFrom.TextUpdate += new System.EventHandler(this.Cb_ConnectionFrom_TextUpdate);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Search_DepBoard);
            this.tabPage2.Controls.Add(this.lv_DepartureBoard);
            this.tabPage2.Controls.Add(this.Lbl_ConectionsFromDepBoard);
            this.tabPage2.Controls.Add(this.Cb_ConnectionsFromDepBoard);
            this.tabPage2.Location = new System.Drawing.Point(8, 45);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1781, 997);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtsübersicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Search_DepBoard
            // 
            this.Btn_Search_DepBoard.Location = new System.Drawing.Point(634, 36);
            this.Btn_Search_DepBoard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btn_Search_DepBoard.Name = "Btn_Search_DepBoard";
            this.Btn_Search_DepBoard.Size = new System.Drawing.Size(342, 52);
            this.Btn_Search_DepBoard.TabIndex = 10;
            this.Btn_Search_DepBoard.Text = "Suchen";
            this.Btn_Search_DepBoard.UseVisualStyleBackColor = true;
            this.Btn_Search_DepBoard.Click += new System.EventHandler(this.Btn_Search_DepBoard_Click);
            // 
            // lv_DepartureBoard
            // 
            this.lv_DepartureBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepTime,
            this.cDestination,
            this.cDesignation});
            this.lv_DepartureBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DepartureBoard.HideSelection = false;
            this.lv_DepartureBoard.Location = new System.Drawing.Point(14, 98);
            this.lv_DepartureBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_DepartureBoard.Name = "lv_DepartureBoard";
            this.lv_DepartureBoard.Size = new System.Drawing.Size(1753, 888);
            this.lv_DepartureBoard.TabIndex = 9;
            this.lv_DepartureBoard.TabStop = false;
            this.lv_DepartureBoard.UseCompatibleStateImageBehavior = false;
            this.lv_DepartureBoard.View = System.Windows.Forms.View.Details;
            // 
            // cDepTime
            // 
            this.cDepTime.Text = "Abfahrt";
            this.cDepTime.Width = 150;
            // 
            // cDestination
            // 
            this.cDestination.Text = "Richtung";
            this.cDestination.Width = 200;
            // 
            // cDesignation
            // 
            this.cDesignation.Text = "Linie";
            this.cDesignation.Width = 150;
            // 
            // Lbl_ConectionsFromDepBoard
            // 
            this.Lbl_ConectionsFromDepBoard.AutoSize = true;
            this.Lbl_ConectionsFromDepBoard.Location = new System.Drawing.Point(9, 5);
            this.Lbl_ConectionsFromDepBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ConectionsFromDepBoard.Name = "Lbl_ConectionsFromDepBoard";
            this.Lbl_ConectionsFromDepBoard.Size = new System.Drawing.Size(162, 32);
            this.Lbl_ConectionsFromDepBoard.TabIndex = 3;
            this.Lbl_ConectionsFromDepBoard.Text = "Abfahrtsort:";
            // 
            // Cb_ConnectionsFromDepBoard
            // 
            this.Cb_ConnectionsFromDepBoard.FormattingEnabled = true;
            this.Cb_ConnectionsFromDepBoard.Location = new System.Drawing.Point(14, 38);
            this.Cb_ConnectionsFromDepBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cb_ConnectionsFromDepBoard.Name = "Cb_ConnectionsFromDepBoard";
            this.Cb_ConnectionsFromDepBoard.Size = new System.Drawing.Size(608, 39);
            this.Cb_ConnectionsFromDepBoard.TabIndex = 2;
            this.Cb_ConnectionsFromDepBoard.TextUpdate += new System.EventHandler(this.Cb_ConnectionsFromDepBoard_TextUpdate);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FahrplanApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1833, 1072);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FahrplanApp";
            this.Text = "328";
            this.Load += new System.EventHandler(this.SwissTransportApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_ConnectionTo;
        private System.Windows.Forms.Label Lbl_ConnectionTo;
        private System.Windows.Forms.Label Lbl_ConnectionFrom;
        private System.Windows.Forms.ComboBox Cb_ConnectionFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Label Lbl_ConectionsFromDepBoard;
        private System.Windows.Forms.ComboBox Cb_ConnectionsFromDepBoard;
        private System.Windows.Forms.ListView Lv_Connections;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cDepartureStation;
        private System.Windows.Forms.ColumnHeader cArrivalStation;
        private System.Windows.Forms.ColumnHeader cArrivalTime;
        private System.Windows.Forms.ColumnHeader cDuration;
        private System.Windows.Forms.ColumnHeader cPlatform;
        private System.Windows.Forms.TextBox Txt_Time;
        private System.Windows.Forms.ListView lv_DepartureBoard;
        private System.Windows.Forms.ColumnHeader cDepTime;
        private System.Windows.Forms.ColumnHeader cDestination;
        private System.Windows.Forms.Button Btn_Search_DepBoard;
        private System.Windows.Forms.ColumnHeader cDesignation;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_;
    }
}

