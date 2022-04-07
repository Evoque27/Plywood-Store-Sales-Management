namespace Final_Project
{
    partial class FrmEmployeeRecords
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
            this.lbldob = new System.Windows.Forms.Label();
            this.dptdob = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lbldoj = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.lbldesg = new System.Windows.Forms.Label();
            this.dtpdoj = new System.Windows.Forms.DateTimePicker();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.cmbdesg = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblmobile = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.Transparent;
            this.lbldob.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.Color.Red;
            this.lbldob.Location = new System.Drawing.Point(545, 242);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(0, 18);
            this.lbldob.TabIndex = 98;
            // 
            // dptdob
            // 
            this.dptdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptdob.Location = new System.Drawing.Point(548, 213);
            this.dptdob.Name = "dptdob";
            this.dptdob.Size = new System.Drawing.Size(196, 20);
            this.dptdob.TabIndex = 73;
            this.dptdob.Leave += new System.EventHandler(this.dptdob_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(414, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Date of Birth";
            // 
            // lbldoj
            // 
            this.lbldoj.AutoSize = true;
            this.lbldoj.BackColor = System.Drawing.Color.Transparent;
            this.lbldoj.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoj.ForeColor = System.Drawing.Color.Red;
            this.lbldoj.Location = new System.Drawing.Point(545, 295);
            this.lbldoj.Name = "lbldoj";
            this.lbldoj.Size = new System.Drawing.Size(0, 18);
            this.lbldoj.TabIndex = 96;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.BackColor = System.Drawing.Color.Transparent;
            this.lblsal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.ForeColor = System.Drawing.Color.Red;
            this.lblsal.Location = new System.Drawing.Point(545, 187);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(0, 18);
            this.lblsal.TabIndex = 95;
            // 
            // lbldesg
            // 
            this.lbldesg.AutoSize = true;
            this.lbldesg.BackColor = System.Drawing.Color.Transparent;
            this.lbldesg.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesg.ForeColor = System.Drawing.Color.Red;
            this.lbldesg.Location = new System.Drawing.Point(544, 135);
            this.lbldesg.Name = "lbldesg";
            this.lbldesg.Size = new System.Drawing.Size(0, 18);
            this.lbldesg.TabIndex = 94;
            // 
            // dtpdoj
            // 
            this.dtpdoj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdoj.Location = new System.Drawing.Point(548, 266);
            this.dtpdoj.Name = "dtpdoj";
            this.dtpdoj.Size = new System.Drawing.Size(196, 20);
            this.dtpdoj.TabIndex = 74;
            this.dtpdoj.Leave += new System.EventHandler(this.dtpdoj_Leave);
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtsal.Location = new System.Drawing.Point(548, 157);
            this.txtsal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsal.MaxLength = 10;
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(196, 26);
            this.txtsal.TabIndex = 72;
            this.txtsal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsal_KeyPress);
            this.txtsal.Leave += new System.EventHandler(this.txtsal_Leave);
            // 
            // cmbdesg
            // 
            this.cmbdesg.FormattingEnabled = true;
            this.cmbdesg.Items.AddRange(new object[] {
            "Accountant",
            "Manager",
            "Worker",
            "Security",
            "Other"});
            this.cmbdesg.Location = new System.Drawing.Point(547, 104);
            this.cmbdesg.MaxLength = 20;
            this.cmbdesg.Name = "cmbdesg";
            this.cmbdesg.Size = new System.Drawing.Size(197, 21);
            this.cmbdesg.TabIndex = 71;
            this.cmbdesg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbdesg_KeyPress);
            this.cmbdesg.Leave += new System.EventHandler(this.cmbdesg_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(414, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(414, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Monthly Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(414, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Date of Joining";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 195);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(478, 328);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 33);
            this.btnclear.TabIndex = 78;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(616, 328);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(123, 33);
            this.btnremove.TabIndex = 79;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(338, 328);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(123, 33);
            this.btnsave.TabIndex = 77;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Transparent;
            this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodify.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.Location = new System.Drawing.Point(198, 328);
            this.btnmodify.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(123, 33);
            this.btnmodify.TabIndex = 76;
            this.btnmodify.Text = "Modify";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click_1);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnew.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(55, 328);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(123, 33);
            this.btnnew.TabIndex = 75;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(544, 80);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 18);
            this.lblemail.TabIndex = 90;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtemail.Location = new System.Drawing.Point(548, 52);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.MaxLength = 40;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(196, 26);
            this.txtemail.TabIndex = 70;
            this.txtemail.TextAlignChanged += new System.EventHandler(this.txtemail_TextAlignChanged);
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.BackColor = System.Drawing.Color.Transparent;
            this.lblmobile.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.ForeColor = System.Drawing.Color.Red;
            this.lblmobile.Location = new System.Drawing.Point(173, 278);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(0, 18);
            this.lblmobile.TabIndex = 89;
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtmobile.Location = new System.Drawing.Point(178, 250);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(196, 26);
            this.txtmobile.TabIndex = 69;
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            this.txtmobile.Leave += new System.EventHandler(this.txtmobile_Leave_1);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.Red;
            this.lbladdress.Location = new System.Drawing.Point(174, 226);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(0, 18);
            this.lbladdress.TabIndex = 88;
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtadd.Location = new System.Drawing.Point(178, 160);
            this.txtadd.Margin = new System.Windows.Forms.Padding(4);
            this.txtadd.MaxLength = 200;
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(196, 62);
            this.txtadd.TabIndex = 68;
            this.txtadd.Leave += new System.EventHandler(this.txtadd_Leave);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtid.Location = new System.Drawing.Point(177, 55);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 26);
            this.txtid.TabIndex = 66;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Red;
            this.lblname.Location = new System.Drawing.Point(174, 132);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 18);
            this.lblname.TabIndex = 87;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtname.Location = new System.Drawing.Point(178, 104);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.MaxLength = 40;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(196, 26);
            this.txtname.TabIndex = 67;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(414, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Email ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(42, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Worker ID";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(808, 27);
            this.label6.TabIndex = 81;
            this.label6.Text = "Manage Worker Records...";
            // 
            // FrmEmployeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.images__7_1;
            this.ClientSize = new System.Drawing.Size(808, 571);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.dptdob);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbldoj);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lbldesg);
            this.Controls.Add(this.dtpdoj);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.cmbdesg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblmobile);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FrmEmployeeRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Records";
            this.Load += new System.EventHandler(this.FrmEmployeeRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.DateTimePicker dptdob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbldoj;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lbldesg;
        private System.Windows.Forms.DateTimePicker dtpdoj;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.ComboBox cmbdesg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}