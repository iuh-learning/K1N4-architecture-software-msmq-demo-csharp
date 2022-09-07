namespace MSMQ_Sender
{
    partial class frmSender
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
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.btnSendObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(12, 12);
            this.txtSender.Multiline = true;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(439, 78);
            this.txtSender.TabIndex = 0;
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(12, 96);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(439, 44);
            this.btnSendText.TabIndex = 1;
            this.btnSendText.Text = "Send Text";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // btnSendObject
            // 
            this.btnSendObject.Location = new System.Drawing.Point(13, 146);
            this.btnSendObject.Name = "btnSendObject";
            this.btnSendObject.Size = new System.Drawing.Size(438, 44);
            this.btnSendObject.TabIndex = 2;
            this.btnSendObject.Text = "Send Object";
            this.btnSendObject.UseVisualStyleBackColor = true;
            this.btnSendObject.Click += new System.EventHandler(this.btnSendObject_Click);
            // 
            // frmSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 213);
            this.Controls.Add(this.btnSendObject);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.txtSender);
            this.Name = "frmSender";
            this.Text = "Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.Button btnSendObject;
    }
}

