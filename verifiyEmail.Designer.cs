namespace Activity7
{
    partial class verifiyEmail
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.forgotpass);
            this.panel1.Location = new System.Drawing.Point(214, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 210);
            this.panel1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(201, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Resend";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(53, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Check Email Inbox";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 6.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thanks! We\'ve sent you an email with a link to verify your account. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.forgotpass.ForeColor = System.Drawing.Color.DimGray;
            this.forgotpass.Location = new System.Drawing.Point(78, 51);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(208, 26);
            this.forgotpass.TabIndex = 15;
            this.forgotpass.Text = "Check your email!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 6.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(69, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = " If you don\'t receive the email, please click \'Resend\'.";
            // 
            // verifiyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "verifiyEmail";
            this.Text = "Email Check";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forgotpass;
        private System.Windows.Forms.Label label2;
    }
}