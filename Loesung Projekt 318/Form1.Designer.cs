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
			this.panel1 = new System.Windows.Forms.Panel();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.TimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNach = new System.Windows.Forms.TextBox();
			this.txtVon = new System.Windows.Forms.TextBox();
			this.lblNach = new System.Windows.Forms.Label();
			this.lblVon = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnVerbinden = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnVerbinden);
			this.panel1.Controls.Add(this.datePicker);
			this.panel1.Controls.Add(this.TimePicker);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtNach);
			this.panel1.Controls.Add(this.txtVon);
			this.panel1.Controls.Add(this.lblNach);
			this.panel1.Controls.Add(this.lblVon);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 273);
			this.panel1.TabIndex = 0;
			// 
			// datePicker
			// 
			this.datePicker.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.Location = new System.Drawing.Point(261, 213);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(321, 27);
			this.datePicker.TabIndex = 7;
			// 
			// TimePicker
			// 
			this.TimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.TimePicker.Location = new System.Drawing.Point(308, 171);
			this.TimePicker.Name = "TimePicker";
			this.TimePicker.ShowUpDown = true;
			this.TimePicker.Size = new System.Drawing.Size(102, 27);
			this.TimePicker.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(126, 207);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 30);
			this.label2.TabIndex = 5;
			this.label2.Text = "Datum:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(126, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "Zeit:";
			// 
			// txtNach
			// 
			this.txtNach.Location = new System.Drawing.Point(261, 116);
			this.txtNach.Name = "txtNach";
			this.txtNach.Size = new System.Drawing.Size(209, 22);
			this.txtNach.TabIndex = 3;
			// 
			// txtVon
			// 
			this.txtVon.Location = new System.Drawing.Point(261, 63);
			this.txtVon.Name = "txtVon";
			this.txtVon.Size = new System.Drawing.Size(209, 22);
			this.txtVon.TabIndex = 2;
			// 
			// lblNach
			// 
			this.lblNach.AutoSize = true;
			this.lblNach.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblNach.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNach.Location = new System.Drawing.Point(126, 108);
			this.lblNach.Name = "lblNach";
			this.lblNach.Size = new System.Drawing.Size(81, 30);
			this.lblNach.TabIndex = 1;
			this.lblNach.Text = "Nach:";
			// 
			// lblVon
			// 
			this.lblVon.AutoSize = true;
			this.lblVon.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblVon.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVon.Location = new System.Drawing.Point(126, 55);
			this.lblVon.Name = "lblVon";
			this.lblVon.Size = new System.Drawing.Size(65, 30);
			this.lblVon.TabIndex = 0;
			this.lblVon.Text = "Von:";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
			this.flowLayoutPanel1.Controls.Add(this.dataGridView);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 273);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1062, 543);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btnVerbinden
			// 
			this.btnVerbinden.BackColor = System.Drawing.Color.AliceBlue;
			this.btnVerbinden.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerbinden.Location = new System.Drawing.Point(586, 95);
			this.btnVerbinden.Name = "btnVerbinden";
			this.btnVerbinden.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
			this.btnVerbinden.Size = new System.Drawing.Size(367, 64);
			this.btnVerbinden.TabIndex = 8;
			this.btnVerbinden.Text = "Nach Verbindung suchen";
			this.btnVerbinden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnVerbinden.UseVisualStyleBackColor = false;
			this.btnVerbinden.Click += new System.EventHandler(this.OnClickVerbindungSuchen);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.DataSource = this.transportBindingSource;
			this.dataGridView.Location = new System.Drawing.Point(3, 3);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(1059, 540);
			this.dataGridView.TabIndex = 0;
			// 
			// transportBindingSource
			// 
			this.transportBindingSource.DataSource = typeof(SwissTransport.Transport);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 816);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.DateTimePicker TimePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNach;
		private System.Windows.Forms.TextBox txtVon;
		private System.Windows.Forms.Label lblNach;
		private System.Windows.Forms.Label lblVon;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnVerbinden;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.BindingSource transportBindingSource;
	}
}

