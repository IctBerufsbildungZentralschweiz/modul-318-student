namespace Loesung_Projekt_318
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblVonStation = new System.Windows.Forms.Label();
			this.txtFromStation = new System.Windows.Forms.TextBox();
			this.cmbFromStation = new System.Windows.Forms.ComboBox();
			this.txtToStation = new System.Windows.Forms.TextBox();
			this.cmbToStation = new System.Windows.Forms.ComboBox();
			this.lblToPosition = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.tpFromDate = new System.Windows.Forms.DateTimePicker();
			this.grpArrivalOrDepart = new System.Windows.Forms.GroupBox();
			this.optIsDeparture = new System.Windows.Forms.RadioButton();
			this.optIsArrival = new System.Windows.Forms.RadioButton();
			this.lblTime = new System.Windows.Forms.Label();
			this.tpFromTime = new System.Windows.Forms.DateTimePicker();
			this.btnDeleteStation = new System.Windows.Forms.Button();
			this.btnSearchForConnections = new System.Windows.Forms.Button();
			this.lblConnections = new System.Windows.Forms.Label();
			this.lvConnections = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblDelete = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
			this.grpArrivalOrDepart.SuspendLayout();
			this.SuspendLayout();
			// 
			// transportBindingSource
			// 
			this.transportBindingSource.DataSource = typeof(SwissTransport.Transport);
			// 
			// lblVonStation
			// 
			this.lblVonStation.AutoSize = true;
			this.lblVonStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVonStation.Location = new System.Drawing.Point(60, 55);
			this.lblVonStation.Name = "lblVonStation";
			this.lblVonStation.Size = new System.Drawing.Size(43, 20);
			this.lblVonStation.TabIndex = 21;
			this.lblVonStation.Text = "Von:";
			// 
			// txtFromStation
			// 
			this.txtFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.txtFromStation.Location = new System.Drawing.Point(126, 55);
			this.txtFromStation.Margin = new System.Windows.Forms.Padding(4);
			this.txtFromStation.Name = "txtFromStation";
			this.txtFromStation.Size = new System.Drawing.Size(425, 27);
			this.txtFromStation.TabIndex = 22;
			// 
			// cmbFromStation
			// 
			this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbFromStation.FormattingEnabled = true;
			this.cmbFromStation.Location = new System.Drawing.Point(126, 102);
			this.cmbFromStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbFromStation.Name = "cmbFromStation";
			this.cmbFromStation.Size = new System.Drawing.Size(425, 28);
			this.cmbFromStation.TabIndex = 23;
			// 
			// txtToStation
			// 
			this.txtToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.txtToStation.Location = new System.Drawing.Point(126, 165);
			this.txtToStation.Margin = new System.Windows.Forms.Padding(4);
			this.txtToStation.Name = "txtToStation";
			this.txtToStation.Size = new System.Drawing.Size(425, 27);
			this.txtToStation.TabIndex = 24;
			// 
			// cmbToStation
			// 
			this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbToStation.FormattingEnabled = true;
			this.cmbToStation.Location = new System.Drawing.Point(126, 200);
			this.cmbToStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbToStation.Name = "cmbToStation";
			this.cmbToStation.Size = new System.Drawing.Size(425, 28);
			this.cmbToStation.TabIndex = 26;
			// 
			// lblToPosition
			// 
			this.lblToPosition.AutoSize = true;
			this.lblToPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToPosition.Location = new System.Drawing.Point(54, 169);
			this.lblToPosition.Name = "lblToPosition";
			this.lblToPosition.Size = new System.Drawing.Size(58, 20);
			this.lblToPosition.TabIndex = 25;
			this.lblToPosition.Text = "Nach: ";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(54, 288);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(64, 20);
			this.lblDate.TabIndex = 32;
			this.lblDate.Text = "Datum:";
			// 
			// tpFromDate
			// 
			this.tpFromDate.Checked = false;
			this.tpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tpFromDate.Location = new System.Drawing.Point(126, 289);
			this.tpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpFromDate.Name = "tpFromDate";
			this.tpFromDate.Size = new System.Drawing.Size(212, 27);
			this.tpFromDate.TabIndex = 33;
			// 
			// grpArrivalOrDepart
			// 
			this.grpArrivalOrDepart.Controls.Add(this.optIsDeparture);
			this.grpArrivalOrDepart.Controls.Add(this.optIsArrival);
			this.grpArrivalOrDepart.Location = new System.Drawing.Point(609, 270);
			this.grpArrivalOrDepart.Name = "grpArrivalOrDepart";
			this.grpArrivalOrDepart.Size = new System.Drawing.Size(175, 57);
			this.grpArrivalOrDepart.TabIndex = 41;
			this.grpArrivalOrDepart.TabStop = false;
			// 
			// optIsDeparture
			// 
			this.optIsDeparture.AutoSize = true;
			this.optIsDeparture.Location = new System.Drawing.Point(89, 21);
			this.optIsDeparture.Name = "optIsDeparture";
			this.optIsDeparture.Size = new System.Drawing.Size(75, 21);
			this.optIsDeparture.TabIndex = 1;
			this.optIsDeparture.TabStop = true;
			this.optIsDeparture.Text = "Abfahrt";
			this.optIsDeparture.UseVisualStyleBackColor = true;
			// 
			// optIsArrival
			// 
			this.optIsArrival.AutoSize = true;
			this.optIsArrival.Location = new System.Drawing.Point(6, 21);
			this.optIsArrival.Name = "optIsArrival";
			this.optIsArrival.Size = new System.Drawing.Size(77, 21);
			this.optIsArrival.TabIndex = 0;
			this.optIsArrival.TabStop = true;
			this.optIsArrival.Text = "Ankunft";
			this.optIsArrival.UseVisualStyleBackColor = true;
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(390, 289);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(41, 20);
			this.lblTime.TabIndex = 40;
			this.lblTime.Text = "Zeit:";
			// 
			// tpFromTime
			// 
			this.tpFromTime.Checked = false;
			this.tpFromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.tpFromTime.Location = new System.Drawing.Point(455, 284);
			this.tpFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpFromTime.Name = "tpFromTime";
			this.tpFromTime.ShowUpDown = true;
			this.tpFromTime.Size = new System.Drawing.Size(137, 27);
			this.tpFromTime.TabIndex = 39;
			// 
			// btnDeleteStation
			// 
			this.btnDeleteStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStation.BackgroundImage")));
			this.btnDeleteStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDeleteStation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteStation.Location = new System.Drawing.Point(627, 102);
			this.btnDeleteStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDeleteStation.Name = "btnDeleteStation";
			this.btnDeleteStation.Size = new System.Drawing.Size(178, 105);
			this.btnDeleteStation.TabIndex = 43;
			this.btnDeleteStation.UseVisualStyleBackColor = true;
			this.btnDeleteStation.Click += new System.EventHandler(this.OnClickDelete);
			// 
			// btnSearchForConnections
			// 
			this.btnSearchForConnections.BackColor = System.Drawing.Color.Firebrick;
			this.btnSearchForConnections.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchForConnections.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSearchForConnections.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchForConnections.Location = new System.Drawing.Point(326, 351);
			this.btnSearchForConnections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearchForConnections.Name = "btnSearchForConnections";
			this.btnSearchForConnections.Size = new System.Drawing.Size(213, 47);
			this.btnSearchForConnections.TabIndex = 44;
			this.btnSearchForConnections.Text = "Verbindung Suchen";
			this.btnSearchForConnections.UseVisualStyleBackColor = false;
			this.btnSearchForConnections.Click += new System.EventHandler(this.OnClickSearchConnection);
			// 
			// lblConnections
			// 
			this.lblConnections.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblConnections.Location = new System.Drawing.Point(58, 442);
			this.lblConnections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblConnections.Name = "lblConnections";
			this.lblConnections.Size = new System.Drawing.Size(747, 24);
			this.lblConnections.TabIndex = 45;
			this.lblConnections.Text = "Verbindungen:";
			this.lblConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lvConnections
			// 
			this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
			this.lvConnections.Location = new System.Drawing.Point(58, 470);
			this.lvConnections.Margin = new System.Windows.Forms.Padding(4);
			this.lvConnections.Name = "lvConnections";
			this.lvConnections.Size = new System.Drawing.Size(747, 422);
			this.lvConnections.TabIndex = 46;
			this.lvConnections.TileSize = new System.Drawing.Size(168, 30);
			this.lvConnections.UseCompatibleStateImageBehavior = false;
			this.lvConnections.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Von";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Nach";
			this.columnHeader3.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Abfahrt";
			this.columnHeader2.Width = 46;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ankunft";
			this.columnHeader4.Width = 49;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Dauer";
			this.columnHeader5.Width = 55;
			// 
			// lblDelete
			// 
			this.lblDelete.AutoSize = true;
			this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDelete.Location = new System.Drawing.Point(644, 58);
			this.lblDelete.Name = "lblDelete";
			this.lblDelete.Size = new System.Drawing.Size(140, 24);
			this.lblDelete.TabIndex = 47;
			this.lblDelete.Text = "Inhalt löschen";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 922);
			this.Controls.Add(this.lblDelete);
			this.Controls.Add(this.lvConnections);
			this.Controls.Add(this.lblConnections);
			this.Controls.Add(this.btnSearchForConnections);
			this.Controls.Add(this.btnDeleteStation);
			this.Controls.Add(this.grpArrivalOrDepart);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.tpFromTime);
			this.Controls.Add(this.tpFromDate);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.txtToStation);
			this.Controls.Add(this.cmbToStation);
			this.Controls.Add(this.lblToPosition);
			this.Controls.Add(this.cmbFromStation);
			this.Controls.Add(this.txtFromStation);
			this.Controls.Add(this.lblVonStation);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Swisstransport Programm";
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
			this.grpArrivalOrDepart.ResumeLayout(false);
			this.grpArrivalOrDepart.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource transportBindingSource;
		private System.Windows.Forms.Label lblVonStation;
		private System.Windows.Forms.TextBox txtFromStation;
		private System.Windows.Forms.ComboBox cmbFromStation;
		private System.Windows.Forms.TextBox txtToStation;
		private System.Windows.Forms.ComboBox cmbToStation;
		private System.Windows.Forms.Label lblToPosition;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.DateTimePicker tpFromDate;
		private System.Windows.Forms.GroupBox grpArrivalOrDepart;
		private System.Windows.Forms.RadioButton optIsDeparture;
		private System.Windows.Forms.RadioButton optIsArrival;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.DateTimePicker tpFromTime;
		private System.Windows.Forms.Button btnDeleteStation;
		private System.Windows.Forms.Button btnSearchForConnections;
		private System.Windows.Forms.Label lblConnections;
		private System.Windows.Forms.ListView lvConnections;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label lblDelete;
	}
}

