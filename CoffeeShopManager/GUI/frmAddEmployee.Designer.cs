﻿namespace GUI
{
    partial class frmAddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbboxPosition = new System.Windows.Forms.ComboBox();
            this.picboxEmpImg = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtYearBD = new System.Windows.Forms.TextBox();
            this.txtMonthBD = new System.Windows.Forms.TextBox();
            this.txtDayBD = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYearJoin = new System.Windows.Forms.TextBox();
            this.txtMonthJoin = new System.Windows.Forms.TextBox();
            this.txtDayJoin = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.cbboxPosition);
            this.panel2.Controls.Add(this.picboxEmpImg);
            this.panel2.Controls.Add(this.btnChooseImage);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtYearBD);
            this.panel2.Controls.Add(this.txtMonthBD);
            this.panel2.Controls.Add(this.txtDayBD);
            this.panel2.Controls.Add(this.radFemale);
            this.panel2.Controls.Add(this.radMale);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtYearJoin);
            this.panel2.Controls.Add(this.txtMonthJoin);
            this.panel2.Controls.Add(this.txtDayJoin);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 434);
            this.panel2.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(448, 263);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(113, 23);
            this.txtUsername.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(325, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 19);
            this.label18.TabIndex = 39;
            this.label18.Text = "Username";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(367, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbboxPosition
            // 
            this.cbboxPosition.FormattingEnabled = true;
            this.cbboxPosition.Items.AddRange(new object[] {
            "Waiter",
            "Barista",
            "Cook",
            "Utility",
            "Janitor",
            "Security"});
            this.cbboxPosition.Location = new System.Drawing.Point(138, 219);
            this.cbboxPosition.Name = "cbboxPosition";
            this.cbboxPosition.Size = new System.Drawing.Size(113, 24);
            this.cbboxPosition.TabIndex = 37;
            // 
            // picboxEmpImg
            // 
            this.picboxEmpImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxEmpImg.Location = new System.Drawing.Point(664, 72);
            this.picboxEmpImg.Name = "picboxEmpImg";
            this.picboxEmpImg.Size = new System.Drawing.Size(171, 172);
            this.picboxEmpImg.TabIndex = 36;
            this.picboxEmpImg.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnChooseImage.Location = new System.Drawing.Point(706, 255);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(90, 37);
            this.btnChooseImage.TabIndex = 35;
            this.btnChooseImage.Text = "Browse";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(549, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 19);
            this.label16.TabIndex = 20;
            this.label16.Text = "/";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(486, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 19);
            this.label17.TabIndex = 18;
            this.label17.Text = "/";
            // 
            // txtYearBD
            // 
            this.txtYearBD.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearBD.Location = new System.Drawing.Point(570, 92);
            this.txtYearBD.Name = "txtYearBD";
            this.txtYearBD.Size = new System.Drawing.Size(51, 23);
            this.txtYearBD.TabIndex = 21;
            this.txtYearBD.TextChanged += new System.EventHandler(this.txtYearBD_TextChanged);
            // 
            // txtMonthBD
            // 
            this.txtMonthBD.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthBD.Location = new System.Drawing.Point(507, 92);
            this.txtMonthBD.Name = "txtMonthBD";
            this.txtMonthBD.Size = new System.Drawing.Size(33, 23);
            this.txtMonthBD.TabIndex = 19;
            // 
            // txtDayBD
            // 
            this.txtDayBD.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayBD.Location = new System.Drawing.Point(448, 92);
            this.txtDayBD.Name = "txtDayBD";
            this.txtDayBD.Size = new System.Drawing.Size(33, 23);
            this.txtDayBD.TabIndex = 17;
            this.txtDayBD.TextChanged += new System.EventHandler(this.txtDayBD_TextChanged);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(209, 179);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(75, 21);
            this.radFemale.TabIndex = 9;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(132, 179);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(59, 21);
            this.radMale.TabIndex = 8;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(207, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 37);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(549, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "/";
            // 
            // txtYearJoin
            // 
            this.txtYearJoin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearJoin.Location = new System.Drawing.Point(570, 175);
            this.txtYearJoin.Name = "txtYearJoin";
            this.txtYearJoin.Size = new System.Drawing.Size(51, 23);
            this.txtYearJoin.TabIndex = 29;
            // 
            // txtMonthJoin
            // 
            this.txtMonthJoin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthJoin.Location = new System.Drawing.Point(507, 175);
            this.txtMonthJoin.Name = "txtMonthJoin";
            this.txtMonthJoin.Size = new System.Drawing.Size(33, 23);
            this.txtMonthJoin.TabIndex = 27;
            // 
            // txtDayJoin
            // 
            this.txtDayJoin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayJoin.Location = new System.Drawing.Point(448, 175);
            this.txtDayJoin.Name = "txtDayJoin";
            this.txtDayJoin.Size = new System.Drawing.Size(33, 23);
            this.txtDayJoin.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(138, 265);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(113, 23);
            this.txtPhone.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(448, 133);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(113, 23);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(138, 137);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(113, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(138, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(113, 23);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(448, 305);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 23);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(448, 221);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(113, 23);
            this.txtSalary.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(448, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(113, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(138, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 23);
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date of join";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Birthdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Position";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(325, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add employee";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(880, 30);
            this.TitleBar.TabIndex = 10;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Location = new System.Drawing.Point(849, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddEmployee
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYearJoin;
        private System.Windows.Forms.TextBox txtMonthJoin;
        private System.Windows.Forms.TextBox txtDayJoin;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtYearBD;
        private System.Windows.Forms.TextBox txtMonthBD;
        private System.Windows.Forms.TextBox txtDayBD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picboxEmpImg;
        private System.Windows.Forms.ComboBox cbboxPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label18;
    }
}