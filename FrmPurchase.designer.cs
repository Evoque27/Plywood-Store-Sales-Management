namespace Final_Project
{
    partial class FrmPurchase
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
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lblcostprice = new System.Windows.Forms.Label();
            this.txtcostprice = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsupid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsupname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbsupid = new System.Windows.Forms.ComboBox();
            this.cmbprodid = new System.Windows.Forms.ComboBox();
            this.lblproid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpodate = new System.Windows.Forms.DateTimePicker();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.lblddate = new System.Windows.Forms.Label();
            this.dtpddate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "InProcess",
            "Delivered"});
            this.cmbstatus.Location = new System.Drawing.Point(559, 305);
            this.cmbstatus.MaxLength = 10;
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(197, 26);
            this.cmbstatus.TabIndex = 11;
            this.cmbstatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbstatus_KeyPress);
            this.cmbstatus.Leave += new System.EventHandler(this.cmbstatus_Leave);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(556, 337);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 18);
            this.lblstatus.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(423, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 112;
            this.label10.Text = "Status";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Transparent;
            this.lblqty.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Red;
            this.lblqty.Location = new System.Drawing.Point(169, 333);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(0, 18);
            this.lblqty.TabIndex = 111;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtqty.Location = new System.Drawing.Point(173, 305);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.MaxLength = 5;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(196, 26);
            this.txtqty.TabIndex = 6;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(39, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 110;
            this.label9.Text = "Order Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 195);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(482, 368);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 33);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(620, 368);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(123, 33);
            this.btnremove.TabIndex = 16;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(342, 368);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(123, 33);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Transparent;
            this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodify.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.Location = new System.Drawing.Point(202, 368);
            this.btnmodify.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(123, 33);
            this.btnmodify.TabIndex = 13;
            this.btnmodify.Text = "Modify";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnew.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(59, 368);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(123, 33);
            this.btnnew.TabIndex = 12;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lblcostprice
            // 
            this.lblcostprice.AutoSize = true;
            this.lblcostprice.BackColor = System.Drawing.Color.Transparent;
            this.lblcostprice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostprice.ForeColor = System.Drawing.Color.Red;
            this.lblcostprice.Location = new System.Drawing.Point(555, 278);
            this.lblcostprice.Name = "lblcostprice";
            this.lblcostprice.Size = new System.Drawing.Size(0, 18);
            this.lblcostprice.TabIndex = 106;
            // 
            // txtcostprice
            // 
            this.txtcostprice.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtcostprice.Location = new System.Drawing.Point(560, 255);
            this.txtcostprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtcostprice.MaxLength = 5;
            this.txtcostprice.Name = "txtcostprice";
            this.txtcostprice.Size = new System.Drawing.Size(196, 26);
            this.txtcostprice.TabIndex = 10;
            this.txtcostprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcostprice_KeyPress);
            this.txtcostprice.Leave += new System.EventHandler(this.txtcostprice_Leave);
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.BackColor = System.Drawing.Color.Transparent;
            this.lbldesc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.Color.Red;
            this.lbldesc.Location = new System.Drawing.Point(555, 119);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(0, 18);
            this.lbldesc.TabIndex = 105;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtdesc.Location = new System.Drawing.Point(559, 53);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.MaxLength = 100;
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(196, 62);
            this.txtdesc.TabIndex = 7;
            this.txtdesc.Leave += new System.EventHandler(this.txtdesc_Leave);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtid.Location = new System.Drawing.Point(173, 53);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 26);
            this.txtid.TabIndex = 1;
            // 
            // txtproductname
            // 
            this.txtproductname.Enabled = false;
            this.txtproductname.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtproductname.Location = new System.Drawing.Point(173, 255);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductname.MaxLength = 20;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(196, 26);
            this.txtproductname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(423, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Cost Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(423, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 101;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 100;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "Order ID";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(841, 27);
            this.label6.TabIndex = 98;
            this.label6.Text = "Wholesaler Purchase";
            // 
            // lblsupid
            // 
            this.lblsupid.AutoSize = true;
            this.lblsupid.BackColor = System.Drawing.Color.Transparent;
            this.lblsupid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupid.ForeColor = System.Drawing.Color.Red;
            this.lblsupid.Location = new System.Drawing.Point(169, 127);
            this.lblsupid.Name = "lblsupid";
            this.lblsupid.Size = new System.Drawing.Size(0, 18);
            this.lblsupid.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(38, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 115;
            this.label7.Text = "Wholesaler ID";
            // 
            // txtsupname
            // 
            this.txtsupname.Enabled = false;
            this.txtsupname.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtsupname.Location = new System.Drawing.Point(173, 153);
            this.txtsupname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsupname.MaxLength = 30;
            this.txtsupname.Name = "txtsupname";
            this.txtsupname.Size = new System.Drawing.Size(196, 26);
            this.txtsupname.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(37, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 18);
            this.label11.TabIndex = 118;
            this.label11.Text = "Wholesaler Name";
            // 
            // cmbsupid
            // 
            this.cmbsupid.FormattingEnabled = true;
            this.cmbsupid.Location = new System.Drawing.Point(173, 99);
            this.cmbsupid.MaxLength = 10;
            this.cmbsupid.Name = "cmbsupid";
            this.cmbsupid.Size = new System.Drawing.Size(196, 26);
            this.cmbsupid.TabIndex = 2;
            this.cmbsupid.SelectedIndexChanged += new System.EventHandler(this.cmbsupid_SelectedIndexChanged);
            this.cmbsupid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbsupid_KeyPress);
            this.cmbsupid.Leave += new System.EventHandler(this.cmbsupid_Leave);
            // 
            // cmbprodid
            // 
            this.cmbprodid.FormattingEnabled = true;
            this.cmbprodid.Location = new System.Drawing.Point(172, 202);
            this.cmbprodid.MaxLength = 10;
            this.cmbprodid.Name = "cmbprodid";
            this.cmbprodid.Size = new System.Drawing.Size(196, 26);
            this.cmbprodid.TabIndex = 4;
            this.cmbprodid.SelectedIndexChanged += new System.EventHandler(this.cmbprodid_SelectedIndexChanged);
            this.cmbprodid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbprodid_KeyPress);
            this.cmbprodid.Leave += new System.EventHandler(this.cmbprodid_Leave);
            // 
            // lblproid
            // 
            this.lblproid.AutoSize = true;
            this.lblproid.BackColor = System.Drawing.Color.Transparent;
            this.lblproid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproid.ForeColor = System.Drawing.Color.Red;
            this.lblproid.Location = new System.Drawing.Point(168, 230);
            this.lblproid.Name = "lblproid";
            this.lblproid.Size = new System.Drawing.Size(0, 18);
            this.lblproid.TabIndex = 122;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(37, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 121;
            this.label8.Text = "Product ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(423, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 124;
            this.label5.Text = "Order Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(423, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 18);
            this.label12.TabIndex = 125;
            this.label12.Text = "Delivery Date";
            // 
            // dtpodate
            // 
            this.dtpodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpodate.Location = new System.Drawing.Point(558, 150);
            this.dtpodate.Name = "dtpodate";
            this.dtpodate.Size = new System.Drawing.Size(197, 26);
            this.dtpodate.TabIndex = 8;
            this.dtpodate.Leave += new System.EventHandler(this.dtpodate_Leave);
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.BackColor = System.Drawing.Color.Transparent;
            this.lblorderdate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.ForeColor = System.Drawing.Color.Red;
            this.lblorderdate.Location = new System.Drawing.Point(555, 179);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(0, 18);
            this.lblorderdate.TabIndex = 127;
            // 
            // lblddate
            // 
            this.lblddate.AutoSize = true;
            this.lblddate.BackColor = System.Drawing.Color.Transparent;
            this.lblddate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblddate.ForeColor = System.Drawing.Color.Red;
            this.lblddate.Location = new System.Drawing.Point(555, 228);
            this.lblddate.Name = "lblddate";
            this.lblddate.Size = new System.Drawing.Size(0, 18);
            this.lblddate.TabIndex = 129;
            // 
            // dtpddate
            // 
            this.dtpddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpddate.Location = new System.Drawing.Point(558, 199);
            this.dtpddate.Name = "dtpddate";
            this.dtpddate.Size = new System.Drawing.Size(197, 26);
            this.dtpddate.TabIndex = 9;
            this.dtpddate.Leave += new System.EventHandler(this.dtpddate_Leave);
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.images__15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 608);
            this.Controls.Add(this.lblddate);
            this.Controls.Add(this.dtpddate);
            this.Controls.Add(this.lblorderdate);
            this.Controls.Add(this.dtpodate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbprodid);
            this.Controls.Add(this.lblproid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbsupid);
            this.Controls.Add(this.txtsupname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblsupid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblcostprice);
            this.Controls.Add(this.txtcostprice);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase | Supplier Orders";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label lblcostprice;
        private System.Windows.Forms.TextBox txtcostprice;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsupid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsupname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbsupid;
        private System.Windows.Forms.ComboBox cmbprodid;
        private System.Windows.Forms.Label lblproid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpodate;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.Label lblddate;
        private System.Windows.Forms.DateTimePicker dtpddate;
    }
}