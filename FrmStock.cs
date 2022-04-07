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
    public partial class FrmStock : Form
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

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
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
            da = new SqlDataAdapter("select * from Stock", cs.cn);
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
            txtproductname.Text = "";
            txtdesc.Text = "";
            txtqty.Text = "";
            txtsellprice.Text = "";
            txtcompany.Text = "";
            txtcgst.Text = "";
            txtsgst.Text = "";
        }

        public void display()
        {
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[i]["PId"].ToString();
                txtproductname.Text = dt.Rows[i]["PName"].ToString();
                txtdesc.Text = dt.Rows[i]["Description"].ToString();
                txtqty.Text = dt.Rows[i]["Quantity"].ToString();
                txtsellprice.Text = dt.Rows[i]["Price"].ToString();
                txtcompany.Text = dt.Rows[i]["Company"].ToString();
                txtcgst.Text = dt.Rows[i]["cgst"].ToString();
                txtsgst.Text = dt.Rows[i]["sgst"].ToString();
                txtigst.Text = dt.Rows[i]["igst"].ToString();
            }
        }

        public void disable()
        {
            txtid.Enabled = false;
            txtproductname.Enabled = false;
            txtdesc.Enabled = false;
            txtqty.Enabled = false;
            txtsellprice.Enabled = false;
            txtcompany.Enabled = false;
            txtcgst.Enabled = false;
            txtsgst.Enabled = false;
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
            txtproductname.Enabled = true;
            txtdesc.Enabled = true;
            txtqty.Enabled = true;
            txtsellprice.Enabled = true;
            txtcompany.Enabled = true;
            txtcgst.Enabled = true;
            txtsgst.Enabled = true;
        }

        public void clearerrmsg()
        {
           
            lblcompany.Text = "";
            lbldesc.Text = "";
            lblproname.Text = "";
            lblqty.Text = "";
            lblsellprice.Text = "";
            
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
            txtid.Text = "P" + auto.ToString();
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

                dataGridView1.Enabled = false;
                save = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sqlq = "";

            //code for validating form.
            if (txtproductname.Text != "" && txtdesc.Text != "" && txtqty.Text != "" && txtsellprice.Text != "" && txtcompany.Text != "" && txtcgst.Text != "" && txtsgst.Text != "" && lblproname.Text == "" && lbldesc.Text == "" && lblqty.Text == "" && lblsellprice.Text == "" && lblcompany.Text == "")
            {
                //code for new/update records
                cs.ec();
                if (save == true)
                {
                    //code for new member
                    sqlq = "insert into Stock values(" + auto + ",'" + txtid.Text + "','" + txtproductname.Text + "','" + txtdesc.Text + "'," + txtqty.Text + ",'" + txtsellprice.Text + "','" + txtcompany.Text + "','" + txtcgst.Text + "','" + txtsgst.Text + "','"+ txtigst.Text +"')";
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
                    sqlq = "Update Stock set PName='" + txtproductname.Text + "',Description='" + txtdesc.Text + "',Quantity='" + txtqty.Text + "',Price='" + txtsellprice.Text + "',Company='" + txtcompany.Text + "',cgst='" + txtcgst.Text + "',sgst='"+ txtsgst.Text + "',igst='" + txtigst.Text + "' where PId='" + txtid.Text + "' ";
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
                txtproductname_Leave(sender, e);
                txtdesc_Leave(sender, e);
                txtqty_Leave(sender, e);
                txtsellprice_Leave(sender, e);
                txtcompany_Leave(sender, e);
                

                //code for focusing
                //code for focusing
                if (lblproname.Text != "")
                {
                    txtproductname.Focus();
                }
                else if (lbldesc.Text != "")
                {
                    txtdesc.Focus();
                }
                else if (lblqty.Text != "")
                {
                    txtqty.Focus();
                }
                else if (lblsellprice.Text != "")
                {
                    txtsellprice.Focus();
                }
                else if (lblcompany.Text != "")
                {
                    txtcompany.Focus();
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
                    String sqlq = "Delete from Stock where PId= '" + txtid.Text + "' ";
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

        private void txtproductname_Leave(object sender, EventArgs e)
        {
            if (txtproductname.Text == "")
            {
                lblproname.Text = "Enter Product Name.";
            }
            else
            {
                lblproname.Text = "";
            }
        }

        private void txtdesc_Leave(object sender, EventArgs e)
        {
            if (txtdesc.Text == "")
            {
                lbldesc.Text = "Enter Product Description.";
            }
            else
            {
                lbldesc.Text = "";
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);
        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            if (txtqty.Text == "")
            {
                lblqty.Text = "Enter Product Quantity.";
            }
            else
            {
                lblqty.Text = "";
            }
        }

        private void txtsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumbers(e);
        }

        private void txtsellprice_Leave(object sender, EventArgs e)
        {
            if (txtsellprice.Text == "")
            {
                lblsellprice.Text = "Enter Selling Price.";
            }
            else if (txtsellprice.Text == "0" || txtsellprice.Text == "00" || txtsellprice.Text == "000" || txtsellprice.Text == "0000" || txtsellprice.Text == "00000")
            {
                lblsellprice.Text = "Selling Price can't be 0.";
            }
            else
            {
                lblsellprice.Text = "";
            }
        }

        private void txtcompany_Leave(object sender, EventArgs e)
        {
            if (txtcompany.Text == "")
            {
                lblcompany.Text = "Enter Company name.";
            }
            else
            {
                lblcompany.Text = "";
            }

        }
        
        
    }
}
