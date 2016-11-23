using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
namespace DAL
{
    public class DAL_BanDoc
    {
        KetNoiData cn = new KetNoiData();
        public DataTable GetThongTinBanDoc(string name)
        {
            return cn.GetDataTable(@"SELECT HoTen, NgaySinh ,CMND, TenLop, GioiTinh, DiaChi, Email, DienThoai FROM BanDoc a, Lop b where a.MaLop = b.MaLop and MaBD = N'" + name + "'");
        }
    }
}
