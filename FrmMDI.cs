using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FrmMDI : Form
    {
        public string username, usermode, useremail, userlastlogin;

        private void manageRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeRecords fc = new FrmEmployeeRecords();
            fc.Show();
        }

        private void manageRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSupplierRecords fc = new FrmSupplierRecords();
            fc.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurchase fc = new FrmPurchase();
            fc.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock fc = new FrmStock();
            fc.Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSignUp fc = new FrmSignUp();
            fc.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword fc = new FrmChangePassword();
            fc.Show();
        }

        private void removeAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeactivateAccount fc = new FrmDeactivateAccount();
            fc.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignIn fs = new frmSignIn();
            fs.Show();
            this.Hide();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerRecords fc = new FrmCustomerRecords();
            fc.Show();
        }

        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            lblname.Text = username;
            lblmode.Text = usermode;
            lbllastlogin.Text = userlastlogin;
            lblemail.Text = useremail;
        }
    }
}
