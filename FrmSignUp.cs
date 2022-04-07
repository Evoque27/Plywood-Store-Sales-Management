using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;

namespace Final_Project
{
    public partial class FrmSignUp : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        string sqlq = "";
        int auto, temp;

        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {




            string acctype;
            acctype = "";

            if (rademp.Checked == true)
                acctype = "Employee";
            else
                acctype = "";

            if (radadmin.Checked == true)
                acctype = "Admin";

            //Email Already Exists
            cs.ec();
            da = new SqlDataAdapter("select * from Accounts where EmailID='" + txtemail.Text + "' ", cs.cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email Already Exists. Kindly use the different one.", "Duplicate Email ID.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return;
            }
            //End Of Code Email Already Exists

            if (lblname.Text == "" && lblemail.Text == "" && lblpassword.Text == "" && lblreenterpassword.Text == "" & lblsecpin.Text == "" && acctype != "")
            {
                //code for account creation.
                autogenerate();
                cs.ec();

                //Encryption code.
                string pass;
                using (MD5 md5Hash = MD5.Create())
                {
                    pass = GetMd5Hash(md5Hash, txtpassword.Text);
                }
                //End of Encryption code.

                sqlq = "insert into Accounts values('" + auto + "', '" + txtname.Text + "', '" + txtemail.Text + "', '" + pass + "', '" + txtsecpin.Text + "', '" + acctype + "', NULL)";
                cmd = new SqlCommand(sqlq, cs.cn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlq;
                cmd.ExecuteNonQuery();
                cmd = null;

                sendmail("storesheet25@gmail.com", "sheetstore@124", txtemail.Text, "Account Created", "Hello,<br />Your Account has been created successfully.<br /><br />Credentials are given below:<br />UserId: " + txtemail.Text + "<br />Password: " + txtpassword.Text + "<br />Security Pin: " + txtsecpin.Text + "<br /><br />Use the security pin to reset your password. Kindly do not share the login credentials with anyone.<br /><br /><br />Kind regards,<br />Team TSS.");

                txtemail.Text = "";
                txtname.Text = "";
                txtpassword.Text = "";
                txtreenterpassword.Text = "";
                txtsecpin.Text = "";
                rademp.Checked = true;

                txtname.Focus();
            }
            else
            {
                //code for errors.
                txtname_Leave(sender, e);
                txtemail_Leave(sender, e);
                txtpassword_Leave(sender, e);
                txtreenterpassword_Leave(sender, e);
                txtsecpin_Leave(sender, e);


                if (txtsecpin.Text == "")
                    txtsecpin.Focus();

                if (txtreenterpassword.Text == "")
                    txtreenterpassword.Focus();

                if (txtpassword.Text == "")
                    txtpassword.Focus();

                if (txtemail.Text == "")
                    txtemail.Focus();

                if (txtname.Text == "")
                    txtname.Focus();
            }



        }

        public void getdata()
        {
            da = new SqlDataAdapter("select * from Accounts", cs.cn);
            dt = new DataTable();
            da.Fill(dt);
        }

        public void autogenerate()
        {
            auto = 0;
            temp = 0;

            getdata();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    temp = Convert.ToInt32(dt.Rows[i]["Srno"].ToString());
                }
                auto = temp + 1;
            }
            else
            {
                auto = 1;
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
                MessageBox.Show("Account Created Successfully & EMail Sent to your registered Address.", "Check your Mail-Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account Created Successfully.", "NEW ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Error While Sending EMail.  " + ex.ToString(), "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnreset_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
            txtname.Text = "";
            txtpassword.Text = "";
            txtreenterpassword.Text = "";
            txtsecpin.Text = "";
            rademp.Checked = true;

            lblemail.Text = "";
            lblname.Text = "";
            lblpassword.Text = "";
            lblreenterpassword.Text = "";
            lblsecpin.Text = "";

            txtname.Focus();

        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                lblname.Text = "Enter Name.";
            else
                lblname.Text = "";
        }

        private void txtname_Leave_1(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                lblname.Text = "Enter Name.";
            else
                lblname.Text = "";
        }
        public void onlynumbers(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) != 8)      //For Backspace Work.
            {
                if (e.KeyChar > 60 || e.KeyChar > 71)
                {
                    e.Handled = true;
                    Console.Beep();
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

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
                lblpassword.Text = "Enter Password.";
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

        private void txtreenterpassword_Leave(object sender, EventArgs e)
        {
            if (txtreenterpassword.Text == "")
                lblreenterpassword.Text = "Re-Enter Same Password.";
            else
            {
                lblreenterpassword.Text = "";
                if (txtreenterpassword.Text != txtpassword.Text)
                {
                    lblreenterpassword.Text = "Password doesnot match.";
                }
                else
                    lblreenterpassword.Text = "";
            }

        }

        private void txtsecpin_Leave(object sender, EventArgs e)
        {
            if (txtsecpin.Text == "")
                lblsecpin.Text = "Enter Security Pin.";
            else
            {
                lblsecpin.Text = "";
                if (txtsecpin.Text.Length < 4)
                {
                    lblsecpin.Text = "Security Pin must be of 4 digits.";
                }
                else
                {

                    int res;
                    if (int.TryParse(txtsecpin.Text, out res))
                    {
                        lblsecpin.Text = "";
                    }
                    else
                    {
                        lblsecpin.Text = "Security pin must contains digits only.";
                    }
                }
            }

        }

        private void txtsecpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            try
            {
                cs.ec();
                txtemail.Text = "";
                txtname.Text = "";
                txtpassword.Text = "";
                txtreenterpassword.Text = "";
                txtsecpin.Text = "";
                rademp.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Load..." + ex.ToString(), "Error Occurred", MessageBoxButtons.OK);
            }


        }
    }
}
