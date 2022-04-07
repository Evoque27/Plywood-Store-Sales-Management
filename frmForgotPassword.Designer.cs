namespace Final_Project
{
    partial class frmForgotPassword
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
            this.lblback = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpin = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnpro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.BackColor = System.Drawing.Color.Transparent;
            this.lblback.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblback.Location = new System.Drawing.Point(605, 234);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(66, 18);
            this.lblback.TabIndex = 58;
            this.lblback.TabStop = true;
            this.lblback.Text = "<< Back";
            this.lblback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblback_LinkClicked);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(710, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Reset Your Login Password Here";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblpin
            // 
            this.lblpin.AutoSize = true;
            this.lblpin.BackColor = System.Drawing.Color.Transparent;
            this.lblpin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpin.ForeColor = System.Drawing.Color.Red;
            this.lblpin.Location = new System.Drawing.Point(378, 164);
            this.lblpin.Name = "lblpin";
            this.lblpin.Size = new System.Drawing.Size(0, 18);
            this.lblpin.TabIndex = 55;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(378, 102);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 18);
            this.lblemail.TabIndex = 54;
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(381, 139);
            this.txtpin.Margin = new System.Windows.Forms.Padding(4);
            this.txtpin.MaxLength = 4;
            this.txtpin.Name = "txtpin";
            this.txtpin.PasswordChar = '*';
            this.txtpin.Size = new System.Drawing.Size(287, 26);
            this.txtpin.TabIndex = 50;
            this.txtpin.Leave += new System.EventHandler(this.txtpin_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtemail.Location = new System.Drawing.Point(381, 77);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(287, 26);
            this.txtemail.TabIndex = 49;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // btnpro
            // 
            this.btnpro.BackColor = System.Drawing.Color.Transparent;
            this.btnpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpro.ForeColor = System.Drawing.Color.Red;
            this.btnpro.Location = new System.Drawing.Point(381, 193);
            this.btnpro.Margin = new System.Windows.Forms.Padding(4);
            this.btnpro.Name = "btnpro";
            this.btnpro.Size = new System.Drawing.Size(287, 33);
            this.btnpro.TabIndex = 51;
            this.btnpro.Text = "Proceed";
            this.btnpro.UseVisualStyleBackColor = false;
            this.btnpro.Click += new System.EventHandler(this.btnpro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(261, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Security Pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(261, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Email ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(41, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.images__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 268);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpin);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtpin);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnpro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpin;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtpin;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnpro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}