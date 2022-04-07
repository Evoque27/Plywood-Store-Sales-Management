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
using System.Text.RegularExpressions;

namespace Final_Project
{
    public partial class frmSignIn : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        int count;

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {

            try
            {
                cs.ec();
                txtemail.Text = "";
                txtpassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Load..." + ex.ToString(), "Error Occurred", MessageBoxButtons.OK);
            }
        }

        private void lblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword fpass = new frmForgotPassword();
            fpass.Show();
            this.Hide();

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

        public void getdata()
        {
            string pass;
            using (MD5 md5Hash = MD5.Create())
            {
                pass = GetMd5Hash(md5Hash, txtpassword.Text);
            }
            cs.ec();
            try
            {
                da = new SqlDataAdapter("select * from Accounts where EmailID='" + txtemail.Text + "' and Password='" + pass + "' ", cs.cn);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting Database. Check BackEnd Status.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (count <= 3)
            {
                if (txtemail.Text != "" && txtpassword.Text != "" && lblpassword.Text == "" && lblemail.Text == "")
                {
                    count = count + 1;
                    getdata();
                    if (dt.Rows.Count > 0)
                    {

                        FrmMDI fmdi = new FrmMDI();
                        string uname, mode, emailid, lastlogin;

                        uname = dt.Rows[0]["Name"].ToString();
                        mode = dt.Rows[0]["AccountType"].ToString();
                        emailid = dt.Rows[0]["EmailID"].ToString();
                        lastlogin = dt.Rows[0]["lastLogin"].ToString();

                        fmdi.username = uname;
                        fmdi.usermode = mode;
                        fmdi.useremail = emailid;
                        fmdi.userlastlogin = lastlogin;

                        FrmChangePassword cp = new FrmChangePassword();
                        //cp.lbl

                        //string pass = dt.Rows[0]["Password"].ToString();

                        //Updating LastLogin Field.
                        cs.ec();
                        string sqlq = "Update Accounts Set LastLogin='" + DateTime.Now + "' where EmailID='" + txtemail.Text + "' ";
                        cmd = new SqlCommand();
                        cmd.Connection = cs.cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlq;
                        cmd.ExecuteNonQuery();
                        cmd = null;

                        txtemail.Text = "";
                        txtpassword.Text = "";
                        lblemail.Text = "";
                        lblpassword.Text = "";

                        //code for redirecting to main.
                        fmdi.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblpassword.Text = "Either Email ID or Password is incorrect.";
                        lblattempt.Text = "Remaining Attempts " + (3 - count);
                        txtpassword.Focus();
                        if (count >= 3)
                        {
                            MessageBox.Show("Exceeded Maximum Attempts 'Exiting Application'", "Login Failed", MessageBoxButtons.OK);
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    //code for errors
                    txtemail_Leave(sender, e);
                    txtpassword_Leave(sender, e);

                    //code for focusing
                    if (lblemail.Text != "")
                        txtemail.Focus();
                    if (lblpassword.Text != "")
                        txtpassword.Focus();
                }
            }

        }

        private void txtemail_Leave(object sender, EventArgs e)
        {

            if (txtemail.Text == "")
            {
                lblemail.Text = "Enter Your Email Address.";
            }
            else
            {
                lblemail.Text = "";
                string pattern = null;
                pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                if (Regex.IsMatch(txtemail.Text, pattern))
                {
                    lblemail.Text = "";
                }
                else
                {
                    lblemail.Text = "Not a valid Email Address.";
                }
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
                lblpassword.Text = "Enter Your Password.";
            else
            {
                lblpassword.Text = "";
                if (txtpassword.Text.Length < 8)
                {
                    lblpassword.Text = "Password must be of 8 characters.";
                }
                else
                    lblpassword.Text = "";
            }

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
