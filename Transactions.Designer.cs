﻿namespace Activity7
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.txtName = new System.Windows.Forms.TextBox();
            this.Borrowedbooks = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.duedate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Button();
            this.borrowdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnTransac = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMngLib = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnborrow = new System.Windows.Forms.Button();
            this.innerborrow = new System.Windows.Forms.Panel();
            this.booktitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.genReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Borrowedbooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.innerborrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(54, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 21);
            this.txtName.TabIndex = 22;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Borrowedbooks
            // 
            this.Borrowedbooks.BackgroundColor = System.Drawing.Color.White;
            this.Borrowedbooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Borrowedbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Borrowedbooks.Location = new System.Drawing.Point(18, 277);
            this.Borrowedbooks.Name = "Borrowedbooks";
            this.Borrowedbooks.Size = new System.Drawing.Size(503, 167);
            this.Borrowedbooks.TabIndex = 21;
            this.Borrowedbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Borrowedbooks_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(52, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Name";
            // 
            // duedate
            // 
            this.duedate.CalendarFont = new System.Drawing.Font("Century Gothic", 7.25F, System.Drawing.FontStyle.Bold);
            this.duedate.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.duedate.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedate.Location = new System.Drawing.Point(294, 213);
            this.duedate.Name = "duedate";
            this.duedate.Size = new System.Drawing.Size(193, 19);
            this.duedate.TabIndex = 19;
            this.duedate.ValueChanged += new System.EventHandler(this.duedate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(291, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Due Date";
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.LimeGreen;
            this.borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.borrow.ForeColor = System.Drawing.Color.White;
            this.borrow.Location = new System.Drawing.Point(236, 242);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(75, 27);
            this.borrow.TabIndex = 17;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // borrowdate
            // 
            this.borrowdate.CalendarFont = new System.Drawing.Font("Century Gothic", 7.25F, System.Drawing.FontStyle.Bold);
            this.borrowdate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.borrowdate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.borrowdate.Font = new System.Drawing.Font("Century Gothic", 6.75F);
            this.borrowdate.Location = new System.Drawing.Point(55, 213);
            this.borrowdate.Name = "borrowdate";
            this.borrowdate.Size = new System.Drawing.Size(193, 19);
            this.borrowdate.TabIndex = 16;
            this.borrowdate.ValueChanged += new System.EventHandler(this.borrowdate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(52, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Borrow Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(172, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Borrow from ReadSpace";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 521);
            this.panel1.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGreen;
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.btnTransac);
            this.panel6.Location = new System.Drawing.Point(0, 313);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 54);
            this.panel6.TabIndex = 13;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(19, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // btnTransac
            // 
            this.btnTransac.BackColor = System.Drawing.Color.White;
            this.btnTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransac.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnTransac.ForeColor = System.Drawing.Color.LightGreen;
            this.btnTransac.Location = new System.Drawing.Point(-10, -13);
            this.btnTransac.Name = "btnTransac";
            this.btnTransac.Size = new System.Drawing.Size(256, 79);
            this.btnTransac.TabIndex = 0;
            this.btnTransac.Text = "View Transactions";
            this.btnTransac.UseVisualStyleBackColor = false;
            this.btnTransac.Click += new System.EventHandler(this.btnTransac_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.btnMngLib);
            this.panel4.Location = new System.Drawing.Point(0, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 54);
            this.panel4.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // btnMngLib
            // 
            this.btnMngLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngLib.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnMngLib.ForeColor = System.Drawing.Color.White;
            this.btnMngLib.Location = new System.Drawing.Point(0, -8);
            this.btnMngLib.Name = "btnMngLib";
            this.btnMngLib.Size = new System.Drawing.Size(220, 66);
            this.btnMngLib.TabIndex = 2;
            this.btnMngLib.Text = "Manage Library";
            this.btnMngLib.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnAuthors);
            this.panel3.Location = new System.Drawing.Point(1, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 54);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnAuthors
            // 
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAuthors.ForeColor = System.Drawing.Color.White;
            this.btnAuthors.Location = new System.Drawing.Point(-11, -3);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(236, 57);
            this.btnAuthors.TabIndex = 1;
            this.btnAuthors.Text = "Manage Users";
            this.btnAuthors.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(43, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(74, 27);
            this.panel5.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Librarian";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(1, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 54);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightGreen;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(-12, -4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(209, 64);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(159, 477);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 470);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-14, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnborrow
            // 
            this.btnborrow.BackColor = System.Drawing.Color.White;
            this.btnborrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrow.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrow.Location = new System.Drawing.Point(236, 17);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(85, 23);
            this.btnborrow.TabIndex = 25;
            this.btnborrow.Text = "Borrow Book";
            this.btnborrow.UseVisualStyleBackColor = false;
            this.btnborrow.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // innerborrow
            // 
            this.innerborrow.BackColor = System.Drawing.Color.White;
            this.innerborrow.Controls.Add(this.booktitle);
            this.innerborrow.Controls.Add(this.label5);
            this.innerborrow.Controls.Add(this.bookId);
            this.innerborrow.Controls.Add(this.label7);
            this.innerborrow.Controls.Add(this.address);
            this.innerborrow.Controls.Add(this.label4);
            this.innerborrow.Controls.Add(this.phone);
            this.innerborrow.Controls.Add(this.label3);
            this.innerborrow.Controls.Add(this.Email);
            this.innerborrow.Controls.Add(this.label2);
            this.innerborrow.Controls.Add(this.txtName);
            this.innerborrow.Controls.Add(this.Borrowedbooks);
            this.innerborrow.Controls.Add(this.label10);
            this.innerborrow.Controls.Add(this.duedate);
            this.innerborrow.Controls.Add(this.label9);
            this.innerborrow.Controls.Add(this.borrow);
            this.innerborrow.Controls.Add(this.borrowdate);
            this.innerborrow.Controls.Add(this.label8);
            this.innerborrow.Controls.Add(this.label6);
            this.innerborrow.Location = new System.Drawing.Point(236, 39);
            this.innerborrow.Name = "innerborrow";
            this.innerborrow.Size = new System.Drawing.Size(538, 452);
            this.innerborrow.TabIndex = 26;
            this.innerborrow.Paint += new System.Windows.Forms.PaintEventHandler(this.innerborrow_Paint);
            // 
            // booktitle
            // 
            this.booktitle.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.booktitle.ForeColor = System.Drawing.Color.DimGray;
            this.booktitle.Location = new System.Drawing.Point(294, 170);
            this.booktitle.Name = "booktitle";
            this.booktitle.Size = new System.Drawing.Size(193, 21);
            this.booktitle.TabIndex = 32;
            this.booktitle.TextChanged += new System.EventHandler(this.booktitle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(291, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Book Title";
            // 
            // bookId
            // 
            this.bookId.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.bookId.ForeColor = System.Drawing.Color.DimGray;
            this.bookId.Location = new System.Drawing.Point(54, 170);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(193, 21);
            this.bookId.TabIndex = 30;
            this.bookId.TextChanged += new System.EventHandler(this.bookId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(51, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "BookID";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.address.ForeColor = System.Drawing.Color.DimGray;
            this.address.Location = new System.Drawing.Point(294, 129);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(193, 21);
            this.address.TabIndex = 28;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(291, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.phone.ForeColor = System.Drawing.Color.DimGray;
            this.phone.Location = new System.Drawing.Point(54, 129);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(193, 21);
            this.phone.TabIndex = 26;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(51, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phone";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Email.ForeColor = System.Drawing.Color.DimGray;
            this.Email.Location = new System.Drawing.Point(294, 88);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(193, 21);
            this.Email.TabIndex = 24;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(291, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReserve.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(320, 17);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(85, 23);
            this.btnReserve.TabIndex = 27;
            this.btnReserve.Text = "Reserve Book";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibrarian.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Location = new System.Drawing.Point(399, 17);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(85, 23);
            this.btnLibrarian.TabIndex = 28;
            this.btnLibrarian.Text = "Librarian";
            this.btnLibrarian.UseVisualStyleBackColor = false;
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // genReport
            // 
            this.genReport.BackColor = System.Drawing.Color.LimeGreen;
            this.genReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genReport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.genReport.ForeColor = System.Drawing.Color.White;
            this.genReport.Location = new System.Drawing.Point(656, 16);
            this.genReport.Name = "genReport";
            this.genReport.Size = new System.Drawing.Size(118, 22);
            this.genReport.TabIndex = 33;
            this.genReport.Text = "Generate Report";
            this.genReport.UseVisualStyleBackColor = false;
            this.genReport.Click += new System.EventHandler(this.genReport_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.genReport);
            this.Controls.Add(this.innerborrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnborrow);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnLibrarian);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Borrowedbooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.innerborrow.ResumeLayout(false);
            this.innerborrow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView Borrowedbooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker duedate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.DateTimePicker borrowdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnTransac;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMngLib;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnborrow;
        private System.Windows.Forms.Panel innerborrow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox booktitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button genReport;
    }
}