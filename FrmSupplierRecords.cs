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

namespace Final_Project
{
    public partial class FrmSupplierRecords : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        Boolean save = new Boolean();
        Boolean chk = new Boolean();
        int i = 0;
        int auto = 0;
        int temp = 0;

        public FrmSupplierRecords()
        {
            InitializeComponent();
        }

        private void FrmSupplierRecords_Load(object sender, EventArgs e)
        {
            try
            {
                cs.ec();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connection");
            }

            disable();
            blank();
            try
            {
                getdata();
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Enabled = true;
                }
                else
                {
                    dataGridView1.Enabled = false;
                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Err in fill Gridview OnLoad");
            }
            btnnew.Enabled = true;
            btnmodify.Enabled = false;
            btnsave.Enabled = false;
            btnremove.Enabled = false;
            btnclear.Enabled = true;

            clearerrmsg();
            chk = false;
        }

        public void getdata()
        {
            da = new SqlDataAdapter("select * from Suppliers", cs.cn);
            dt = new DataTable();
            da.Fill(dt);
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

        public void blank()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtadd.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
        }

        public void display()
        {
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[i]["Sid"].ToString();
                txtname.Text = dt.Rows[i]["Name"].ToString();
                txtadd.Text = dt.Rows[i]["Address"].ToString();
                txtmobile.Text = dt.Rows[i]["MobileNo"].ToString();
                txtemail.Text = dt.Rows[i]["EmailID"].ToString();
            }
        }

        public void disable()
        {
            txtname.Enabled = false;
            txtadd.Enabled = false;
            txtmobile.Enabled = false;
            txtemail.Enabled = false;
        }

        public void gridview()
        {
            try
            {
                blank();
                disable();
                i = dataGridView1.CurrentRow.Index;
                getdata();
                display();

                btnnew.Enabled = false;
                btnmodify.Enabled = true;
                btnsave.Enabled = false;
                btnremove.Enabled = true;
                btnclear.Enabled = true;
            }
            catch (Exception ex)
            {
            }
        }

        public void enable()
        {
            txtname.Enabled = true;
            txtadd.Enabled = true;
            txtmobile.Enabled = true;
            txtemail.Enabled = true;
        }

        public void clearerrmsg()
        {
            lbladdress.Text = "";
            lblemail.Text = "";
            lblmobile.Text = "";
            lblname.Text = "";
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            enable();

            btnnew.Enabled = false;
            btnmodify.Enabled = false;
            btnsave.Enabled = true;
            btnremove.Enabled = false;
            btnclear.Enabled = true;

            blank();
            autogenerate();
            txtid.Text = "S" + auto.ToString();
            txtname.Focus();
            save = true;
            dataGridView1.Enabled = false;
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                enable();
                btnnew.Enabled = false;
                btnmodify.Enabled = false;
                btnsave.Enabled = true;
                btnremove.Enabled = false;
                btnclear.Enabled = true;

                dataGridView1.Enabled = false;
                save = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sqlq = "";

            //code for validating form.
            if (txtname.Text != "" && txtadd.Text != "" && txtmobile.Text != "" && txtemail.Text != "" && lblname.Text == "" && lbladdress.Text == "" && lblmobile.Text == "" && lblemail.Text == "")
            {
                //code for new/update records
                cs.ec();
                if (save == true)
                {
                    //code for new member
                    sqlq = "insert into Suppliers values(" + auto + ",'" + txtid.Text + "','" + txtname.Text + "','" + txtadd.Text + "'," + txtmobile.Text + ",'" + txtemail.Text + "')";
                    cmd = new SqlCommand();
                    cmd.Connection = cs.cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlq;
                    cmd.ExecuteNonQuery();
                    cmd = null;
                    MessageBox.Show("Record Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Enabled = true;
                    disable();
                    blank();

                    btnnew.Enabled = true;
                    btnmodify.Enabled = false;
                    btnsave.Enabled = false;
                    btnremove.Enabled = false;
                    btnclear.Enabled = true;

                    try
                    {
                        getdata();
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Err in fill Gridview");
                    }
                }
                else
                {
                    //code for update emp
                    sqlq = "Update Suppliers set Name='" + txtname.Text + "',Address='" + txtadd.Text + "',MobileNo=" + txtmobile.Text + ",EmailID='" + txtemail.Text + "' where Sid='" + txtid.Text + "' ";
                    cmd = new SqlCommand();
                    cmd.Connection = cs.cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlq;
                    cmd.ExecuteNonQuery();
                    cmd = null;
                    MessageBox.Show("Record Modified Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Enabled = true;
                    disable();
                    blank();

                    btnnew.Enabled = true;
                    btnmodify.Enabled = false;
                    btnsave.Enabled = false;
                    btnremove.Enabled = false;
                    btnclear.Enabled = true;

                    try
                    {
                        getdata();
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Err in fill Gridview");
                    }
                }
            }
            else
            {
                //code for errors
                txtname_Leave(sender, e);
                txtadd_Leave(sender, e);
                txtmobile_Leave(sender, e);
                txtemail_Leave(sender, e);

                //code for focusing
                //code for focusing
                if (lblname.Text != "")
                {
                    txtname.Focus();
                }
                else if (lbladdress.Text != "")
                {
                    txtadd.Focus();
                }
                else if (lblmobile.Text != "")
                {
                    txtmobile.Focus();
                }
                else if (lblemail.Text != "")
                {
                    txtemail.Focus();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //text entry controls
            disable();
            blank();
            clearerrmsg();

            txtid.Text = "";
            btnnew.Enabled = true;
            btnmodify.Enabled = false;
            btnsave.Enabled = false;
            btnremove.Enabled = false;
            btnclear.Enabled = true;

            dataGridView1.Enabled = true;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                try
                {
                    cs.ec();
                    String sqlq = "Delete from Suppliers where Sid= '" + txtid.Text + "' ";
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlq;
                    cmd.Connection = cs.cn;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    disable();
                    blank();
                    clearerrmsg();

                    btnnew.Enabled = true;
                    btnmodify.Enabled = false;
                    btnsave.Enabled = false;
                    btnremove.Enabled = false;
                    btnclear.Enabled = true;

                    try
                    {
                        getdata();
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Err in fill Gridview");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select Record from List.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridview();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabate(txtname.Text, e);
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                lblname.Text = "Enter Supplier Name.";
            }
            else
            {
                lblname.Text = "";
            }
        }

        private void txtadd_Leave(object sender, EventArgs e)
        {
            if (txtadd.Text == "")
            {
                lbladdress.Text = "Enter Supplier Address.";
            }
            else
            {
                lbladdress.Text = "";
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);
        }

        private void txtmobile_Leave(object sender, EventArgs e)
        {
            String mystring = txtmobile.Text;
            char temp = ' ';
            if (txtmobile.Text == "")
            {
                lblmobile.Text = "Enter Mobile Number.";
            }
            if (txtmobile.Text.Length != 10)
            {
                lblmobile.Text = "Mobile No. should be of 10 digits.";
            }
            if (txtmobile.Text == "0000000000")
            {
                lblmobile.Text = "Mobile No. can not contain all zeros.";
            }
            if (mystring != "")
            {
                temp = Convert.ToChar(mystring[0]);
                if (temp != '7' && temp != '8' && temp != '9')
                {
                    lblmobile.Text = "Number can't start with " + mystring[0];
                }
            }

            if (txtmobile.Text != "")
            {
                if (txtmobile.Text.Length == 10 && txtmobile.Text != "0000000000")
                {
                    if (temp == '7' || temp == '8' || temp == '9')
                    {
                        lblmobile.Text = "";
                    }
                }
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                lblemail.Text = "Enter Email ID";
            }
            else
            {
                lblemail.Text = "";
                Regex regex = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                Match match = regex.Match(txtemail.Text);
                if (match.Success)
                    lblemail.Text = "";
                else
                    lblemail.Text = "Invalid Email ID.";
            }
        }
    }
}
