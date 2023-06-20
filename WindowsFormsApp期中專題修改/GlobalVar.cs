using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp期中專題修改
{
    internal class GlobalVar
    {
        public static string selectedTime;
        public static bool isLogin = false;
        public static int 權限 = 0;//一般會員:10000以上，特殊會員:5000~9999，店員1000~4999，店長:100-999，系統管理員(sys):10-99
        public static string 使用者名稱 = "";
    }
}
