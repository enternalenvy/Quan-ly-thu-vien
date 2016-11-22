using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KetNoiDB;
using System.Data.SqlClient;

namespace BangThuVien
{
    public class DangNhap
    {
        public string LayPass(string user)
        {
            string st = "select MatKhau from TaiKhoan where ID = '" + user +"'";
            string gt = "";
            SqlConnection cn = new SqlConnection(KetNoi.connect());
            cn.Open();
            SqlCommand cmd = new SqlCommand(st, cn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                gt = (reader.GetValue(0).ToString());
            }
            reader.Close();
            cn.Close();
            return gt;
        }
    }
}
