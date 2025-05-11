namespace Activity7
{
    partial class EditUser
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
            this.save = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phonenumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.forgotpass);
            this.panel1.Location = new System.Drawing.Point(188, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 430);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.SpringGreen;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(56, 352);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(137, 28);
            this.save.TabIndex = 31;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.status.ForeColor = System.Drawing.Color.DimGray;
            this.status.Location = new System.Drawing.Point(223, 295);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(137, 21);
            this.status.TabIndex = 30;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(220, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Status:";
            // 
            // phonenumber
            // 
            this.phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonenumber.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.phonenumber.ForeColor = System.Drawing.Color.DimGray;
            this.phonenumber.Location = new System.Drawing.Point(56, 295);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(141, 21);
            this.phonenumber.TabIndex = 28;
            this.phonenumber.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(53, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone Number:";
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.address.ForeColor = System.Drawing.Color.DimGray;
            this.address.Location = new System.Drawing.Point(56, 245);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(304, 21);
            this.address.TabIndex = 26;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(53, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address:";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(56, 193);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(304, 21);
            this.email.TabIndex = 24;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(53, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.DimGray;
            this.name.Location = new System.Drawing.Point(56, 143);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(304, 21);
            this.name.TabIndex = 22;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(53, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name:";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.SpringGreen;
            this.cancel.Location = new System.Drawing.Point(223, 352);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(137, 28);
            this.cancel.TabIndex = 19;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.White;
            this.txtUserId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserId.Location = new System.Drawing.Point(191, 78);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(92, 21);
            this.txtUserId.TabIndex = 18;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(140, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "User_ID";
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.forgotpass.ForeColor = System.Drawing.Color.DimGray;
            this.forgotpass.Location = new System.Drawing.Point(99, 38);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(228, 26);
            this.forgotpass.TabIndex = 15;
            this.forgotpass.Text = "Edit User Information";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(785, 522);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User Information";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label forgotpass;
    }
}