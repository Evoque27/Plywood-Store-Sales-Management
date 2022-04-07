using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Final_Project
{
    public partial class FrmChangePassword : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public String emailid;
        String temp;

        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

            try
            {
                cs.ec();
                FrmMDI fmdi = new FrmMDI();
                lblemail.Text = fmdi.lblemail.Text;

            }
            catch (Exception e1)
            {
                MessageBox.Show("Error in connection :: " + e1.ToString());
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


        private void btnpro_Click(object sender, EventArgs e)
        {
            String sqlq = "";

            if (lbloldpass.Text == "" && lblnewpass.Text == "" && lblreenternewpass.Text == "")
            {
                //Encryption code.
                string pass;
                using (MD5 md5Hash = MD5.Create())
                {
                    pass = GetMd5Hash(md5Hash, txtnewpass.Text);
                }
                //End of Encryption code.

                sqlq = "Update Accounts set Password='" + pass + "' where EmailID='" + lblemail.Text + "' ";
                cmd = new SqlCommand();
                cmd.Connection = cs.cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlq;
                cmd.ExecuteNonQuery();
                cmd = null;
                MessageBox.Show("Updated successfully.");

                btnclear_Click(sender, e);
                this.Hide();
            }
            else
            {
                txtoldpass_Leave(sender, e);
                txtnewpass_Leave(sender, e);
                txtreenternewpass_Leave(sender, e);

                if (lbloldpass.Text != "")
                {
                    txtpassold.Focus();
                }
                else if (lblnewpass.Text != "")
                {
                    txtnewpass.Focus();
                }
                else if (lblreenternewpass.Text != "")
                {
                    txtreenternewpass.Focus();
                }
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassold.Text = "";
            txtnewpass.Text = "";
            txtreenternewpass.Text = "";

            lbloldpass.Text = "";
            lblnewpass.Text = "";
            lblreenternewpass.Text = "";

            txtpassold.Focus();

        }
        private void txtoldpass_Leave(object sender, EventArgs e)
        {
            if (txtpassold.Text == "")
            {
                lbloldpass.Text = "Enter old password.";
            }
            else
            {
                FrmMDI fmdi1 = new FrmMDI();
                emailid = fmdi1.useremail;
                String pass = "";
                lbloldpass.Text = "";

                //check in db for pass
                da = new SqlDataAdapter("select Password from Accounts where EmailID='" + lblemail.Text + "' ", cs.cn);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pass = dt.Rows[0]["Password"].ToString();
                }

                //Encryption code.
                string enterpass;
                using (MD5 md5Hash = MD5.Create())
                {
                    enterpass = GetMd5Hash(md5Hash, txtpassold.Text);
                }
                //End of Encryption code.

                if (pass == enterpass)
                {
                    lbloldpass.Text = "";
                }
                else
                {
                    lbloldpass.Text = "Password does not match.";
                }
            }
        }

        
        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (txtnewpass.Text == "")
            {
                lblnewpass.Text = "Enter new password.";
            }
            else
            {
                lblnewpass.Text = "";
                if (txtnewpass.Text.Length < 8)
                {
                    lblnewpass.Text = "Password must be of 8 characters";
                }
                else
                {
                    lblnewpass.Text = "";
                }
            }
        }

        private void txtreenternewpass_Leave(object sender, EventArgs e)
        {
            if (txtreenternewpass.Text == "")
            {
                lblreenternewpass.Text = "Re-enter password.";
            }
            else
            {
                lblreenternewpass.Text = "";
                if (txtnewpass.Text == txtreenternewpass.Text)
                {
                    lblreenternewpass.Text = "";
                }
                else
                {
                    lblreenternewpass.Text = "Password does not match.";
                }
            }
        }
    }
}
