namespace Final_Project
{
    partial class FrmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnpro = new System.Windows.Forms.Button();
            this.lblreenternewpass = new System.Windows.Forms.Label();
            this.txtreenternewpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbloldpass = new System.Windows.Forms.Label();
            this.txtpassold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Email ID";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(238, 57);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(86, 18);
            this.lblemail.TabIndex = 51;
            this.lblemail.Text = "User Email";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(370, 239);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 33);
            this.btnclear.TabIndex = 43;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnpro
            // 
            this.btnpro.BackColor = System.Drawing.Color.Transparent;
            this.btnpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpro.ForeColor = System.Drawing.Color.Red;
            this.btnpro.Location = new System.Drawing.Point(241, 239);
            this.btnpro.Margin = new System.Windows.Forms.Padding(4);
            this.btnpro.Name = "btnpro";
            this.btnpro.Size = new System.Drawing.Size(121, 33);
            this.btnpro.TabIndex = 42;
            this.btnpro.Text = "Proceed";
            this.btnpro.UseVisualStyleBackColor = false;
            this.btnpro.Click += new System.EventHandler(this.btnpro_Click);
            // 
            // lblreenternewpass
            // 
            this.lblreenternewpass.AutoSize = true;
            this.lblreenternewpass.BackColor = System.Drawing.Color.Transparent;
            this.lblreenternewpass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreenternewpass.ForeColor = System.Drawing.Color.Red;
            this.lblreenternewpass.Location = new System.Drawing.Point(236, 212);
            this.lblreenternewpass.Name = "lblreenternewpass";
            this.lblreenternewpass.Size = new System.Drawing.Size(0, 18);
            this.lblreenternewpass.TabIndex = 50;
            // 
            // txtreenternewpass
            // 
            this.txtreenternewpass.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtreenternewpass.Location = new System.Drawing.Point(240, 184);
            this.txtreenternewpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtreenternewpass.MaxLength = 10;
            this.txtreenternewpass.Name = "txtreenternewpass";
            this.txtreenternewpass.Size = new System.Drawing.Size(251, 26);
            this.txtreenternewpass.TabIndex = 41;
            this.txtreenternewpass.Leave += new System.EventHandler(this.txtreenternewpass_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(50, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Re-Enter New Password";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.BackColor = System.Drawing.Color.Transparent;
            this.lblnewpass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.ForeColor = System.Drawing.Color.Red;
            this.lblnewpass.Location = new System.Drawing.Point(237, 159);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(0, 18);
            this.lblnewpass.TabIndex = 48;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtnewpass.Location = new System.Drawing.Point(241, 131);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewpass.MaxLength = 10;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(251, 26);
            this.txtnewpass.TabIndex = 40;
            this.txtnewpass.Leave += new System.EventHandler(this.txtnewpass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(51, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "New Password";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(559, 27);
            this.label6.TabIndex = 46;
            this.label6.Text = "Change Password";
            // 
            // lbloldpass
            // 
            this.lbloldpass.AutoSize = true;
            this.lbloldpass.BackColor = System.Drawing.Color.Transparent;
            this.lbloldpass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpass.ForeColor = System.Drawing.Color.Red;
            this.lbloldpass.Location = new System.Drawing.Point(237, 107);
            this.lbloldpass.Name = "lbloldpass";
            this.lbloldpass.Size = new System.Drawing.Size(0, 18);
            this.lbloldpass.TabIndex = 45;
            // 
            // txtpassold
            // 
            this.txtpassold.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtpassold.Location = new System.Drawing.Point(241, 79);
            this.txtpassold.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassold.MaxLength = 10;
            this.txtpassold.Name = "txtpassold";
            this.txtpassold.Size = new System.Drawing.Size(251, 26);
            this.txtpassold.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Old Password";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.download__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnpro);
            this.Controls.Add(this.lblreenternewpass);
            this.Controls.Add(this.txtreenternewpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblnewpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbloldpass);
            this.Controls.Add(this.txtpassold);
            this.Controls.Add(this.label2);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnpro;
        private System.Windows.Forms.Label lblreenternewpass;
        private System.Windows.Forms.TextBox txtreenternewpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbloldpass;
        private System.Windows.Forms.TextBox txtpassold;
        private System.Windows.Forms.Label label2;
    }
}