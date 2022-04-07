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
    public partial class FrmEmployeeRecords : Form
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
        int months;


        public FrmEmployeeRecords()
        {
            InitializeComponent();
        }
        private void FrmEmployeeRecords_Load(object sender, EventArgs e)
        {
            try
            {
                cs.ec();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connection ::");
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
            da = new SqlDataAdapter("select * from Employees", cs.cn);
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
            cmbdesg.Text = "";
            txtsal.Text = "";
            dptdob.Value = DateTime.Now.Date;
            dtpdoj.Value = DateTime.Now.Date;
        }

        public void display()
        {
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[i]["EmployeeID"].ToString();
                txtname.Text = dt.Rows[i]["Name"].ToString();
                txtadd.Text = dt.Rows[i]["Address"].ToString();
                txtmobile.Text = dt.Rows[i]["MobileNo"].ToString();
                txtemail.Text = dt.Rows[i]["EmailID"].ToString();
                cmbdesg.Text = dt.Rows[i]["Designation"].ToString();
                txtsal.Text = dt.Rows[i]["MonthlySalary"].ToString();
                //Dates
                DateTime d = new DateTime();
                d = Convert.ToDateTime(dt.Rows[i]["BirthDate"].ToString());
                dptdob.Value = d.Date;

                d = Convert.ToDateTime(dt.Rows[i]["JoiningDate"].ToString());
                dtpdoj.Value = d.Date;
            }
        }

        public void disable()
        {
            txtname.Enabled = false;
            txtadd.Enabled = false;
            txtmobile.Enabled = false;
            txtemail.Enabled = false;
            cmbdesg.Enabled = false;
            txtsal.Enabled = false;
            dptdob.Enabled = false;
            dtpdoj.Enabled = false;
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
            cmbdesg.Enabled = true;
            txtsal.Enabled = true;
            dptdob.Enabled = true;
            dtpdoj.Enabled = true;
        }

        public void clearerrmsg()
        {
            lbladdress.Text = "";
            lblemail.Text = "";
            lblmobile.Text = "";
            lblname.Text = "";
            lbldesg.Text = "";
            lblsal.Text = "";
            lbldob.Text = "";
            lbldoj.Text = "";
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
            txtid.Text = "E" + auto.ToString();
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
            if (txtname.Text != "" && txtadd.Text != "" && txtmobile.Text != "" && txtemail.Text != "" && cmbdesg.Text != "" && txtsal.Text != "" && lblname.Text == "" && lbladdress.Text == "" && lblmobile.Text == "" && lblemail.Text == "" && lbldesg.Text == "" && lblsal.Text == "" && lbldob.Text == "" && lbldoj.Text == "")
            {
                //code for new/update records
                cs.ec();
                if (save == true)
                {
                    //code for new member
                    sqlq = "insert into Employees values(" + auto + ",'" + txtid.Text + "','" + txtname.Text + "','" + txtadd.Text + "'," + txtmobile.Text + ",'" + txtemail.Text + "', '" + cmbdesg.Text + "','" + txtsal.Text + "','" + dptdob.Value.Date + "','" + dtpdoj.Value.Date + "')";
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
                    sqlq = "Update Employees set Name='" + txtname.Text + "',Address='" + txtadd.Text + "',MobileNo=" + txtmobile.Text + ",EmailID='" + txtemail.Text + "',Designation='" + cmbdesg.Text + "',MonthlySalary='" + txtsal.Text + "',BirthDate='" + dptdob.Value.Date + "',JoiningDate='" + dtpdoj.Value.Date + "' where EmployeeID='" + txtid.Text + "' ";
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
                cmbdesg_Leave(sender, e);
                txtsal_Leave(sender, e);
                dptdob_Leave(sender, e);
                dtpdoj_Leave(sender, e);

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
                else if (lbldesg.Text != "")
                {
                    cmbdesg.Focus();
                }
                else if (lblsal.Text != "")
                {
                    txtsal.Focus();
                }
                else if (lbldob.Text != "")
                {
                    dptdob.Focus();
                }
                else if (lbldoj.Text != "")
                {
                    dtpdoj.Focus();
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
                    String sqlq = "Delete from Employees where EmployeeID= '" + txtid.Text + "' ";
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

       

 
        private void btnmodify_Click_1(object sender, EventArgs e)
        {
            btnmodify_Click(sender, e);
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            btnsave_Click(sender, e);
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            btnclear_Click(sender, e);
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            btnremove_Click(sender, e);
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                lblname.Text = "Enter Employee Name.";
            else
                lblname.Text = "";
        }

        private void txtname_Leave_1(object sender, EventArgs e)
        {
            txtname_Leave(sender, e);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtadd_Leave(object sender, EventArgs e)
        {
            if (txtadd.Text == "")
                lbladdress.Text = "Enter Employee Address.";
            else
                lbladdress.Text = "";

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

        private void txtmobile_Leave_1(object sender, EventArgs e)
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

        private void txtemail_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbdesg_Leave(object sender, EventArgs e)
        {
            if (cmbdesg.Text == "")
                lbldesg.Text = "Enter Employee Designation.";
            else
                lbldesg.Text = "";

        }

        private void txtsal_Leave(object sender, EventArgs e)
        {
            if (txtsal.Text == "")
                lblsal.Text = "Enter Employee Salary.";
            else
                lblsal.Text = "";

        }

        private void cmbdesg_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabate(cmbdesg.Text, e);

        }

        private void txtsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);

        }

        private void dptdob_Leave(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            DateTime d1 = new DateTime();

            d = Convert.ToDateTime(dptdob.Value.Date);
            d1 = DateTime.Now.Date;

            int years = d1.Year - d.Year;

            //TimeSpan ts = d1.Subtract(d);
            //String res = ts.Days.ToString();

            //int temp = Convert.ToInt16(res);
            if (years >= 18)
            {
                lbldob.Text = "";
            }
            else
            {
                lbldob.Text = "Age should be minimum 18 years.";
            }

        }

        private void dtpdoj_Leave(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            DateTime d1 = new DateTime();

            d = Convert.ToDateTime(dtpdoj.Value.Date);
            d1 = DateTime.Now.Date;

            TimeSpan ts = d1.Subtract(d);
            String res = ts.Days.ToString();
            int temp = Convert.ToInt16(res);
            if (temp < 0)
            {
                lbldoj.Text = "Date can't be greater than today.";
            }
            else
            {
                lbldoj.Text = "";
            }

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabate(txtname.Text, e);
        }
    }
}
