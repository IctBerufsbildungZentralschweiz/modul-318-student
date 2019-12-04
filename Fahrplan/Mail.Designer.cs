namespace Fahrplan
{
    partial class Mail
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
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBetreff = new System.Windows.Forms.Label();
            this.pnlBetreff = new System.Windows.Forms.Panel();
            this.txtBetreff = new System.Windows.Forms.TextBox();
            this.lblEmpfänger = new System.Windows.Forms.Label();
            this.pnlEmpfänger = new System.Windows.Forms.Panel();
            this.txtEmpfänger = new System.Windows.Forms.TextBox();
            this.txtNachricht = new System.Windows.Forms.TextBox();
            this.Nachricht = new System.Windows.Forms.Label();
            this.pnlNachricht = new System.Windows.Forms.Panel();
            this.pnlDetail.SuspendLayout();
            this.pnlBetreff.SuspendLayout();
            this.pnlEmpfänger.SuspendLayout();
            this.pnlNachricht.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(101, 298);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(173, 45);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SENDEN";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.Controls.Add(this.Nachricht);
            this.pnlDetail.Controls.Add(this.pnlNachricht);
            this.pnlDetail.Controls.Add(this.lblEmpfänger);
            this.pnlDetail.Controls.Add(this.lblBetreff);
            this.pnlDetail.Controls.Add(this.pnlEmpfänger);
            this.pnlDetail.Controls.Add(this.pnlBetreff);
            this.pnlDetail.Controls.Add(this.btnSend);
            this.pnlDetail.Controls.Add(this.btnCancel);
            this.pnlDetail.Controls.Add(this.lblMail);
            this.pnlDetail.Location = new System.Drawing.Point(12, 12);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(300, 357);
            this.pnlDetail.TabIndex = 14;
            // 
            // lblMail
            // 
            this.lblMail.AutoEllipsis = true;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(6, 9);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.MaximumSize = new System.Drawing.Size(295, 100);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(255, 58);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Ergebnisse per Mail weiterleiten";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(19, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "×";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBetreff
            // 
            this.lblBetreff.AutoSize = true;
            this.lblBetreff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetreff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblBetreff.Location = new System.Drawing.Point(16, 143);
            this.lblBetreff.Name = "lblBetreff";
            this.lblBetreff.Size = new System.Drawing.Size(53, 16);
            this.lblBetreff.TabIndex = 19;
            this.lblBetreff.Text = "Betreff";
            // 
            // pnlBetreff
            // 
            this.pnlBetreff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBetreff.Controls.Add(this.txtBetreff);
            this.pnlBetreff.Location = new System.Drawing.Point(17, 162);
            this.pnlBetreff.Name = "pnlBetreff";
            this.pnlBetreff.Size = new System.Drawing.Size(256, 30);
            this.pnlBetreff.TabIndex = 18;
            // 
            // txtBetreff
            // 
            this.txtBetreff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBetreff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBetreff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetreff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.txtBetreff.Location = new System.Drawing.Point(2, 6);
            this.txtBetreff.Margin = new System.Windows.Forms.Padding(2);
            this.txtBetreff.Name = "txtBetreff";
            this.txtBetreff.Size = new System.Drawing.Size(252, 19);
            this.txtBetreff.TabIndex = 2;
            this.txtBetreff.TextChanged += new System.EventHandler(this.txtBetreff_TextChanged);
            // 
            // lblEmpfänger
            // 
            this.lblEmpfänger.AutoSize = true;
            this.lblEmpfänger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpfänger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblEmpfänger.Location = new System.Drawing.Point(16, 81);
            this.lblEmpfänger.Name = "lblEmpfänger";
            this.lblEmpfänger.Size = new System.Drawing.Size(93, 16);
            this.lblEmpfänger.TabIndex = 19;
            this.lblEmpfänger.Text = "Empfänger *";
            // 
            // pnlEmpfänger
            // 
            this.pnlEmpfänger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlEmpfänger.Controls.Add(this.txtEmpfänger);
            this.pnlEmpfänger.Location = new System.Drawing.Point(17, 100);
            this.pnlEmpfänger.Name = "pnlEmpfänger";
            this.pnlEmpfänger.Size = new System.Drawing.Size(256, 30);
            this.pnlEmpfänger.TabIndex = 18;
            // 
            // txtEmpfänger
            // 
            this.txtEmpfänger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmpfänger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpfänger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpfänger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.txtEmpfänger.Location = new System.Drawing.Point(2, 6);
            this.txtEmpfänger.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpfänger.Name = "txtEmpfänger";
            this.txtEmpfänger.Size = new System.Drawing.Size(252, 19);
            this.txtEmpfänger.TabIndex = 1;
            this.txtEmpfänger.TextChanged += new System.EventHandler(this.txtEmpfänger_TextChanged);
            // 
            // txtNachricht
            // 
            this.txtNachricht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNachricht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNachricht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachricht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.txtNachricht.Location = new System.Drawing.Point(2, 6);
            this.txtNachricht.Margin = new System.Windows.Forms.Padding(2);
            this.txtNachricht.Name = "txtNachricht";
            this.txtNachricht.Size = new System.Drawing.Size(252, 19);
            this.txtNachricht.TabIndex = 3;
            this.txtNachricht.TextChanged += new System.EventHandler(this.txtNachricht_TextChanged);
            // 
            // Nachricht
            // 
            this.Nachricht.AutoSize = true;
            this.Nachricht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nachricht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.Nachricht.Location = new System.Drawing.Point(16, 200);
            this.Nachricht.Name = "Nachricht";
            this.Nachricht.Size = new System.Drawing.Size(73, 16);
            this.Nachricht.TabIndex = 21;
            this.Nachricht.Text = "Nachricht";
            // 
            // pnlNachricht
            // 
            this.pnlNachricht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlNachricht.Controls.Add(this.txtNachricht);
            this.pnlNachricht.Location = new System.Drawing.Point(17, 224);
            this.pnlNachricht.Name = "pnlNachricht";
            this.pnlNachricht.Size = new System.Drawing.Size(256, 30);
            this.pnlNachricht.TabIndex = 20;
            // 
            // Mail
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 381);
            this.Controls.Add(this.pnlDetail);
            this.Name = "Mail";
            this.Text = "Mail";
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlBetreff.ResumeLayout(false);
            this.pnlBetreff.PerformLayout();
            this.pnlEmpfänger.ResumeLayout(false);
            this.pnlEmpfänger.PerformLayout();
            this.pnlNachricht.ResumeLayout(false);
            this.pnlNachricht.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label Nachricht;
        private System.Windows.Forms.Panel pnlNachricht;
        private System.Windows.Forms.TextBox txtNachricht;
        private System.Windows.Forms.Label lblEmpfänger;
        private System.Windows.Forms.Label lblBetreff;
        private System.Windows.Forms.Panel pnlEmpfänger;
        private System.Windows.Forms.TextBox txtEmpfänger;
        private System.Windows.Forms.Panel pnlBetreff;
        private System.Windows.Forms.TextBox txtBetreff;
    }
}