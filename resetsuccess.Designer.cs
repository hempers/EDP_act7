namespace Activity7
{
    partial class resetsuccess
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
            this.Loginnow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Loginnow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.forgotpass);
            this.panel1.Location = new System.Drawing.Point(219, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 181);
            this.panel1.TabIndex = 22;
            // 
            // Loginnow
            // 
            this.Loginnow.BackColor = System.Drawing.Color.SpringGreen;
            this.Loginnow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Loginnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginnow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginnow.ForeColor = System.Drawing.Color.White;
            this.Loginnow.Location = new System.Drawing.Point(127, 115);
            this.Loginnow.Name = "Loginnow";
            this.Loginnow.Size = new System.Drawing.Size(118, 28);
            this.Loginnow.TabIndex = 19;
            this.Loginnow.Text = "Login Now!";
            this.Loginnow.UseVisualStyleBackColor = false;
            this.Loginnow.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 6.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your password has been changed successfully.";
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.forgotpass.ForeColor = System.Drawing.Color.DimGray;
            this.forgotpass.Location = new System.Drawing.Point(67, 45);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(227, 26);
            this.forgotpass.TabIndex = 15;
            this.forgotpass.Text = "Password Changed!";
            // 
            // resetsuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "resetsuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset Successfully";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Loginnow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forgotpass;
    }
}