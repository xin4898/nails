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
    public partial class Form_OrderMan : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        //public static int SelectedID; 
        public static string SelectedID;
        public static string CustomerName;
        public static string CustomerPhone;
        public static DateTime OrderDate;       
        public Form_OrderMan()
        {
            InitializeComponent();
            
        }

        private void Form_OrderMan_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymidtermdb";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            //DateTime now = DateTime.Now;
            //Calendar施作時段.MinDate = now.AddYears(-1);
            //DateTime selectionStart = now.AddYears(-1);
            //DateTime selectionEnd = now.AddYears(1);
            //Calendar施作時段.SetSelectionRange(selectionStart, selectionEnd);
            ShowOrderInfo();
            
        }

        void ShowOrderInfo()
        {
           
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL =/*"SELECT Orders.OrderID,Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), STRING_AGG(Products.ProductName,',\n') AS ProductNames, Orders.TotalPrice FROM Orders JOIN Products ON Orders.ProductID = Products.ProductID GROUP BY Orders.OrderID,Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), Orders.TotalPrice Order BY\r\n Orders.OrderID;";*/
                "SELECT STRING_AGG(Orders.OrderID,'\n') AS OrderID,Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), STRING_AGG(Products.ProductName,'\n') AS ProductNames, Orders.TotalPrice FROM Orders JOIN Products ON Orders.ProductID = Products.ProductID GROUP BY Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), Orders.TotalPrice order by STRING_AGG(Orders.OrderID,'\n');";             
            dgvOrderInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // 啟用自動換行
            dgvOrderInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // 調整所有儲存格的行高
            dgvOrderInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvOrderInfo.DataSource = dt;
                dgvOrderInfo.Columns[5].DefaultCellStyle.Format = "NT$0";
            }
            dgvOrderInfo.Columns[0].HeaderText = "單號";
            dgvOrderInfo.Columns[1].HeaderText = "姓名";
            dgvOrderInfo.Columns[2].HeaderText = "電話";
            dgvOrderInfo.Columns[3].HeaderText = "日期";
            dgvOrderInfo.Columns[4].HeaderText = "施作項目";
            dgvOrderInfo.Columns[5].HeaderText = "總價";


            reader.Close();
            con.Close();
        }

        void ClearAll()
        {
            txtboxName.Text = "";
            txtboxPhone.Text = "";
            
        }
            
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime selectDate = CalendarDate.SelectionRange.End;
            string strDate = selectDate.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = /*"SELECT Orders.OrderID,Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), \r\n       STRING_AGG(Products.ProductName,',\n') AS ProductNames, Orders.TotalPrice \r\nFROM Orders \r\nJOIN Products ON Orders.ProductID = Products.ProductID \r\nWHERE Orders.CustomerName like @SearchName and Orders.CustomerPhone like @SearchPhone or CONVERT(date, Orders.OrderDate) like @SearchDate \r\nGROUP BY Orders.OrderID,Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), Orders.TotalPrice;";*/

                "SELECT STRING_AGG(Orders.OrderID,'\n') AS OrderID,Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), \r\n       STRING_AGG(Products.ProductName,',\n') AS ProductNames, Orders.TotalPrice \r\nFROM Orders \r\nJOIN Products ON Orders.ProductID = Products.ProductID \r\nWHERE Orders.CustomerName like @SearchName and Orders.CustomerPhone like @SearchPhone or CONVERT(date, Orders.OrderDate) like @SearchDate \r\nGROUP BY Orders.CustomerName, Orders.CustomerPhone, CONVERT(date, Orders.OrderDate), Orders.TotalPrice;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"%{txtboxName.Text}%");
            cmd.Parameters.AddWithValue("@SearchPhone", $"%{txtboxPhone.Text}%");
            cmd.Parameters.AddWithValue("@SearchDate", selectDate);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvOrderInfo.DataSource = dt;
            Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("查無此人");
            }

            con.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowOrderInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text != "" || txtboxPhone.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = /*"update Orders set CustomerName=@NewName,CustomerPhone=@NewPhone where OrderID=@selectID;";*/
                    "update Orders set CustomerName=@NewName,CustomerPhone=@NewPhone where CustomerName=@SearchName AND CustomerPhone=@SearchPhone;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //cmd.Parameters.AddWithValue("@selectID", selectID);
                cmd.Parameters.AddWithValue("@SearchName", CustomerName);
                cmd.Parameters.AddWithValue("@SearchPhone", CustomerPhone);
                cmd.Parameters.AddWithValue("@NewName", txtboxName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtboxPhone.Text);

                int rows = cmd.ExecuteNonQuery();

                con.Close();
                ClearAll();
                MessageBox.Show($"資料修改完成，共{rows}筆");
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*int selectID = 0;
                        int.TryParse(lblID.Text, out selectID);
                        SqlConnection con=new SqlConnection(strDBConnectionString);
                        con.Open();
                        string strSQL = "delete from Orders  where STRING_AGG(Orders.OrderID,'\n')=@selectID;";
                        SqlCommand cmd=new SqlCommand( strSQL, con);
                        cmd.Parameters.AddWithValue("@selectID",selectID);

                        int rows = cmd.ExecuteNonQuery();            
                        con.Close();
                        清空欄位();
                        MessageBox.Show($"預約刪除完成，共{rows}筆");*/



            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "delete from Orders where CustomerName=@SearchName AND CustomerPhone=@SearchPhone;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", txtboxName.Text);
            cmd.Parameters.AddWithValue("@SearchPhone", txtboxPhone.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            ClearAll();
            MessageBox.Show($"預約刪除完成，共{rows}筆");
            con.Close();
        }

        private void dgvOrderInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            /*string strSelectID = dgv訂單資料.Rows[e.RowIndex].Cells[0].Value.ToString();
            int selectID = 0;
            Int32.TryParse(strSelectID, out selectID);*/
            //string strSelectID = dgv訂單資料.Rows[e.RowIndex].Cells[1+2].Value.ToString();


            //SqlConnection con = new SqlConnection(strDBConnectionString);
            //con.Open();
            //string strSQL = "SELECT \r\n    STRING_AGG(Orders.OrderID,'\n') as OrderID,\r\n    Orders.CustomerName, \r\n    Orders.CustomerPhone, \r\n    CONVERT(date, Orders.OrderDate), \r\n    STRING_AGG(Products.ProductName, ',\\n') AS ProductNames, \r\n    Orders.TotalPrice \r\nFROM \r\n    Orders \r\n    JOIN Products ON Orders.ProductID = Products.ProductID \r\nWHERE \r\n    Orders.CustomerName and Orders.CustomerName= @SearchID \r\nGROUP BY \r\n    Orders.OrderID,\r\n    Orders.CustomerName, \r\n    Orders.CustomerPhone, \r\n    CONVERT(date, Orders.OrderDate), \r\n    Orders.TotalPrice\r\nOrder BY\r\n    Orders.OrderID;";
            /*"SELECT \r\n    Orders.OrderID,\r\n    Orders.CustomerName, \r\n    Orders.CustomerPhone, \r\n    CONVERT(date, Orders.OrderDate), \r\n    STRING_AGG(Products.ProductName, ',\\n') AS ProductNames, \r\n    Orders.TotalPrice \r\nFROM \r\n    Orders \r\n    JOIN Products ON Orders.ProductID = Products.ProductID \r\nWHERE \r\n   Orders.OrderID = @SearchID \r\nGROUP BY \r\n    Orders.OrderID,\r\n    Orders.CustomerName, \r\n    Orders.CustomerPhone, \r\n    CONVERT(date, Orders.OrderDate), \r\n    Orders.TotalPrice\r\nOrder BY\r\n    Orders.OrderID;"*/
            /* SqlCommand cmd = new SqlCommand(strSQL, con);
             cmd.Parameters.AddWithValue("@SearchID", selectID);
             SqlDataReader reader = cmd.ExecuteReader();
             if (reader.Read() == true)
             {
                 SelectedID = selectID;
                 lblID.Text = SelectedID.ToString();                 
                 CustomerName = reader["CustomerName"].ToString();
                 CustomerPhone = reader["CustomerPhone"].ToString();
                 //OrderDate = DateTime.Parse(reader["OrderDate"].ToString());
                 txtbox預約人姓名.Text = CustomerName;
                 txtbox預約人電話.Text = CustomerPhone;
                 //Calendar日期.SetDate(OrderDate);

             }
         */
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@SearchID", strSelectID);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read() == true)
            //    {
            //        SelectedID = strSelectID;
            //        lblID.Text = SelectedID.ToString();
            //        CustomerName = reader["CustomerName"].ToString();
            //        CustomerPhone = reader["CustomerPhone"].ToString();
            //        //OrderDate = DateTime.Parse(reader["OrderDate"].ToString());
            //        txtbox預約人姓名.Text = CustomerName;
            //        txtbox預約人電話.Text = CustomerPhone;
            //        //Calendar日期.SetDate(OrderDate);
            //    }
            //}
            //catch
            //{

            //}

            try
            {
                string customerName = dgvOrderInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                string customerPhone = dgvOrderInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                string strSelectID = customerName + customerPhone;

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT \r\n    STRING_AGG(Orders.OrderID,'\n') as OrderID,\r\n    Orders.CustomerName, \r\n    Orders.CustomerPhone, \r\n    CONVERT(date, Orders.OrderDate), \r\n    STRING_AGG(Products.ProductName, ',\\n') AS ProductNames, \r\n    Orders.TotalPrice \r\nFROM \r\n    Orders \r\n    JOIN Products ON Orders.ProductID = Products.ProductID \r\nWHERE (Orders.CustomerName = @CustomerName) AND (Orders.CustomerPhone = @CustomerPhone) \r\nGROUP BY \r\n    Orders.OrderID,\r\n    Orders.CustomerName, \r\n    Orders.CustomerPhone, \r\n    CONVERT(date, Orders.OrderDate), \r\n    Orders.TotalPrice\r\nORDER BY\r\n    Orders.OrderID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {

                    CustomerName = reader["CustomerName"].ToString();
                    CustomerPhone = reader["CustomerPhone"].ToString();
                    //OrderDate = DateTime.Parse(reader["OrderDate"].ToString());
                    txtboxName.Text = CustomerName;
                    txtboxPhone.Text = CustomerPhone;
                    //Calendar日期.SetDate(OrderDate);
                }
                con.Close();
            }
            catch
            {

            }
        }
    }
}
