using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp期中專題修改
{
    public partial class Form1 : Form
    {

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; 
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (GlobalVar.isLogin == false)
            {
                btnOrders.Enabled = false;
                btnOrderMan.Enabled = false;
                btnReserve.Enabled = false;               
            }
            else
            {
                btnOrders.Enabled = true;
                btnOrderMan.Enabled = true;
                btnReserve.Enabled = true;
                btnLogin.Enabled = false;                
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new Form_logIn());
            label_Forms.Text = "使用者登入";
            btnLogout.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_logIn());
            label_Forms.Text = "使用者登入";
        }                        
        void Logout()
        {
            GlobalVar.isLogin = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
            MessageBox.Show("登出成功");
            btnOrders.Enabled = false;
            btnOrderMan.Enabled = false;
            btnReserve.Enabled = false;          
            openChildForm(new Form_logIn());
            label_Forms.Text = "使用者登入";
            btnLogout.Visible = false;
            btnLogin.Enabled = true;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_CustomerBooking());
            label_Forms.Text = "顧客預約";
            btnLogout.Visible = true;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Products());
            label_Forms.Text = "施作項目";
        }

        private void btnOrderMan_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_OrderMan());
            label_Forms.Text = "訂單管理";
        }
    }
}
