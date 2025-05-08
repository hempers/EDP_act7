namespace Activity7
{
    partial class fogotpass
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
            this.forgotpass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.forgotpass.ForeColor = System.Drawing.Color.DimGray;
            this.forgotpass.Location = new System.Drawing.Point(78, 51);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(199, 26);
            this.forgotpass.TabIndex = 15;
            this.forgotpass.Text = "Forgot Password?";
            this.forgotpass.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter your email address for account recovery.";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email:";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(32, 148);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(304, 20);
            this.email.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(128, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Send Verification";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.forgotpass);
            this.panel1.Location = new System.Drawing.Point(213, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 289);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(128, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "<  Back To Login";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // fogotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fogotpass";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.fogotpass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label forgotpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}