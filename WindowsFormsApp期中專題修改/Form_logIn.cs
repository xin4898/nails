using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp期中專題修改
{
    public partial class Form_logIn : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public Form_logIn()
        {
            InitializeComponent();
        }

        private void form_logIn_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymidtermdb";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            if (txtboxAccount.Text != "" && txtboxPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from Login where Account=@account and Password=@password;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", txtboxAccount.Text);
                cmd.Parameters.AddWithValue("@password", txtboxPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    GlobalVar.isLogin = true;
                }
                else
                {
                    GlobalVar.isLogin = false;
                }

                if (GlobalVar.isLogin == true)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    form1.openChildForm(new Form_CustomerBooking());
                    form1.label_Forms.Text = "顧客預約";
                    form1.btnLogout.Visible = true;

                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼。", "訂單儲存", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
