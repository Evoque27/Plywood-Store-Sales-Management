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
    public partial class FrmPurchase : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        SqlCommand cmd = new SqlCommand();
        Boolean chk = new Boolean();
        Boolean save = new Boolean();
        int i = 0;
        int auto = 0;
        int temp = 0;

        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
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
            da = new SqlDataAdapter("select * from PurchaseOrder", cs.cn);
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
            cmbsupid.Text = "";
            txtsupname.Text = "";
            cmbprodid.Text = "";
            txtproductname.Text = "";
            txtqty.Text = "";
            txtdesc.Text = "";
            dtpodate.Value = DateTime.Now.Date;
            dtpddate.Value = DateTime.Now.Date;
            txtcostprice.Text = "";
            cmbstatus.Text = "";
        }

        public void display()
        {
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[i]["OID"].ToString();
                cmbsupid.Text = dt.Rows[i]["SID"].ToString();
                txtsupname.Text = dt.Rows[i]["Sname"].ToString();
                cmbprodid.Text = dt.Rows[i]["PID"].ToString();
                txtproductname.Text = dt.Rows[i]["Pname"].ToString();
                txtqty.Text = dt.Rows[i]["Quantity"].ToString();
                txtdesc.Text = dt.Rows[i]["Description"].ToString();

                DateTime d = new DateTime();
                d = Convert.ToDateTime(dt.Rows[i]["Order_Date"].ToString());
                dtpodate.Value = d.Date;

                d = Convert.ToDateTime(dt.Rows[i]["Delivery_Date"].ToString());
                dtpddate.Value = d.Date;

                txtcostprice.Text = dt.Rows[i]["Cost"].ToString();
                cmbstatus.Text = dt.Rows[i]["Status"].ToString();
            }
        }

        public void disable()
        {
            txtid.Enabled = false;
            cmbsupid.Enabled = false;
            txtsupname.Enabled = false;
            cmbprodid.Enabled = false;
            txtproductname.Enabled = false;
            txtqty.Enabled = false;
            txtdesc.Enabled = false;
            dtpodate.Enabled = false;
            dtpddate.Enabled = false;
            txtcostprice.Enabled = false;
            cmbstatus.Enabled = false;
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
            cmbsupid.Enabled = true;
            //txtsupname.Enabled = true;
            cmbprodid.Enabled = true;
            //txtproductname.Enabled = true;
            txtqty.Enabled = true;
            txtdesc.Enabled = true;
            dtpodate.Enabled = true;
            dtpddate.Enabled = true;
            txtcostprice.Enabled = true;
            cmbstatus.Enabled = true;
        }

        public void clearerrmsg()
        {
            lblcostprice.Text = "";
            lblddate.Text = "";
            lbldesc.Text = "";
            lblorderdate.Text = "";
            lblproid.Text = "";
            lblqty.Text = "";
            lblstatus.Text = "";
            lblsupid.Text="";
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

        private void fillproid()
        {
            da = new SqlDataAdapter("select * from Stock", cs.cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbprodid.Items.Clear();
                for (int v = 0; v <= dt.Rows.Count - 1; v++)
                {
                    cmbprodid.Items.Add(dt.Rows[v]["PID"].ToString());
                }
            }
        }

        private void fillsupid()
        {
            da = new SqlDataAdapter("select * from Suppliers", cs.cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbsupid.Items.Clear();
                for (int v = 0; v <= dt.Rows.Count - 1; v++)
                {
                    cmbsupid.Items.Add(dt.Rows[v]["Sid"].ToString());
                }
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
            fillsupid();
            fillproid();
            txtid.Text = "SO" + auto.ToString();
            txtproductname.Focus();
            save = true;
            dataGridView1.Enabled = false;
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtproductname.Text != "")
            {
                enable();
                btnnew.Enabled = false;
                btnmodify.Enabled = false;
                btnsave.Enabled = true;
                btnremove.Enabled = false;
                btnclear.Enabled = true;

                cmbprodid.Enabled = false;
                txtqty.Enabled = false;
                if (cmbstatus.Text == "Delivered")
                    cmbstatus.Enabled = false;
                else
                    cmbstatus.Enabled = true;

                dataGridView1.Enabled = false;
                save = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sqlq = "";

            //code for validating form.
            if (cmbsupid.Text != "" && txtsupname.Text != "" && cmbprodid.Text != "" && txtproductname.Text != "" && txtdesc.Text != "" && txtqty.Text != "" && txtcostprice.Text != "" && cmbstatus.Text != "" && lblproid.Text == "" && lblsupid.Text == "" && lbldesc.Text == "" && lblqty.Text == "" && lblcostprice.Text == "" && lblorderdate.Text == "" && lblddate.Text == "" && lblstatus.Text == "")
            {
                //code for new/update records
                cs.ec();
                if (save == true)
                {
                    //code for new member
                    sqlq = "insert into PurchaseOrder values(" + auto + ",'" + txtid.Text + "','" + cmbsupid.Text + "','" + txtsupname.Text + "','" + cmbprodid.Text + "','" + txtproductname.Text + "','" + txtqty.Text + "','" + txtdesc.Text + "','" + dtpodate.Value.Date + "','" + dtpddate.Value.Date + "','" + txtcostprice.Text + "','" + cmbstatus.Text +"')";
                    cmd = new SqlCommand();
                    cmd.Connection = cs.cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlq;
                    cmd.ExecuteNonQuery();
                    cmd = null;
                    MessageBox.Show("Record Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //fetch qty from products and then add it.
                    if (cmbstatus.Enabled == true && cmbstatus.Text == "Delivered")
                    {
                        int oldqty, newqty;
                        oldqty = 0;
                        newqty = 0;
                        da = new SqlDataAdapter("select Quantity from Stock where PId='" + cmbprodid.Text + "' ", cs.cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            oldqty = Int32.Parse(dt.Rows[0]["Quantity"].ToString());
                            newqty = oldqty + Int32.Parse(txtqty.Text);
                        }
                        
                        sqlq = "Update Stock set Quantity='" + newqty.ToString() + "' where PId='" + cmbprodid.Text + "' ";                        
                        cmd = new SqlCommand();
                        cmd.Connection = cs.cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlq;
                        cmd.ExecuteNonQuery();
                        cmd = null;
                    }
                    //End of fetch qty from products and then add it.
                    
                    
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
                    sqlq = "Update PurchaseOrder set SID='" + cmbsupid.Text + "',Sname='" + txtsupname.Text + "',PID='" + cmbprodid.Text + "',Pname='" + txtproductname.Text + "',Quantity='" + txtqty.Text + "',Description='" + txtdesc.Text + "',Order_Date='" + dtpodate.Value.Date + "',Delivery_Date='" + dtpddate.Value.Date + "',Cost='" + txtcostprice.Text + "',Status='"+ cmbstatus.Text +"' where OID='" + txtid.Text + "' ";
                    cmd = new SqlCommand();
                    cmd.Connection = cs.cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlq;
                    cmd.ExecuteNonQuery();
                    cmd = null;
                    MessageBox.Show("Record Modified Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //fetch qty from products and then add it.
                    if (cmbstatus.Enabled == true && cmbstatus.Text == "Delivered")
                    {
                        int oldqty, newqty;
                        oldqty = 0;
                        newqty = 0;
                        da = new SqlDataAdapter("select Quantity from Stock where PId='" + cmbprodid.Text + "' ", cs.cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            oldqty = Int32.Parse(dt.Rows[0]["Quantity"].ToString());
                            newqty = oldqty + Int32.Parse(txtqty.Text);
                        }

                        sqlq = "Update Stock set Quantity='" + newqty.ToString() + "' where PId='" + cmbprodid.Text + "' ";
                        cmd = new SqlCommand();
                        cmd.Connection = cs.cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlq;
                        cmd.ExecuteNonQuery();
                        cmd = null;
                    }
                    //End of fetch qty from products and then add it.

                    
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
                cmbsupid_Leave(sender, e);
                cmbprodid_Leave(sender, e);
                txtqty_Leave(sender, e);
                txtdesc_Leave(sender, e);
                dtpodate_Leave(sender, e);
                dtpddate_Leave(sender, e);
                txtcostprice_Leave(sender, e);
                cmbstatus_Leave(sender, e);

                //code for focusing
                if (lblsupid.Text != "")
                {
                    cmbsupid.Focus();
                }
                else if (lblproid.Text != "")
                {
                    cmbprodid.Focus();
                }
                else if (lblqty.Text != "")
                {
                    txtqty.Focus();
                }
                else if (lbldesc.Text != "")
                {
                    txtdesc.Focus();
                }                
                else if (lblorderdate.Text != "")
                {
                    dtpodate.Focus();
                }
                else if (lblddate.Text != "")
                {
                    dtpddate.Focus();
                }
                else if (lblcostprice.Text != "")
                {
                    txtcostprice.Focus();
                }
                else if (lblstatus.Text != "")
                {
                    cmbstatus.Focus();
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
            if (txtproductname.Text != "")
            {
                try
                {
                    cs.ec();
                    String sqlq = "Delete from PurchaseOrder where OID= '" + txtid.Text + "' ";
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlq;
                    cmd.Connection = cs.cn;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Do you want to update products quantity", "Updating Quantity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes && cmbstatus.Text == "Delivered")
                    {
                        //fetch qty from products and then minus it.
                        int oldqty, newqty;
                        oldqty = 0;
                        newqty = 0;
                        da = new SqlDataAdapter("select Quantity from Stock where PId='" + cmbprodid.Text + "' ", cs.cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            oldqty = Int32.Parse(dt.Rows[0]["Quantity"].ToString());
                            newqty = oldqty - Int32.Parse(txtqty.Text);
                        }
                        string avail;
                        if (newqty == 0)
                            avail = "Out of Stock";
                        else
                            avail = "Available";

                        sqlq = "Update Stock set Quantity='" + newqty.ToString() + "', Availability='" + avail + "' where PId='" + cmbprodid.Text + "' ";
                        cmd = new SqlCommand();
                        cmd.Connection = cs.cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlq;
                        cmd.ExecuteNonQuery();
                        cmd = null;
                        //End of fetch qty from products and then minus it.
                    }


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

        private void cmbsupid_SelectedIndexChanged(object sender, EventArgs e)
        {
            da1 = new SqlDataAdapter("select * from Suppliers where Sid='"+ cmbsupid.Text +"' ", cs.cn);
            dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                txtsupname.Text = dt1.Rows[0]["Name"].ToString();
            }
        }

        private void cmbprodid_SelectedIndexChanged(object sender, EventArgs e)
        {
            da1 = new SqlDataAdapter("select * from Stock where PId='" + cmbprodid.Text + "' ", cs.cn);
            dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                txtproductname.Text = dt1.Rows[0]["PName"].ToString();
            }
        }

        public void onlyAlphabateandNo(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) != 8 && Convert.ToInt32(e.KeyChar) != 32)      //For Backspace Work.
            {
                if ((e.KeyChar < 65 || e.KeyChar > 122) && (e.KeyChar < 47 || e.KeyChar > 58))
                {
                    e.Handled = true;
                    Console.Beep();
                }
            }
        }

        private void cmbsupid_Leave(object sender, EventArgs e)
        {
            if (cmbsupid.Text == "")
                lblsupid.Text = "Enter Supplier ID.";
            else
                lblsupid.Text = "";
        }

        private void cmbprodid_Leave(object sender, EventArgs e)
        {
            if (cmbprodid.Text == "")
                lblproid.Text = "Enter Product ID.";
            else
                lblproid.Text = "";
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);
        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            if (txtqty.Text == "")
                lblqty.Text = "Enter Product Quantity.";
            else
                lblqty.Text = "";
        }

        private void txtdesc_Leave(object sender, EventArgs e)
        {
            if (txtdesc.Text == "")
                lbldesc.Text = "Enter Description about Product.";
            else
                lbldesc.Text = "";
        }

        private void dtpodate_Leave(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            DateTime d1 = new DateTime();

            d = Convert.ToDateTime(dtpodate.Value.Date);
            d1 = DateTime.Now.Date;

            TimeSpan ts = d1.Subtract(d);
            String res = ts.Days.ToString();
            int temp = Convert.ToInt16(res);
            if (temp < 0)
            {
                lblorderdate.Text = "Date can't be greater than today.";
            }
            else
            {
                lblorderdate.Text = "";
            }
        }

        private void dtpddate_Leave(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            DateTime d1 = new DateTime();

            d = Convert.ToDateTime(dtpodate.Value.Date);
            d1 = dtpddate.Value.Date;

            TimeSpan ts = d1.Subtract(d);
            String res = ts.Days.ToString();
            int temp = Convert.ToInt16(res);
            if (temp > 0)
            {
                lblddate.Text = "Date can't be greater than Order Date.";
            }
            else if (temp < 0)
            {
                lblddate.Text = "Date can't be less than Order Date.";
            }
            else
            {
                lblddate.Text = "";
            }
        }

        private void txtcostprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);
        }

        private void txtcostprice_Leave(object sender, EventArgs e)
        {
            if (txtcostprice.Text == "")
                lblcostprice.Text = "Enter Cost Price.";
            else
                lblcostprice.Text = "";
        }

        private void cmbstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabate(cmbstatus.Text,e);
        }

        private void cmbstatus_Leave(object sender, EventArgs e)
        {
            if (cmbstatus.Text == "")
                lblstatus.Text = "Enter order status.";
            else
                lblstatus.Text = "";
        }

        private void cmbsupid_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabateandNo(e);
        }

        private void cmbprodid_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAlphabateandNo(e);
        }
    }
}
