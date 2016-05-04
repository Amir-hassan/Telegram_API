namespace Telegram_Api
{
    partial class Form1
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
            this.btn_Hash = new System.Windows.Forms.Button();
            this.Txt_HashCode = new System.Windows.Forms.TextBox();
            this.panel_HashCode = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Message = new System.Windows.Forms.Button();
            this.txt_message_body = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_send = new System.Windows.Forms.TextBox();
            this.panel_HashCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Hash
            // 
            this.btn_Hash.Location = new System.Drawing.Point(175, 18);
            this.btn_Hash.Name = "btn_Hash";
            this.btn_Hash.Size = new System.Drawing.Size(75, 23);
            this.btn_Hash.TabIndex = 0;
            this.btn_Hash.Text = "Send Code";
            this.btn_Hash.UseVisualStyleBackColor = true;
            this.btn_Hash.Click += new System.EventHandler(this.btn_Hash_Click);
            // 
            // Txt_HashCode
            // 
            this.Txt_HashCode.Location = new System.Drawing.Point(23, 18);
            this.Txt_HashCode.Name = "Txt_HashCode";
            this.Txt_HashCode.Size = new System.Drawing.Size(133, 20);
            this.Txt_HashCode.TabIndex = 1;
            // 
            // panel_HashCode
            // 
            this.panel_HashCode.Controls.Add(this.btn_Hash);
            this.panel_HashCode.Controls.Add(this.Txt_HashCode);
            this.panel_HashCode.Location = new System.Drawing.Point(12, 12);
            this.panel_HashCode.Name = "panel_HashCode";
            this.panel_HashCode.Size = new System.Drawing.Size(264, 73);
            this.panel_HashCode.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Message);
            this.panel1.Controls.Add(this.txt_message_body);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_send);
            this.panel1.Location = new System.Drawing.Point(13, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 157);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Message
            // 
            this.Btn_Message.Location = new System.Drawing.Point(155, 129);
            this.Btn_Message.Name = "Btn_Message";
            this.Btn_Message.Size = new System.Drawing.Size(91, 23);
            this.Btn_Message.TabIndex = 3;
            this.Btn_Message.Text = "Send Message";
            this.Btn_Message.UseVisualStyleBackColor = true;
            this.Btn_Message.Click += new System.EventHandler(this.Btn_Message_Click);
            // 
            // txt_message_body
            // 
            this.txt_message_body.Location = new System.Drawing.Point(63, 39);
            this.txt_message_body.Multiline = true;
            this.txt_message_body.Name = "txt_message_body";
            this.txt_message_body.Size = new System.Drawing.Size(182, 86);
            this.txt_message_body.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send To :";
            // 
            // Txt_send
            // 
            this.Txt_send.Location = new System.Drawing.Point(63, 15);
            this.Txt_send.Name = "Txt_send";
            this.Txt_send.Size = new System.Drawing.Size(133, 20);
            this.Txt_send.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_HashCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_HashCode.ResumeLayout(false);
            this.panel_HashCode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hash;
        private System.Windows.Forms.TextBox Txt_HashCode;
        private System.Windows.Forms.Panel panel_HashCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Message;
        private System.Windows.Forms.TextBox txt_message_body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_send;
    }
}

