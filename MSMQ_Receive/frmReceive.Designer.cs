namespace MSMQ_Receive
{
    partial class frmReceive
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
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(23, 12);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(751, 252);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // frmReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.rtbMessage);
            this.Name = "frmReceive";
            this.Text = "Receive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}

