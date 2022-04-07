using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class frmForgotPassword : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        string p;


        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void lblback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignIn fsignin = new frmSignIn();
            fsignin.Show();
            this.Hide();

        }

        public void sendmail(String sender, String pass, String tos, String subject, String message)
        {
            try
            {
                NetworkCredential loginInfo = new NetworkCredential();
                loginInfo = new NetworkCredential(sender, pass);
                MailMessage msg = new MailMessage();
                msg = new MailMessage();
                msg.From = new MailAddress(sender);
                msg.To.Add(new MailAddress(tos));
                msg.Subject = subject;
                msg.Body = message;
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);
                MessageBox.Show("New password has been sent to your registered EMail Address.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Sending Password in EMail." + Environment.NewLine + "New password is " + p, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            cs.ec();
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Accounts where EmailID='" + txtemail.Text + "' ", cs.cn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                //Check Spin               
                if (txtpin.Text == dt.Rows[0]["Spin"].ToString())
                {
                    if (txtpin.Text != "" && txtemail.Text != "" && lblpin.Text == "" && lblemail.Text == "")
                    {
                        //New password Generation.
                        Random rnd = new Random();
                        int number = rnd.Next(10, 99);

                        p = "Mystore" + number;

                        //Encryption code.
                        string pass;
                        using (MD5 md5Hash = MD5.Create())
                        {
                            pass = GetMd5Hash(md5Hash, p);
                        }
                        //End of Encryption code.

                        //Updating Accounts Table
                        cs.ec();
                        string sqlq;
                        sqlq = "Update Accounts set Password='" + pass + "' where EmailID='" + txtemail.Text + "' ";
                        cmd = new SqlCommand(sqlq, cs.cn);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlq;
                        cmd.ExecuteNonQuery();
                        cmd = null;

                        //Sending Mail
                        sendmail("storesheet25@gmail.com", "sheetstore@124", txtemail.Text, "Forgot password!", "Hello,<br />Your password has been reset successfully.<br />Your New password is " + p + "<br /><br />Kindly change this password when you login into system.<br /><br /><br />Kind regards,<br />Team TSS.");

                        txtemail.Text = "";
                        txtpin.Text = "";
                        lblemail.Text = "";
                        lblpin.Text = "";
                        frmSignIn fsignin1 = new frmSignIn();
                        fsignin1.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Error Code.
                        txtemail_Leave(sender, e);
                        txtpin_Leave(sender, e);

                        if (lblemail.Text != "")
                            txtemail.Focus();
                        else if (lblpin.Text != "")
                            txtpin.Focus();
                    }
                }
                else
                {
                    //Pin mismatch.
                    lblpin.Text = "Incorrect Security Pin, Try Again!";
                }
            }

        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                lblemail.Text = "Enter Email Address.";
            }
            else
            {
                lblemail.Text = "";
                string pattern = null;

                pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9A-Za-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9A-Za-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9A-Za-z][-\w]*[0-9A-Za-z]*\.)+[a-zA-Z0-9][\-a-zA-Z0-9]{0,22}[a-zA-Z0-9]))$";

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

        private void txtpin_Leave(object sender, EventArgs e)
        {
            if (txtpin.Text == "")
                lblpin.Text = "Enter Security Pin.";
            else
            {
                lblpin.Text = "";
                if (txtpin.Text.Length < 4)
                {
                    lblpin.Text = "Security Pin must be of 4 digits.";
                }
                else
                {

                    int res;
                    if (int.TryParse(txtpin.Text, out res))
                    {
                        lblpin.Text = "";
                    }
                    else
                    {
                        lblpin.Text = "Security pin must contains digits only.";
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
