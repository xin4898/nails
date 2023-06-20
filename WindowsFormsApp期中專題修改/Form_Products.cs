using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Design;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp期中專題修改
{

    public partial class Form_Products : Form
    {
        SqlConnectionStringBuilder scsb=new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();



        Form_CustomerBooking form = (Form_CustomerBooking)Application.OpenForms["Form_CustomerBooking"];
        int selectedID = Form_CustomerBooking.SelectedID;
        string customerName = Form_CustomerBooking.CustomerName;
        string customerPhone = Form_CustomerBooking.CustomerPhone;
      
        
        public Form_Products()
        {
            InitializeComponent();
        }
        
      

        private void Form_Products_Load(object sender, EventArgs e)
        {
            
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mymidtermdb";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            SqlConnection con=new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM Products where type='卸甲';";
            SqlCommand cmd = new SqlCommand(strSQL, con);          
       
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                string ProductName = reader["ProductName"].ToString();
               
                comboClean.Items.Add(ProductName);           
            }                                    
            reader.Close();

            string strSQL1 = "SELECT * FROM Products where Type='美甲';";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string ProductName = reader1["ProductName"].ToString();
                comboNail.Items.Add(ProductName);
            }
            reader1.Close();

            string strSQL2 = "SELECT * FROM Products where Type='裝飾';";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string ProductName = reader2["ProductName"].ToString();
                comboAccOne.Items.Add(ProductName);
            }
            reader2.Close();

            string strSQL3 = "SELECT * FROM Products where Type='裝飾';";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string ProductName = reader3["ProductName"].ToString();
                comboAccTwo.Items.Add(ProductName);
            }
            reader3.Close();

            string strSQL4 = "SELECT * FROM Products where Type='裝飾';";
            SqlCommand cmd4 = new SqlCommand(strSQL4, con);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                string ProductName = reader4["ProductName"].ToString();
                comboAccThree.Items.Add(ProductName);
            }
           reader4.Close();
            con.Close();
                txtName.Text = customerName;
                txtPhone.Text = customerPhone;
            

            //string strSQL5 = "SELECT * FROM Reserve WHERE ReserveID=@SelectedID;";
            //SqlCommand cmd5 = new SqlCommand(strSQL5, con);
            //cmd.Parameters.AddWithValue("@SelectedID", selectedID);
            //SqlDataReader reader5 = cmd.ExecuteReader();
            //if (reader5.Read() == true)
            //{
            //    string CustomerName = reader5["CustomerName"].ToString();
            //    string CustomerPhone= reader5["CustomerPhone"].ToString();
            //    txt顧客姓名.Text = CustomerName ;
            //    txt顧客電話.Text = CustomerPhone;
            //}
            //reader5.Close();
            //con.Close();
        }


        private decimal totalPrice = 0;


        private void combo卸甲_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClean.SelectedItem != null)
            {

                int selectID = -1;
                string selectedProductName = comboClean.SelectedItem.ToString();

                // 找到選取的產品的 ProductID
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "SELECT ProductID FROM Products WHERE ProductName=@ProductName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductName", selectedProductName);
                    selectID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                
                // 使用 ProductID 查詢 Price，並將其顯示在 label 卸甲價格 上
                if (selectID >= 0)
                {
                    using (SqlConnection con = new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "SELECT Price FROM Products WHERE ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductID", selectID);
                        decimal selectedPrice = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblCleanPrice.Text = selectedPrice.ToString("C");

                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");
                        con.Close();
                    }
                }
            }
        }

        private void combo凝膠_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNail.SelectedItem != null)
            {
                int selectedID = -1;
                string selectedProductName = comboNail.SelectedItem.ToString();

                //選取ProductID
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select ProductID from Products where ProductName=@ProductName;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductName", selectedProductName);
                    selectedID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

                if (selectedID>=0)
                {
                    //選取Price
                    using (SqlConnection con=new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "select Price from Products where ProductID=@ProductID";
                        SqlCommand cmd=new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductID", selectedID);                       
                        decimal selectedPrice = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblNailPrice.Text = selectedPrice.ToString("C");  
                        
                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");
                        con.Close();
                    }
            }   }    
        }

        private void combo飾品_SelectedIndexChanged(object sender, EventArgs e)
        {        
                int selectID = -1;
                string selectProductName = comboAccOne.SelectedItem.ToString();

                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select ProductID from Products where ProductName=@ProductName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductName", selectProductName);
                    selectID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

                if (selectID >= 0)
                {
                    using (SqlConnection con = new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "select Price from Products where ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductID", selectID);
                        int price = Convert.ToInt32(cmd.ExecuteScalar());
                        int _小計 = price * (int)numud數量.Value;
                        decimal selectedPrice = Convert.ToDecimal(_小計);
                        lblAccOnePrice.Text = selectedPrice.ToString("C");
                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");
                        con.Close();
                    }
                }                                                       
        }
        private void combo飾品1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectID = -1;
            string selectProductName = comboAccTwo.SelectedItem.ToString();

            using (SqlConnection con = new SqlConnection(strDBConnectionString))
            {
                con.Open();
                string strSQL = "select ProductID from Products where ProductName=@ProductName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ProductName", selectProductName);
                selectID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            if (selectID >= 0)
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select Price from Products where ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductID", selectID);
                    int price = Convert.ToInt32(cmd.ExecuteScalar());
                    int _小計 = price * (int)numud數量1.Value;
                    decimal selectedPrice = Convert.ToDecimal(_小計);
                    lblAccTwoPrice.Text = selectedPrice.ToString("C");
                    totalPrice = GetTotalPrice();
                    lblTotal.Text = totalPrice.ToString("C");
                    con.Close();
                }
            }
        }

        private void combo飾品2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectID = -1;
            string selectProductName = comboAccThree.SelectedItem.ToString();

            using (SqlConnection con = new SqlConnection(strDBConnectionString))
            {
                con.Open();
                string strSQL = "select ProductID from Products where ProductName=@ProductName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ProductName", selectProductName);
                selectID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            if (selectID >= 0)
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select Price from Products where ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductID", selectID);
                    int price = Convert.ToInt32(cmd.ExecuteScalar());
                    int _小計 = price * (int)numud數量2.Value;
                    decimal selectedPrice = Convert.ToDecimal(_小計);
                    lblAccThreePrice.Text = selectedPrice.ToString("C");
                    totalPrice = GetTotalPrice();
                    lblTotal.Text = totalPrice.ToString("C");
                    con.Close();
                }
            }
        }
        decimal GetTotalPrice()
        {
            decimal.TryParse(lblCleanPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal 卸甲價格Decimal);
            decimal.TryParse(lblNailPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal 凝膠價格Decimal);
            decimal.TryParse(lblAccOnePrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal 飾品價格Decimal);
            decimal.TryParse(lblAccTwoPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal 飾品價格1Decimal);
            decimal.TryParse(lblAccThreePrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal 飾品價格2Decimal);
            decimal totalPrice = 0;

            if (卸甲價格Decimal > 0)
            {
                totalPrice += 卸甲價格Decimal;
            }

            if (凝膠價格Decimal > 0)
            {
                totalPrice += 凝膠價格Decimal;
            }

            if (飾品價格Decimal > 0)
            {
                totalPrice += 飾品價格Decimal;
            }

            if (飾品價格1Decimal > 0)
            {
                totalPrice += 飾品價格1Decimal;
            }

            if (飾品價格2Decimal > 0)
            {
                totalPrice += 飾品價格2Decimal;
            }

            return totalPrice;
        }


        private void numud數量_ValueChanged(object sender, EventArgs e)
        {
            //if (combo卸甲.SelectedIndex == -1)
            //{
            //    MessageBox.Show("請先選擇裝飾品");
            //    numud數量.Value = 0;    
            //}
            
            try
            {
                if (comboClean.SelectedItem == null) MessageBox.Show("請先選擇卸甲及美甲方式");
                int selectID = -1;
                    string selectProductName = comboAccOne.SelectedItem.ToString();

                    using (SqlConnection con = new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "select ProductID from Products where ProductName=@ProductName";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductName", selectProductName);
                        selectID = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }

                    if (selectID >= 0)
                    {
                    using (SqlConnection con = new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "select Price from Products where ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductID", selectID);
                        int price = Convert.ToInt32(cmd.ExecuteScalar());
                        int _小計 = price * (int)numud數量.Value;
                        decimal selectedPrice = Convert.ToDecimal(_小計);
                        lblAccOnePrice.Text = selectedPrice.ToString("C");
                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");

                        //}
                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");
                        con.Close();
                    }
                    }                
            }
            catch 
            {                
                //MessageBox.Show("請先選擇裝飾品");
               // numud數量.Value = 0;
                //return;             
            }
        }

        private void numud數量1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectID = -1;
                string selectProductName = comboAccTwo.SelectedItem.ToString();

                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select ProductID from Products where ProductName=@ProductName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductName", selectProductName);
                    selectID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

                if (selectID >= 0)
                {
                    using (SqlConnection con = new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "select Price from Products where ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductID", selectID);
                        int price = Convert.ToInt32(cmd.ExecuteScalar());
                        int _小計 = price * (int)numud數量1.Value;
                        decimal selectedPrice = Convert.ToDecimal(_小計);
                        lblAccTwoPrice.Text = selectedPrice.ToString("C");
                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("請先選擇裝飾品");
                numud數量1.Value = 0;
                return;
            }
        }

        private void numud數量2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectID = -1;
                string selectProductName = comboAccThree.SelectedItem.ToString();

                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select ProductID from Products where ProductName=@ProductName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductName", selectProductName);
                    selectID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

                if (selectID >= 0)
                {
                    using (SqlConnection con = new SqlConnection(strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "select Price from Products where ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@ProductID", selectID);
                        int price = Convert.ToInt32(cmd.ExecuteScalar());
                        int _小計 = price * (int)numud數量2.Value;
                        decimal selectedPrice = Convert.ToDecimal(_小計);
                        lblAccThreePrice.Text = selectedPrice.ToString("C");
                        totalPrice = GetTotalPrice();
                        lblTotal.Text = totalPrice.ToString("C");
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("請先選擇裝飾品");
                numud數量2.Value =0 ;
                return;
            }
        }

        void ClearAll()
        {
            txtName.Clear();
            txtPhone.Clear();
            comboClean.Text="無卸甲" ;
            comboNail.Text = "無光療美甲";
            comboAccOne.Text = "";
            comboAccTwo.Text = "";
            comboAccThree.Text = "";
            numud數量.Value = 0 ;
            numud數量1.Value = 0 ;
            numud數量2 .Value = 0 ;
            lblCleanPrice.Text = "NT$0";
            lblNailPrice.Text = "NT$0";
            lblAccOnePrice.Text = "NT$0";
            lblAccTwoPrice.Text = "NT$0";
            lblAccThreePrice.Text = "NT$0";
            lblTotal.Text= "NT$0";
        }

        private void txt顧客姓名_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "";
        }

        private void txt顧客電話_MouseClick(object sender, MouseEventArgs e)
        {
            txtPhone.Text = "";       
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            /*if (txt顧客姓名.Text!=""&&txt顧客電話.Text!="")
            {
                int num = (int)numud數量.Value;
                DialogResult R = MessageBox.Show($"您確定要送出訂單:\n卸甲:{combo卸甲.Text}\n美甲樣式:{combo凝膠.Text}\n飾品:{combo飾品.Text}{num}個", "送出訂單確定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "insert into Orders values (@NewCustomerName,@NewCustomerPhone,@NewOrderDate,@NewProductID,@NewTotalPrice);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewCustomerName", txt顧客姓名.Text);
                    cmd.Parameters.AddWithValue("@NewCustomerPhone", txt顧客電話.Text);
                    cmd.Parameters.AddWithValue("@NewOrderDate", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@NewProductID", );
                    //cmd.Parameters.AddWithValue("@NewCustomerName", txt顧客姓名.Text);

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("請輸入顧客姓名及電話");
            }*/
            /*int num = (int)numud數量.Value;
            DialogResult R = MessageBox.Show($"您確定要送出訂單:\n卸甲:{combo卸甲.Text}\n美甲樣式:{combo凝膠.Text}\n飾品:{combo飾品.Text}{num}個", "送出訂單確定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
            {
                // 取得選取商品的 ProductID
                string[] selectedProducts = { combo卸甲.Text, combo凝膠.Text, combo飾品.Text, combo飾品1.Text, combo飾品2.Text };
                List<int> productIDs = new List<int>();
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    foreach (string productName in selectedProducts)
                    {
                        string selectProductIDSql = "SELECT ProductID FROM Products WHERE ProductName = @ProductName;";
                        SqlCommand cmd = new SqlCommand(selectProductIDSql, con);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            // 未返回結果或出現錯誤
                        }
                        else
                        {
                            int productID = (int)cmd.ExecuteScalar();
                            productIDs.Add(productID);
                        }
                       
                    }
                }

                // 將 productIDs 轉換為字串，以儲存到 Orders 資料表中
                string productIDsString = string.Join(",", productIDs);

                // 新增訂單到資料庫
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    decimal totalPrice = decimal.Parse(lbl小計.Text);                   
                    string insertOrderSql = "INSERT INTO Orders (CustomerName, CustomerPhone, OrderDate, ProductID, TotalPrice) VALUES (@CustomerName, @CustomerPhone, @OrderDate, @ProductID, @TotalPrice);";
                    SqlCommand cmd = new SqlCommand(insertOrderSql, con);
                    cmd.Parameters.AddWithValue("@CustomerName", txt顧客姓名.Text);
                    cmd.Parameters.AddWithValue("@CustomerPhone", txt顧客電話.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ProductID", productIDsString);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("請輸入顧客姓名及電話");
            }*/


            //int num = (int)numud數量.Value;
            //int num1 = (int)numud數量1.Value;
            //int num2 = (int)numud數量2.Value;

            //DialogResult R = MessageBox.Show($"您確定要送出訂單:\n卸甲:{combo卸甲.Text}\n美甲樣式:{combo凝膠.Text}\n飾品:{combo飾品.Text}{num}個\n飾品:{combo飾品1.Text}{num1}個\n飾品:{combo飾品2.Text}{num2}個", "送出訂單確定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (R == DialogResult.Yes)
            //{
            //    using (SqlConnection con = new SqlConnection(strDBConnectionString))
            //    {
            //        con.Open();

            //        // 取得選擇的 product IDs
            //        string[] productNames = { combo卸甲.Text, combo凝膠.Text, combo飾品.Text, combo飾品1.Text, combo飾品2.Text };
            //        List<int> productIDs = new List<int>();
            //        foreach (string productName in productNames)
            //        {
            //            if (string.IsNullOrWhiteSpace(productName))
            //            {
            //                productIDs.Add(0);
            //                continue;
            //            }

            //            string sqlQuery = "SELECT ProductID FROM Products WHERE ProductName = @ProductName;";
            //            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //            cmd.Parameters.AddWithValue("@ProductName", productName);
            //            int? productID = cmd.ExecuteScalar() as int?;


            //            if (productID != null)

            //            {
            //                productIDs.Add(productID.Value);
            //            }
            //            else
            //            {
            //                MessageBox.Show($"找不到產品 {productName} 的 ID，訂單將不會被儲存。", "找不到產品", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;
            //            }
            //        }



            //        // 插入訂單資訊
            //        string strSQL = "INSERT INTO Orders (CustomerName, CustomerPhone, OrderDate, ProductID, TotalPrice) VALUES (@CustomerName, @CustomerPhone, @OrderDate, @ProductID, @TotalPrice);";
            //        SqlCommand cmd2 = new SqlCommand(strSQL, con);
            //        cmd2.Parameters.AddWithValue("@CustomerName", txt顧客姓名.Text);
            //        cmd2.Parameters.AddWithValue("@CustomerPhone", txt顧客電話.Text);
            //        cmd2.Parameters.AddWithValue("@OrderDate", DateTime.Now);                 
            //        cmd2.Parameters.AddWithValue("@ProductID", productIDs[0]);
            //        decimal totalPrice = decimal.Parse(lbl小計.Text.Replace("NT$", ""));
            //        cmd2.Parameters.AddWithValue("@TotalPrice", totalPrice);
            //        cmd2.ExecuteNonQuery();

            //        MessageBox.Show("訂單已儲存。", "訂單儲存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            // 取得選擇的 product IDs 和 product 數量
            string[] productNames = { comboClean.Text, comboNail.Text, comboAccOne.Text, comboAccTwo.Text, comboAccThree.Text };
            //decimal 卸甲價格 = decimal.Parse(lbl卸甲價格.Text.Replace("NT$", ""));
            //decimal 凝膠價格 = decimal.Parse(lbl凝膠價格.Text.Replace("NT$", ""));
            //decimal 飾品價格 = decimal.Parse(lbl飾品價格.Text.Replace("NT$", ""));
            //decimal 飾品價格1 = decimal.Parse(lbl飾品價格1.Text.Replace("NT$", ""));
            //decimal 飾品價格2 = decimal.Parse(lbl飾品價格2.Text.Replace("NT$", ""));
            //decimal[] price= { 卸甲價格, 凝膠價格, 飾品價格, 飾品價格1, 飾品價格2};
            int[] productNums = { 1, 1, (int)numud數量.Value, (int)numud數量1.Value, (int)numud數量2.Value };
            List<int> productIDs = new List<int>();
            for (int i = 0; i < productNames.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(productNames[i]))
                {
                    continue;
                }

                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();

                    string sqlQuery = "SELECT ProductID FROM Products WHERE ProductName = @ProductName;";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@ProductName", productNames[i]);
                    //cmd.Parameters.AddWithValue("@Price", price[i]);
                    int? productID = cmd.ExecuteScalar() as int?;
                    


                    if (productID != null && txtName.Text != "顧客姓名" && txtPhone.Text != "顧客電話")
                    {
                        for (int j = 0; j < productNums[i]; j++)
                        {
                            // 插入訂單資訊
                            string strSQL = "INSERT INTO Orders (CustomerName, CustomerPhone, OrderDate, ProductID, TotalPrice) VALUES (@CustomerName, @CustomerPhone, @OrderDate, @ProductID, @TotalPrice);";
                            SqlCommand cmd2 = new SqlCommand(strSQL, con);
                            cmd2.Parameters.AddWithValue("@CustomerName", txtName.Text);
                            cmd2.Parameters.AddWithValue("@CustomerPhone", txtPhone.Text);
                            cmd2.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                            cmd2.Parameters.AddWithValue("@ProductID", productID.Value);
                            decimal totalPrice = decimal.Parse(lblTotal.Text.Replace("NT$", ""));
                            cmd2.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"請輸入顧客資訊。", "無顧客資訊", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    con.Close();
                }
            }

            MessageBox.Show("訂單已儲存。", "訂單儲存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
        }
    }
    
}
