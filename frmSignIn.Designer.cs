namespace Final_Project
{
    partial class frmSignIn
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
            this.lblattempt = new System.Windows.Forms.Label();
            this.lblforgotpassword = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnsignin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblattempt
            // 
            this.lblattempt.BackColor = System.Drawing.Color.Transparent;
            this.lblattempt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblattempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblattempt.ForeColor = System.Drawing.Color.Red;
            this.lblattempt.Location = new System.Drawing.Point(0, 258);
            this.lblattempt.Name = "lblattempt";
            this.lblattempt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblattempt.Size = new System.Drawing.Size(716, 16);
            this.lblattempt.TabIndex = 48;
            // 
            // lblforgotpassword
            // 
            this.lblforgotpassword.AutoSize = true;
            this.lblforgotpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblforgotpassword.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblforgotpassword.Location = new System.Drawing.Point(464, 171);
            this.lblforgotpassword.Name = "lblforgotpassword";
            this.lblforgotpassword.Size = new System.Drawing.Size(212, 18);
            this.lblforgotpassword.TabIndex = 40;
            this.lblforgotpassword.TabStop = true;
            this.lblforgotpassword.Text = "Forgot Password? Click Here";
            this.lblforgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblforgotpassword_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(41, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(716, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Login into Account";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblpassword.ForeColor = System.Drawing.Color.Red;
            this.lblpassword.Location = new System.Drawing.Point(378, 148);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(0, 18);
            this.lblpassword.TabIndex = 45;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(378, 86);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 18);
            this.lblemail.TabIndex = 44;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtpassword.Location = new System.Drawing.Point(381, 123);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.MaxLength = 10;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(287, 26);
            this.txtpassword.TabIndex = 39;
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtemail.Location = new System.Drawing.Point(381, 61);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(287, 26);
            this.txtemail.TabIndex = 38;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.Transparent;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.Red;
            this.btnsignin.Location = new System.Drawing.Point(381, 201);
            this.btnsignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(287, 33);
            this.btnsignin.TabIndex = 41;
            this.btnsignin.Text = "Sign-In";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(261, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(261, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email ID";
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.images__1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 274);
            this.Controls.Add(this.lblattempt);
            this.Controls.Add(this.lblforgotpassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblattempt;
        private System.Windows.Forms.LinkLabel lblforgotpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}