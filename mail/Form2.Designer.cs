namespace mail
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.send = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.subject);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(60, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 699);
            this.panel1.TabIndex = 0;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(382, 604);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(407, 37);
            this.send.TabIndex = 5;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Black;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Gainsboro;
            this.message.Location = new System.Drawing.Point(351, 247);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(497, 323);
            this.message.TabIndex = 4;
            this.message.Tag = "";
            this.message.Text = " Message";
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.Black;
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.Color.Gainsboro;
            this.subject.Location = new System.Drawing.Point(351, 157);
            this.subject.Multiline = true;
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(497, 56);
            this.subject.TabIndex = 3;
            this.subject.Tag = "";
            this.subject.Text = " Subject";
            this.subject.Click += new System.EventHandler(this.subject_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Black;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gainsboro;
            this.username.Location = new System.Drawing.Point(351, 66);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(497, 56);
            this.username.TabIndex = 2;
            this.username.Tag = "";
            this.username.Text = " Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1293, 820);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button send;
    }
}