namespace OeV_Application
{
    partial class MailSendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailSendForm));
            this.textboxRecievers = new System.Windows.Forms.TextBox();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_MailSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxRecievers
            // 
            this.textboxRecievers.Location = new System.Drawing.Point(53, 15);
            this.textboxRecievers.Name = "textboxRecievers";
            this.textboxRecievers.Size = new System.Drawing.Size(227, 20);
            this.textboxRecievers.TabIndex = 0;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Location = new System.Drawing.Point(53, 38);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(227, 20);
            this.textBoxHeader.TabIndex = 1;
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(12, 64);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(268, 197);
            this.richTextBoxContent.TabIndex = 2;
            this.richTextBoxContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "An";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Betreff";
            // 
            // Button_MailSend
            // 
            this.Button_MailSend.Location = new System.Drawing.Point(188, 267);
            this.Button_MailSend.Name = "Button_MailSend";
            this.Button_MailSend.Size = new System.Drawing.Size(92, 23);
            this.Button_MailSend.TabIndex = 5;
            this.Button_MailSend.Text = "Versenden";
            this.Button_MailSend.UseVisualStyleBackColor = true;
            this.Button_MailSend.Click += new System.EventHandler(this.Button_MailSend_Click);
            // 
            // MailSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 325);
            this.Controls.Add(this.Button_MailSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.textboxRecievers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailSendForm";
            this.Text = "MailSendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxRecievers;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_MailSend;
    }
}