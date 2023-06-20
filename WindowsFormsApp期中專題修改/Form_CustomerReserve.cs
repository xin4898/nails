using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp期中專題修改
{
    public partial class Form_CustomerBooking : Form
    {
        //private Form1 parentForm;
        //public void Form_CustomerReserve(Form1 parentForm)
        //{
        //    InitializeComponent();
        //    this.parentForm = parentForm;
        //}

        List<int> searchIDs = new List<int>();
        DataTable dt = new DataTable();
        public static int SelectedID;
        public static string CustomerName;
        public static string CustomerPhone;
        public static DateTime ReserveDate;
        public static string ReserveTime;

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
       
        



        public Form_CustomerBooking()
        {
            InitializeComponent();
        }

        private void Form_CustomerBooking_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymidtermdb";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            DateTime now = DateTime.Now;           
            DateTime selectionStart = now.AddDays(-300);
            DateTime selectionEnd = now.AddYears(1);
            CalendarDate.SetSelectionRange(selectionStart, selectionEnd);
            dgvReserveInfo.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.AllCells;
            showReserveInfo();
            
        }

        void showReserveInfo()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select*from Reserve";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvReserveInfo.DataSource = dt;
            }
            dgvReserveInfo.Columns[0].HeaderText = "預約編號";
            dgvReserveInfo.Columns[1].HeaderText = "姓名";
            dgvReserveInfo.Columns[2].HeaderText = "電話";
            dgvReserveInfo.Columns[3].HeaderText = "日期";
            dgvReserveInfo.Columns[4].HeaderText = "時間";
            reader.Close();
            con.Close();
        }

        void ClearAll()
        {
            txtboxName.Clear();
            txtboxPhone.Clear();
            DateTime now = DateTime.Now;
            CalendarDate.MinDate = now;
            DateTime selectionStart = now.AddDays(1);
            DateTime selectionEnd = now.AddYears(1);
            CalendarDate.SetSelectionRange(selectionStart, selectionEnd);
            GlobalVar.selectedTime = "";
            recolor();
        }       

        void recolor()
        {
            btn9.BackColor = Color.LightSteelBlue;
            btn10.BackColor = Color.LightSteelBlue;
            btn11.BackColor = Color.LightSteelBlue;
            btn14.BackColor = Color.LightSteelBlue;
            btn15.BackColor = Color.LightSteelBlue;
            btn16.BackColor = Color.LightSteelBlue;
            btn18.BackColor = Color.LightSteelBlue;
            btn19.BackColor = Color.LightSteelBlue;
            btn20.BackColor = Color.LightSteelBlue;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "9:00";
            btn9.BackColor = Color.CornflowerBlue;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "10:00";
            btn10.BackColor = Color.CornflowerBlue;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "11:00";
            btn11.BackColor = Color.CornflowerBlue;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "14:00";
            btn14.BackColor = Color.CornflowerBlue;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "15:00";
            btn15.BackColor = Color.CornflowerBlue;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "16:00";
            btn16.BackColor = Color.CornflowerBlue;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "18:00";
            btn18.BackColor = Color.CornflowerBlue;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "19:00";
            btn19.BackColor = Color.CornflowerBlue;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            recolor();
            GlobalVar.selectedTime = "20:00";
            btn20.BackColor = Color.CornflowerBlue;
        }

        
        //private string strSelectID;      


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = CalendarDate.SelectionRange.End;
                if (txtboxName.Text != "" && txtboxPhone.Text != "" && selectedDate > DateTime.Now && GlobalVar.selectedTime != "")
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "insert into Reserve values(@NewName,@NewPhone,@NewDate,@NewTime);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@NewName", txtboxName.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txtboxPhone.Text);
                    cmd.Parameters.AddWithValue("@NewDate", selectedDate);
                    cmd.Parameters.AddWithValue("@NewTime", GlobalVar.selectedTime.ToString());
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    ClearAll();
                    MessageBox.Show($"預約資料{rows}筆已新增完成!!");
                }
                else
                {
                    MessageBox.Show("輸入資訊不完整或有誤，請再次檢查!!");
                }
            }
            catch
            {
                MessageBox.Show("輸入資訊不完整或有誤，請再次檢查!!");
            }
        }

        private void dgvReserveInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strSelectID = dgvReserveInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select*from Reserve where ReserveID= @SearchID ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    SelectedID = selectID;
                    lblID.Text = SelectedID.ToString();
                    CustomerName = reader["CustomerName"].ToString();
                    CustomerPhone = reader["CustomerPhone"].ToString();
                    ReserveDate = DateTime.Parse(reader["ReserveDate"].ToString());
                    ReserveTime = reader["ReserveTime"].ToString();
                    txtboxName.Text = CustomerName;
                    txtboxPhone.Text = CustomerPhone;
                    CalendarDate.SetDate(ReserveDate);
                    GlobalVar.selectedTime = ReserveTime;
                    if (GlobalVar.selectedTime == "9:00")
                    {
                        recolor();
                        btn9.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "10:00")
                    {
                        recolor();
                        btn10.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "11:00")
                    {
                        recolor();
                        btn11.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "14:00")
                    {
                        recolor();
                        btn14.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "15:00")
                    {
                        recolor();
                        btn15.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "16:00")
                    {
                        recolor();
                        btn16.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "18:00")
                    {
                        recolor();
                        btn18.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "19:00")
                    {
                        recolor();
                        btn19.BackColor = Color.CornflowerBlue;
                    }
                    else if (GlobalVar.selectedTime == "20:00")
                    {
                        recolor();
                        btn20.BackColor = Color.CornflowerBlue;
                    }
                }
            }
            catch
            {

            }
            //if (e.RowIndex >= 0)
            //{
            //    string strSelectID = dgv預約資料.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    int selectID = 0;
            //    Int32.TryParse(strSelectID, out selectID);

            //    SqlConnection con = new SqlConnection(strDBConnectionString);
            //    con.Open();
            //    string strSQL = "select*from Reserve where ReserveID= @SearchID ;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@searchID", selectID);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read()==true)
            //    {                   
            //        SelectedID = selectID;
            //        CustomerName = reader["CustomerName"].ToString();
            //        CustomerPhone = reader["CustomerPhone"].ToString();                   
            //        Form1 form1 = (Form1)Application.OpenForms["Form1"];
            //        form1.openChildForm(new Form_Products());
            //        form1.label目前表單.Text = "施作項目";
            //        //Form_Products form_Products = new Form_Products();
            //        //form_Products.ShowDialog();

            //        //form_Products.SelectedID(selectID);
            //        //openChildForm(form_Products);
            //    }
            //}
        }
    

        private void dgvReserveInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectID = dgvReserveInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select*from Reserve where ReserveID= @SearchID ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    SelectedID = selectID;
                    lblID.Text = SelectedID.ToString();
                    CustomerName = reader["CustomerName"].ToString();
                    CustomerPhone = reader["CustomerPhone"].ToString();
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    form1.openChildForm(new Form_Products());
                    form1.label_Forms.Text = "施作項目";                    
                }
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = CalendarDate.SelectionRange.End;
            if (txtboxName.Text != "" || txtboxPhone.Text != "" || selectedDate != null)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select*from Reserve where CustomerName like @SearchName and CustomerPhone like @SearchPhone or ReserveDate=@SearchDate;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txtboxName.Text}%");//參數帶入法
                cmd.Parameters.AddWithValue("@SearchPhone", $"%{txtboxPhone.Text}%");//參數帶入法
                cmd.Parameters.AddWithValue("@SearchDate", selectedDate);
                //SqlDataReader reader = cmd.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReserveInfo.DataSource = dt;
                Console.WriteLine(dt.Rows.Count);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                //reader.Close();               
                con.Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            showReserveInfo();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectID = 0;
            Int32.TryParse(lblID.Text, out selectID);
            DateTime NewDate = CalendarDate.SelectionRange.End;

            if ((selectID > 0) && txtboxName.Text != "" && txtboxPhone.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update Reserve set CustomerName=@NewName,CustomerPhone=@NewPhone,ReserveDate=@NewDate,ReserveTime=@NewTime where ReserveID=@SelectID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SelectID", selectID);
                cmd.Parameters.AddWithValue("@NewName", txtboxName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtboxPhone.Text);
                cmd.Parameters.AddWithValue("@NewDate", NewDate);
                cmd.Parameters.AddWithValue("@NewTime", GlobalVar.selectedTime.ToString());

                int rows = cmd.ExecuteNonQuery();

                con.Close();
                ClearAll();
                MessageBox.Show($"資料修改完成，共{rows}筆");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectID = 0;
            Int32.TryParse(lblID.Text, out selectID);
            if (SelectedID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from Reserve where ReserveID=@DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", selectID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                ClearAll();
                MessageBox.Show($"預約刪除完成，共{rows}筆");
            }
        }
    }
}
