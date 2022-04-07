namespace Final_Project
{
    partial class FrmDeactivateAccount
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
            this.lblemail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbuser = new System.Windows.Forms.ComboBox();
            this.btnpro = new System.Windows.Forms.Button();
            this.lblloggedemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(181, 78);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 18);
            this.lblemail.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(51, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Email ID";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 27);
            this.label6.TabIndex = 57;
            this.label6.Text = "Remove Worker Access!!!";
            // 
            // cmbuser
            // 
            this.cmbuser.FormattingEnabled = true;
            this.cmbuser.Location = new System.Drawing.Point(184, 50);
            this.cmbuser.Name = "cmbuser";
            this.cmbuser.Size = new System.Drawing.Size(197, 26);
            this.cmbuser.TabIndex = 1;
            this.cmbuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbuser_KeyPress);
            this.cmbuser.Leave += new System.EventHandler(this.cmbuser_Leave);
            // 
            // btnpro
            // 
            this.btnpro.BackColor = System.Drawing.Color.Transparent;
            this.btnpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpro.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpro.Location = new System.Drawing.Point(184, 111);
            this.btnpro.Margin = new System.Windows.Forms.Padding(4);
            this.btnpro.Name = "btnpro";
            this.btnpro.Size = new System.Drawing.Size(197, 33);
            this.btnpro.TabIndex = 2;
            this.btnpro.Text = "Proceed";
            this.btnpro.UseVisualStyleBackColor = false;
            this.btnpro.Click += new System.EventHandler(this.btnpro_Click);
            // 
            // lblloggedemail
            // 
            this.lblloggedemail.AutoSize = true;
            this.lblloggedemail.BackColor = System.Drawing.Color.Transparent;
            this.lblloggedemail.Location = new System.Drawing.Point(1, 169);
            this.lblloggedemail.Name = "lblloggedemail";
            this.lblloggedemail.Size = new System.Drawing.Size(0, 18);
            this.lblloggedemail.TabIndex = 58;
            this.lblloggedemail.Visible = false;
            // 
            // FrmDeactivateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.images__9_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 188);
            this.Controls.Add(this.lblloggedemail);
            this.Controls.Add(this.btnpro);
            this.Controls.Add(this.cmbuser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDeactivateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deactivate Account";
            this.Load += new System.EventHandler(this.FrmDeactivateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbuser;
        private System.Windows.Forms.Button btnpro;
        public System.Windows.Forms.Label lblloggedemail;
    }
}