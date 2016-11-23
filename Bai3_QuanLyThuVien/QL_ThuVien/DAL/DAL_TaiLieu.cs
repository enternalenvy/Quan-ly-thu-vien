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
    public class DAL_TaiLieu
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getTenSach()
        {
            return cn.GetDataTable(@"SELECT MaTL,NhanDe FROM TaiLieu");
        }
        public DataTable getGTCB(string name)
        {
            return cn.GetDataTable(@"SELECT GTCB FROM GiaTriCaBiet where MaTL = N'"+name+"'");
        }
        public DataTable getMaTL(string name)
        {
            return cn.GetDataTable(@"SELECT MaTL FROM TaiLieu where NhanDe = N'" + name + "'");
        }
    }
}
