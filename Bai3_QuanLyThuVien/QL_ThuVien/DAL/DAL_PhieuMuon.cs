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
    public class DAL_PhieuMuon
    {
        KetNoiData cn = new KetNoiData();
        public DataTable GetAllPhieuMuon()
        {
            return cn.GetDataTable(@"SELECT * FROM PhieuMuon");
        }
        public bool Them(EC_PhieuMuon et)
        {
            try
            {
                cn.ThucHienLenh(@"INSERT INTO PhieuMuon (MaPM,MaBD,TrangThai) VALUES ('" + et.MaPM + "',N'" + et.MaBD + "'," + et.TrangThai + ")");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(EC_PhieuMuon et)
        {
            try
            {
                cn.ThucHienLenh(@"UPDATE PhieuMuon SET MaBD = N'" + et.MaBD + "',TrangThai = "+et.TrangThai+" where MaPM = N'"+et.MaPM+"')");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoa(EC_PhieuMuon et)
        {
            cn.ThucHienLenh(@"DELETE FROM PhieuMuon where MaPM = '" + et.MaPM + "'");
        }
        public DataTable GetThongTinTimKiem(string dieukien)
        {
            return cn.GetDataTable(@"SELECT MaPM, PhieuMuon.MaBD, HoTen, TrangThai FROM PhieuMuon,BanDoc " + dieukien);
        }

    }
}
