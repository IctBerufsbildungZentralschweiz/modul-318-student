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
            this.button_MapTo = new System.Windows.Forms.Button();
            this.Button_MapFrom = new System.Windows.Forms.Button();
            this.button_Departure = new System.Windows.Forms.Button();
            this.button_Arrive = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Time = new System.Windows.Forms.TextBox();
            this.CmbTo = new System.Windows.Forms.ComboBox();
            this.CmbFrom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectionsListView = new System.Windows.Forms.ListView();
            this.Button_Connection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_Time_Stationboard = new System.Windows.Forms.TextBox();
            this.stationBoardListView = new System.Windows.Forms.ListView();
            this.cmbBoardName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Stationboard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Date_Stationboard = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabPage1.Controls.Add(this.button_MapTo);
            this.tabPage1.Controls.Add(this.Button_MapFrom);
            this.tabPage1.Controls.Add(this.button_Departure);
            this.tabPage1.Controls.Add(this.button_Arrive);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txb_Time);
            this.tabPage1.Controls.Add(this.CmbTo);
            this.tabPage1.Controls.Add(this.CmbFrom);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ConnectionsListView);
            this.tabPage1.Controls.Add(this.Button_Connection);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.DateTimePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_MapTo
            // 
            this.button_MapTo.Location = new System.Drawing.Point(253, 31);
            this.button_MapTo.Name = "button_MapTo";
            this.button_MapTo.Size = new System.Drawing.Size(25, 23);
            this.button_MapTo.TabIndex = 25;
            this.button_MapTo.Text = "i";
            this.button_MapTo.UseVisualStyleBackColor = true;
            this.button_MapTo.Click += new System.EventHandler(this.ButtonMap_Clicked);
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
            // button_Departure
            // 
            this.button_Departure.Location = new System.Drawing.Point(152, 116);
            this.button_Departure.Name = "button_Departure";
            this.button_Departure.Size = new System.Drawing.Size(35, 23);
            this.button_Departure.TabIndex = 23;
            this.button_Departure.Text = "Ab";
            this.button_Departure.UseVisualStyleBackColor = true;
            this.button_Departure.Click += new System.EventHandler(this.Button_Departure_Arrival_Click);
            // 
            // button_Arrive
            // 
            this.button_Arrive.Location = new System.Drawing.Point(117, 116);
            this.button_Arrive.Name = "button_Arrive";
            this.button_Arrive.Size = new System.Drawing.Size(35, 23);
            this.button_Arrive.TabIndex = 22;
            this.button_Arrive.Text = "An";
            this.button_Arrive.UseVisualStyleBackColor = true;
            this.button_Arrive.Click += new System.EventHandler(this.Button_Departure_Arrival_Click);
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
            // txb_Time
            // 
            this.txb_Time.Location = new System.Drawing.Point(195, 118);
            this.txb_Time.Name = "txb_Time";
            this.txb_Time.Size = new System.Drawing.Size(52, 20);
            this.txb_Time.TabIndex = 20;
            // 
            // CmbTo
            // 
            this.CmbTo.FormattingEnabled = true;
            this.CmbTo.Location = new System.Drawing.Point(62, 33);
            this.CmbTo.Name = "CmbTo";
            this.CmbTo.Size = new System.Drawing.Size(185, 21);
            this.CmbTo.TabIndex = 19;
            this.CmbTo.TextChanged += new System.EventHandler(this.Combobox_TextChanged);
            this.CmbTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox_KeyPress);
            // 
            // CmbFrom
            // 
            this.CmbFrom.FormattingEnabled = true;
            this.CmbFrom.Location = new System.Drawing.Point(62, 6);
            this.CmbFrom.Name = "CmbFrom";
            this.CmbFrom.Size = new System.Drawing.Size(185, 21);
            this.CmbFrom.TabIndex = 18;
            this.CmbFrom.TextChanged += new System.EventHandler(this.Combobox_TextChanged);
            this.CmbFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox_KeyPress);
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
            // Button_Connection
            // 
            this.Button_Connection.Location = new System.Drawing.Point(123, 154);
            this.Button_Connection.Name = "Button_Connection";
            this.Button_Connection.Size = new System.Drawing.Size(124, 23);
            this.Button_Connection.TabIndex = 14;
            this.Button_Connection.Text = "Verbindung Suchen";
            this.Button_Connection.UseVisualStyleBackColor = true;
            this.Button_Connection.Click += new System.EventHandler(this.Button_Connection_Click);
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
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(62, 89);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.DateTimePicker.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textbox_Time_Stationboard);
            this.tabPage2.Controls.Add(this.stationBoardListView);
            this.tabPage2.Controls.Add(this.cmbBoardName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Button_Stationboard);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Date_Stationboard);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtsplan";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textbox_Time_Stationboard
            // 
            this.textbox_Time_Stationboard.Location = new System.Drawing.Point(195, 86);
            this.textbox_Time_Stationboard.Name = "textbox_Time_Stationboard";
            this.textbox_Time_Stationboard.Size = new System.Drawing.Size(52, 20);
            this.textbox_Time_Stationboard.TabIndex = 29;
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
            // cmbBoardName
            // 
            this.cmbBoardName.FormattingEnabled = true;
            this.cmbBoardName.Location = new System.Drawing.Point(62, 6);
            this.cmbBoardName.Name = "cmbBoardName";
            this.cmbBoardName.Size = new System.Drawing.Size(185, 21);
            this.cmbBoardName.TabIndex = 26;
            this.cmbBoardName.TextChanged += new System.EventHandler(this.Combobox_TextChanged);
            this.cmbBoardName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox_KeyPress);
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
            // Button_Stationboard
            // 
            this.Button_Stationboard.Location = new System.Drawing.Point(123, 111);
            this.Button_Stationboard.Name = "Button_Stationboard";
            this.Button_Stationboard.Size = new System.Drawing.Size(124, 23);
            this.Button_Stationboard.TabIndex = 24;
            this.Button_Stationboard.Text = "Abfahrten Laden";
            this.Button_Stationboard.UseVisualStyleBackColor = true;
            this.Button_Stationboard.Click += new System.EventHandler(this.Button_Stationboard_Click);
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
            // Date_Stationboard
            // 
            this.Date_Stationboard.Location = new System.Drawing.Point(62, 60);
            this.Date_Stationboard.Name = "Date_Stationboard";
            this.Date_Stationboard.Size = new System.Drawing.Size(185, 20);
            this.Date_Stationboard.TabIndex = 21;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 114);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // ÖV_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 465);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÖV_Application";
            this.Text = "ÖV Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Button_Connection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ConnectionsListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbFrom;
        private System.Windows.Forms.ComboBox CmbTo;
        private System.Windows.Forms.ComboBox cmbBoardName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Stationboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Stationboard;
        private System.Windows.Forms.ListView stationBoardListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Time;
        private System.Windows.Forms.Button button_Departure;
        private System.Windows.Forms.Button button_Arrive;
        private System.Windows.Forms.Button button_MapTo;
        private System.Windows.Forms.Button Button_MapFrom;
        private System.Windows.Forms.TextBox textbox_Time_Stationboard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

