namespace OeV_Application
{
    partial class OeV_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OeV_Application));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_MapTo = new System.Windows.Forms.Button();
            this.Button_MapFrom = new System.Windows.Forms.Button();
            this.Button_Departure = new System.Windows.Forms.Button();
            this.Button_Arrive = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txb_TimeConnection = new System.Windows.Forms.TextBox();
            this.CmbTo_ConnectionSearch = new System.Windows.Forms.ComboBox();
            this.CmbFrom_ConnectionSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectionsListView = new System.Windows.Forms.ListView();
            this.Button_ConnectionSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DateTimeConnection = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_TimeStationboard = new System.Windows.Forms.TextBox();
            this.stationBoardListView = new System.Windows.Forms.ListView();
            this.CmbFrom_StationBoard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_StationboardSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimeStationBoard = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Button_MapTo);
            this.tabPage1.Controls.Add(this.Button_MapFrom);
            this.tabPage1.Controls.Add(this.Button_Departure);
            this.tabPage1.Controls.Add(this.Button_Arrive);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Txb_TimeConnection);
            this.tabPage1.Controls.Add(this.CmbTo_ConnectionSearch);
            this.tabPage1.Controls.Add(this.CmbFrom_ConnectionSearch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ConnectionsListView);
            this.tabPage1.Controls.Add(this.Button_ConnectionSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.DateTimeConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 114);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Button_MapTo
            // 
            this.Button_MapTo.Location = new System.Drawing.Point(253, 31);
            this.Button_MapTo.Name = "Button_MapTo";
            this.Button_MapTo.Size = new System.Drawing.Size(25, 23);
            this.Button_MapTo.TabIndex = 25;
            this.Button_MapTo.Text = "i";
            this.Button_MapTo.UseVisualStyleBackColor = true;
            this.Button_MapTo.Click += new System.EventHandler(this.ButtonMap_Clicked);
            // 
            // Button_MapFrom
            // 
            this.Button_MapFrom.Location = new System.Drawing.Point(253, 4);
            this.Button_MapFrom.Name = "Button_MapFrom";
            this.Button_MapFrom.Size = new System.Drawing.Size(25, 23);
            this.Button_MapFrom.TabIndex = 24;
            this.Button_MapFrom.Text = "i";
            this.Button_MapFrom.UseVisualStyleBackColor = true;
            this.Button_MapFrom.Click += new System.EventHandler(this.ButtonMap_Clicked);
            // 
            // Button_Departure
            // 
            this.Button_Departure.Location = new System.Drawing.Point(152, 116);
            this.Button_Departure.Name = "Button_Departure";
            this.Button_Departure.Size = new System.Drawing.Size(35, 23);
            this.Button_Departure.TabIndex = 23;
            this.Button_Departure.Text = "Ab";
            this.Button_Departure.UseVisualStyleBackColor = true;
            this.Button_Departure.Click += new System.EventHandler(this.Button_Departure_Arrival_Click);
            // 
            // Button_Arrive
            // 
            this.Button_Arrive.Location = new System.Drawing.Point(117, 116);
            this.Button_Arrive.Name = "Button_Arrive";
            this.Button_Arrive.Size = new System.Drawing.Size(35, 23);
            this.Button_Arrive.TabIndex = 22;
            this.Button_Arrive.Text = "An";
            this.Button_Arrive.UseVisualStyleBackColor = true;
            this.Button_Arrive.Click += new System.EventHandler(this.Button_Departure_Arrival_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Uhrzeit";
            // 
            // Txb_TimeConnection
            // 
            this.Txb_TimeConnection.Location = new System.Drawing.Point(195, 118);
            this.Txb_TimeConnection.Name = "Txb_TimeConnection";
            this.Txb_TimeConnection.Size = new System.Drawing.Size(52, 20);
            this.Txb_TimeConnection.TabIndex = 20;
            // 
            // CmbTo_ConnectionSearch
            // 
            this.CmbTo_ConnectionSearch.FormattingEnabled = true;
            this.CmbTo_ConnectionSearch.Location = new System.Drawing.Point(62, 33);
            this.CmbTo_ConnectionSearch.Name = "CmbTo_ConnectionSearch";
            this.CmbTo_ConnectionSearch.Size = new System.Drawing.Size(185, 21);
            this.CmbTo_ConnectionSearch.TabIndex = 19;
            this.CmbTo_ConnectionSearch.TextChanged += new System.EventHandler(this.Combobox_TextChanged);
            this.CmbTo_ConnectionSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox_KeyPress);
            // 
            // CmbFrom_ConnectionSearch
            // 
            this.CmbFrom_ConnectionSearch.FormattingEnabled = true;
            this.CmbFrom_ConnectionSearch.Location = new System.Drawing.Point(62, 6);
            this.CmbFrom_ConnectionSearch.Name = "CmbFrom_ConnectionSearch";
            this.CmbFrom_ConnectionSearch.Size = new System.Drawing.Size(185, 21);
            this.CmbFrom_ConnectionSearch.TabIndex = 18;
            this.CmbFrom_ConnectionSearch.TextChanged += new System.EventHandler(this.Combobox_TextChanged);
            this.CmbFrom_ConnectionSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum";
            // 
            // ConnectionsListView
            // 
            this.ConnectionsListView.Location = new System.Drawing.Point(9, 205);
            this.ConnectionsListView.Name = "ConnectionsListView";
            this.ConnectionsListView.Size = new System.Drawing.Size(417, 216);
            this.ConnectionsListView.TabIndex = 16;
            this.ConnectionsListView.UseCompatibleStateImageBehavior = false;
            this.ConnectionsListView.DoubleClick += new System.EventHandler(this.ListViewItem_DoubleClick);
            // 
            // Button_ConnectionSearch
            // 
            this.Button_ConnectionSearch.Location = new System.Drawing.Point(123, 154);
            this.Button_ConnectionSearch.Name = "Button_ConnectionSearch";
            this.Button_ConnectionSearch.Size = new System.Drawing.Size(124, 23);
            this.Button_ConnectionSearch.TabIndex = 14;
            this.Button_ConnectionSearch.Text = "Verbindung Suchen";
            this.Button_ConnectionSearch.UseVisualStyleBackColor = true;
            this.Button_ConnectionSearch.Click += new System.EventHandler(this.Button_Connection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nach";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Von";
            // 
            // DateTimeConnection
            // 
            this.DateTimeConnection.Location = new System.Drawing.Point(62, 89);
            this.DateTimeConnection.Name = "DateTimeConnection";
            this.DateTimeConnection.Size = new System.Drawing.Size(185, 20);
            this.DateTimeConnection.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Txb_TimeStationboard);
            this.tabPage2.Controls.Add(this.stationBoardListView);
            this.tabPage2.Controls.Add(this.CmbFrom_StationBoard);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Button_StationboardSearch);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.DateTimeStationBoard);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtsplan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 114);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Uhrzeit";
            // 
            // Txb_TimeStationboard
            // 
            this.Txb_TimeStationboard.Location = new System.Drawing.Point(195, 86);
            this.Txb_TimeStationboard.Name = "Txb_TimeStationboard";
            this.Txb_TimeStationboard.Size = new System.Drawing.Size(52, 20);
            this.Txb_TimeStationboard.TabIndex = 29;
            // 
            // stationBoardListView
            // 
            this.stationBoardListView.Location = new System.Drawing.Point(9, 157);
            this.stationBoardListView.Name = "stationBoardListView";
            this.stationBoardListView.Size = new System.Drawing.Size(420, 262);
            this.stationBoardListView.TabIndex = 28;
            this.stationBoardListView.UseCompatibleStateImageBehavior = false;
            this.stationBoardListView.DoubleClick += new System.EventHandler(this.ListViewItem_DoubleClick);
            // 
            // CmbFrom_StationBoard
            // 
            this.CmbFrom_StationBoard.FormattingEnabled = true;
            this.CmbFrom_StationBoard.Location = new System.Drawing.Point(62, 6);
            this.CmbFrom_StationBoard.Name = "CmbFrom_StationBoard";
            this.CmbFrom_StationBoard.Size = new System.Drawing.Size(185, 21);
            this.CmbFrom_StationBoard.TabIndex = 26;
            this.CmbFrom_StationBoard.TextChanged += new System.EventHandler(this.Combobox_TextChanged);
            this.CmbFrom_StationBoard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datum";
            // 
            // Button_StationboardSearch
            // 
            this.Button_StationboardSearch.Location = new System.Drawing.Point(123, 111);
            this.Button_StationboardSearch.Name = "Button_StationboardSearch";
            this.Button_StationboardSearch.Size = new System.Drawing.Size(124, 23);
            this.Button_StationboardSearch.TabIndex = 24;
            this.Button_StationboardSearch.Text = "Abfahrten Laden";
            this.Button_StationboardSearch.UseVisualStyleBackColor = true;
            this.Button_StationboardSearch.Click += new System.EventHandler(this.Button_Stationboard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Von";
            // 
            // DateTimeStationBoard
            // 
            this.DateTimeStationBoard.Location = new System.Drawing.Point(62, 60);
            this.DateTimeStationBoard.Name = "DateTimeStationBoard";
            this.DateTimeStationBoard.Size = new System.Drawing.Size(185, 20);
            this.DateTimeStationBoard.TabIndex = 21;
            // 
            // OeV_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 465);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OeV_Application";
            this.Text = "ÖV Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Button_ConnectionSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker DateTimeConnection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ConnectionsListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbFrom_ConnectionSearch;
        private System.Windows.Forms.ComboBox CmbTo_ConnectionSearch;
        private System.Windows.Forms.ComboBox CmbFrom_StationBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_StationboardSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimeStationBoard;
        private System.Windows.Forms.ListView stationBoardListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txb_TimeConnection;
        private System.Windows.Forms.Button Button_Departure;
        private System.Windows.Forms.Button Button_Arrive;
        private System.Windows.Forms.Button Button_MapTo;
        private System.Windows.Forms.Button Button_MapFrom;
        private System.Windows.Forms.TextBox Txb_TimeStationboard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

