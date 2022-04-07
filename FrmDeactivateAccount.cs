using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class FrmDeactivateAccount : Form
    {
        SqlCommand cmd = new SqlCommand();
        ConnectionString cs = new ConnectionString();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public String uname;
        public String mode;
        public FrmDeactivateAccount()
        {
            InitializeComponent();
        }

        private void FrmDeactivateAccount_Load(object sender, EventArgs e)
        {
            try
            {
                cs.ec();
                //fill ids.
                if (lblloggedemail.Text != "")
                {
                    da = new SqlDataAdapter("select * from Accounts where EmailID <> '" + lblloggedemail.Text + "' ", cs.cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lblemail.Text = "";
                        btnpro.Enabled = true;
                        int r = 0;
                        for (r = 0; r < dt.Rows.Count; r++)
                        {
                            cmbuser.Items.Add(dt.Rows[r]["EmailID"].ToString());
                        }
                    }
                    else
                    {
                        cmbuser.Items.Clear();
                        lblemail.Text = "Data Not Found.";
                        btnpro.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connection ::");
            }
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            String sqlq;
            if (cmbuser.Text != "")
            {
                cs.ec();
                sqlq = "Delete from Accounts where EmailID= '" + cmbuser.Text + "' ";
                cmd = new SqlCommand();
                cmd.Connection = cs.cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlq;
                cmd.ExecuteNonQuery();
                cmd = null;
                MessageBox.Show("Account Deactivated successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cmbuser.Text = "";

                try
                {
                    da = new SqlDataAdapter("select * from Accounts where EmailID <> '" + lblloggedemail.Text + "' ", cs.cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lblemail.Text = "";
                        btnpro.Enabled = true;
                        int r = 0;
                        for (r = 0; r < dt.Rows.Count; r++)
                        {
                            cmbuser.Items.Add(dt.Rows[r]["EmailID"].ToString());
                        }
                    }
                    else
                    {
                        cmbuser.Items.Clear();
                        lblemail.Text = "Data Not Found.";
                        btnpro.Enabled = false;
                    }
                }
                catch (Exception ex)
                { }
            }
            else
            { 
                cmbuser_Leave(sender, e); 
            }
        }

        private void cmbuser_Leave(object sender, EventArgs e)
        {
            if (cmbuser.Text == "")
            { 
                lblemail.Text = "Select User Email ID."; 
            }
            else
            { 
                lblemail.Text = ""; 
            }
        }

        public void onlyAlphabate(String str, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) != 8 && Convert.ToInt32(e.KeyChar) != 32)      //For Backspace Work.
            {
                if (e.KeyChar < 65 || e.KeyChar > 122)
                {
                    e.Handled = true;
                    Console.Beep();
                }
            }
        }

        private void cmbuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabate(cmbuser.Text, e);
        }
    }
}
