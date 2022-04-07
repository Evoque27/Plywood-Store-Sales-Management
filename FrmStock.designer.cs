namespace Final_Project
{
    partial class FrmStock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lblcompany = new System.Windows.Forms.Label();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.lblsellprice = new System.Windows.Forms.Label();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblproname = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcgst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsgst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtigst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 195);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(478, 306);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 33);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(616, 306);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(123, 33);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(338, 306);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(123, 33);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Transparent;
            this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodify.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.Location = new System.Drawing.Point(198, 306);
            this.btnmodify.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(123, 33);
            this.btnmodify.TabIndex = 10;
            this.btnmodify.Text = "Modify";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnew.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(55, 306);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(123, 33);
            this.btnnew.TabIndex = 9;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.BackColor = System.Drawing.Color.Transparent;
            this.lblcompany.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompany.ForeColor = System.Drawing.Color.Red;
            this.lblcompany.Location = new System.Drawing.Point(539, 133);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(0, 18);
            this.lblcompany.TabIndex = 74;
            // 
            // txtcompany
            // 
            this.txtcompany.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtcompany.Location = new System.Drawing.Point(543, 105);
            this.txtcompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtcompany.MaxLength = 20;
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(196, 26);
            this.txtcompany.TabIndex = 6;
            this.txtcompany.Leave += new System.EventHandler(this.txtcompany_Leave);
            // 
            // lblsellprice
            // 
            this.lblsellprice.AutoSize = true;
            this.lblsellprice.BackColor = System.Drawing.Color.Transparent;
            this.lblsellprice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsellprice.ForeColor = System.Drawing.Color.Red;
            this.lblsellprice.Location = new System.Drawing.Point(540, 78);
            this.lblsellprice.Name = "lblsellprice";
            this.lblsellprice.Size = new System.Drawing.Size(0, 18);
            this.lblsellprice.TabIndex = 73;
            // 
            // txtsellprice
            // 
            this.txtsellprice.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtsellprice.Location = new System.Drawing.Point(544, 50);
            this.txtsellprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtsellprice.MaxLength = 5;
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(196, 26);
            this.txtsellprice.TabIndex = 5;
            this.txtsellprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsellprice_KeyPress);
            this.txtsellprice.Leave += new System.EventHandler(this.txtsellprice_Leave);
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.BackColor = System.Drawing.Color.Transparent;
            this.lbldesc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.Color.Red;
            this.lbldesc.Location = new System.Drawing.Point(170, 221);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(0, 18);
            this.lbldesc.TabIndex = 72;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtdesc.Location = new System.Drawing.Point(174, 155);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.MaxLength = 100;
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(196, 62);
            this.txtdesc.TabIndex = 3;
            this.txtdesc.Leave += new System.EventHandler(this.txtdesc_Leave);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtid.Location = new System.Drawing.Point(173, 50);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 26);
            this.txtid.TabIndex = 1;
            // 
            // lblproname
            // 
            this.lblproname.AutoSize = true;
            this.lblproname.BackColor = System.Drawing.Color.Transparent;
            this.lblproname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproname.ForeColor = System.Drawing.Color.Red;
            this.lblproname.Location = new System.Drawing.Point(170, 127);
            this.lblproname.Name = "lblproname";
            this.lblproname.Size = new System.Drawing.Size(0, 18);
            this.lblproname.TabIndex = 71;
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtproductname.Location = new System.Drawing.Point(174, 99);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductname.MaxLength = 20;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(196, 26);
            this.txtproductname.TabIndex = 2;
            this.txtproductname.Leave += new System.EventHandler(this.txtproductname_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(409, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(409, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Sell Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(800, 27);
            this.label6.TabIndex = 65;
            this.label6.Text = "Manage Stock...";
            // 
            // txtcgst
            // 
            this.txtcgst.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtcgst.Location = new System.Drawing.Point(544, 158);
            this.txtcgst.Margin = new System.Windows.Forms.Padding(4);
            this.txtcgst.MaxLength = 10;
            this.txtcgst.Name = "txtcgst";
            this.txtcgst.Size = new System.Drawing.Size(196, 26);
            this.txtcgst.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(410, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 76;
            this.label8.Text = "CGST";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Transparent;
            this.lblqty.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Red;
            this.lblqty.Location = new System.Drawing.Point(170, 271);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(0, 18);
            this.lblqty.TabIndex = 80;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtqty.Location = new System.Drawing.Point(174, 243);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.MaxLength = 5;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(196, 26);
            this.txtqty.TabIndex = 4;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(40, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "Quantity Avail.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(410, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 82;
            this.label10.Text = "SGST";
            // 
            // txtsgst
            // 
            this.txtsgst.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtsgst.Location = new System.Drawing.Point(544, 206);
            this.txtsgst.Margin = new System.Windows.Forms.Padding(4);
            this.txtsgst.MaxLength = 10;
            this.txtsgst.Name = "txtsgst";
            this.txtsgst.Size = new System.Drawing.Size(196, 26);
            this.txtsgst.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(412, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 84;
            this.label7.Text = "IGST";
            // 
            // txtigst
            // 
            this.txtigst.AutoSize = true;
            this.txtigst.BackColor = System.Drawing.Color.Transparent;
            this.txtigst.Location = new System.Drawing.Point(541, 261);
            this.txtigst.Name = "txtigst";
            this.txtigst.Size = new System.Drawing.Size(18, 18);
            this.txtigst.TabIndex = 85;
            this.txtigst.Text = "0";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.images__15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.txtigst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsgst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcgst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblcompany);
            this.Controls.Add(this.txtcompany);
            this.Controls.Add(this.lblsellprice);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblproname);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock | Products";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label lblcompany;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.Label lblsellprice;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblproname;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcgst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsgst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtigst;
    }
}