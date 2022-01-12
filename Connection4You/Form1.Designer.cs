namespace Connection4You
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.labelFirmTitle = new System.Windows.Forms.Label();
            this.dgvFromToSearch = new System.Windows.Forms.DataGridView();
            this.fromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnChangeFromAndTo = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cbToLocation = new System.Windows.Forms.ComboBox();
            this.cbFromLocation = new System.Windows.Forms.ComboBox();
            this.labelGetConnection = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbSearchStation = new System.Windows.Forms.ComboBox();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.dgvSearchByStation = new System.Windows.Forms.DataGridView();
            this.columnDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromToSearch)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchByStation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(280, 83);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(157, 62);
            this.btnSearchConnection.TabIndex = 0;
            this.btnSearchConnection.Text = "Search Connection";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.SearchConnection);
            // 
            // labelFirmTitle
            // 
            this.labelFirmTitle.AutoSize = true;
            this.labelFirmTitle.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirmTitle.Location = new System.Drawing.Point(12, 9);
            this.labelFirmTitle.Name = "labelFirmTitle";
            this.labelFirmTitle.Size = new System.Drawing.Size(183, 32);
            this.labelFirmTitle.TabIndex = 3;
            this.labelFirmTitle.Text = "SteamVac AG";
            // 
            // dgvFromToSearch
            // 
            this.dgvFromToSearch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFromToSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFromToSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColumn,
            this.toColumn,
            this.departure,
            this.Arrival});
            this.dgvFromToSearch.Location = new System.Drawing.Point(3, 151);
            this.dgvFromToSearch.Name = "dgvFromToSearch";
            this.dgvFromToSearch.RowHeadersWidth = 51;
            this.dgvFromToSearch.RowTemplate.Height = 29;
            this.dgvFromToSearch.Size = new System.Drawing.Size(854, 202);
            this.dgvFromToSearch.TabIndex = 4;
            // 
            // fromColumn
            // 
            this.fromColumn.HeaderText = "From";
            this.fromColumn.MinimumWidth = 6;
            this.fromColumn.Name = "fromColumn";
            this.fromColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fromColumn.Width = 200;
            // 
            // toColumn
            // 
            this.toColumn.HeaderText = "To";
            this.toColumn.MinimumWidth = 6;
            this.toColumn.Name = "toColumn";
            this.toColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toColumn.Width = 200;
            // 
            // departure
            // 
            this.departure.HeaderText = "Departure";
            this.departure.MinimumWidth = 6;
            this.departure.Name = "departure";
            this.departure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.departure.Width = 200;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 200;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(6, 86);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(43, 20);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(6, 120);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 20);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "To";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(6, 54);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 20);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // btnChangeFromAndTo
            // 
            this.btnChangeFromAndTo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeFromAndTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeFromAndTo.Location = new System.Drawing.Point(226, 82);
            this.btnChangeFromAndTo.Name = "btnChangeFromAndTo";
            this.btnChangeFromAndTo.Size = new System.Drawing.Size(48, 63);
            this.btnChangeFromAndTo.TabIndex = 11;
            this.btnChangeFromAndTo.Text = "⇵";
            this.btnChangeFromAndTo.UseVisualStyleBackColor = true;
            this.btnChangeFromAndTo.Click += new System.EventHandler(this.ChangeFromAndToText);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1158, 492);
            this.tabControl.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpFromTime);
            this.tabPage1.Controls.Add(this.dtpFromDate);
            this.tabPage1.Controls.Add(this.cbToLocation);
            this.tabPage1.Controls.Add(this.cbFromLocation);
            this.tabPage1.Controls.Add(this.labelGetConnection);
            this.tabPage1.Controls.Add(this.dgvFromToSearch);
            this.tabPage1.Controls.Add(this.btnChangeFromAndTo);
            this.tabPage1.Controls.Add(this.btnSearchConnection);
            this.tabPage1.Controls.Add(this.labelTime);
            this.tabPage1.Controls.Add(this.labelFrom);
            this.tabPage1.Controls.Add(this.labelTo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "From-To-Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFromTime.Location = new System.Drawing.Point(185, 49);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.Size = new System.Drawing.Size(78, 27);
            this.dtpFromTime.TabIndex = 16;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(57, 50);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(122, 27);
            this.dtpFromDate.TabIndex = 15;
            // 
            // cbToLocation
            // 
            this.cbToLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbToLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbToLocation.FormattingEnabled = true;
            this.cbToLocation.Location = new System.Drawing.Point(55, 117);
            this.cbToLocation.Name = "cbToLocation";
            this.cbToLocation.Size = new System.Drawing.Size(165, 28);
            this.cbToLocation.TabIndex = 14;
            this.cbToLocation.TextChanged += new System.EventHandler(this.loadComboboxToSuggestions);
            // 
            // cbFromLocation
            // 
            this.cbFromLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFromLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFromLocation.FormattingEnabled = true;
            this.cbFromLocation.Location = new System.Drawing.Point(55, 83);
            this.cbFromLocation.Name = "cbFromLocation";
            this.cbFromLocation.Size = new System.Drawing.Size(165, 28);
            this.cbFromLocation.TabIndex = 13;
            this.cbFromLocation.TextChanged += new System.EventHandler(this.loadComboboxFromSuggestions);
            // 
            // labelGetConnection
            // 
            this.labelGetConnection.AutoSize = true;
            this.labelGetConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelGetConnection.Location = new System.Drawing.Point(6, 7);
            this.labelGetConnection.Name = "labelGetConnection";
            this.labelGetConnection.Size = new System.Drawing.Size(193, 28);
            this.labelGetConnection.TabIndex = 12;
            this.labelGetConnection.Text = "Get your Connection";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbSearchStation);
            this.tabPage2.Controls.Add(this.btnSearchStation);
            this.tabPage2.Controls.Add(this.dgvSearchByStation);
            this.tabPage2.Controls.Add(this.labelStation);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search by Station";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbSearchStation
            // 
            this.cbSearchStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearchStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchStation.FormattingEnabled = true;
            this.cbSearchStation.Location = new System.Drawing.Point(6, 26);
            this.cbSearchStation.Name = "cbSearchStation";
            this.cbSearchStation.Size = new System.Drawing.Size(248, 28);
            this.cbSearchStation.TabIndex = 7;
            this.cbSearchStation.TextChanged += new System.EventHandler(this.loadComboboxSearchStationSuggestions);
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Location = new System.Drawing.Point(260, 24);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(115, 29);
            this.btnSearchStation.TabIndex = 6;
            this.btnSearchStation.Text = "Search Station";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.searchStation);
            // 
            // dgvSearchByStation
            // 
            this.dgvSearchByStation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSearchByStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchByStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDestination,
            this.columnType,
            this.columnProvider});
            this.dgvSearchByStation.GridColor = System.Drawing.SystemColors.Window;
            this.dgvSearchByStation.Location = new System.Drawing.Point(6, 60);
            this.dgvSearchByStation.Name = "dgvSearchByStation";
            this.dgvSearchByStation.RowHeadersWidth = 51;
            this.dgvSearchByStation.RowTemplate.Height = 29;
            this.dgvSearchByStation.Size = new System.Drawing.Size(654, 245);
            this.dgvSearchByStation.TabIndex = 5;
            // 
            // columnDestination
            // 
            this.columnDestination.HeaderText = "Destination";
            this.columnDestination.MinimumWidth = 6;
            this.columnDestination.Name = "columnDestination";
            this.columnDestination.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnDestination.Width = 200;
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Type";
            this.columnType.MinimumWidth = 6;
            this.columnType.Name = "columnType";
            this.columnType.Width = 200;
            // 
            // columnProvider
            // 
            this.columnProvider.HeaderText = "Provider";
            this.columnProvider.MinimumWidth = 6;
            this.columnProvider.Name = "columnProvider";
            this.columnProvider.Width = 200;
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(6, 3);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(56, 20);
            this.labelStation.TabIndex = 0;
            this.labelStation.Text = "Station";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 551);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelFirmTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Connections4You";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromToSearch)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchByStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearchConnection;
        private Label labelFirmTitle;
        private DataGridView dgvFromToSearch;
        private Label labelFrom;
        private Label labelTo;
        private Label labelTime;
        private Button btnChangeFromAndTo;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelGetConnection;
        private Label labelStation;
        private DataGridView dgvSearchByStation;
        private Button btnSearchStation;
        private ComboBox cbToLocation;
        private ComboBox cbSearchStation;
        private ComboBox cbFromLocation;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpFromTime;
        private DataGridViewTextBoxColumn fromColumn;
        private DataGridViewTextBoxColumn toColumn;
        private DataGridViewTextBoxColumn departure;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn columnDestination;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnProvider;
    }
}