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
    public class DAL_ChiTietPhieuMuon
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getAllChiTietPhieuMuon(string name)
        {
            return cn.GetDataTable(@"SELECT MaPM, NgayMuon, NgayTra, b.NhanDe, GhiChu FROM ChiTietPhieuMuon a, TaiLieu b, GiaTriCaBiet c where a.GTCB = c.GTCB and c.MaTL = b.MaTL and a.MaPM = '"+name+"'");
        }
        public bool Them(EC_ChiTietPhieuMuon et)
        {
            try
            {
                cn.ThucHienLenh(@"INSERT INTO ChiTietPhieuMuon (MaPM,GTCB,NgayMuon,NgayTra,NgayDangKy,NgayLay,GhiChu) VALUES (N'" + et.MaPM + "',N'" + et.GTCB + "',N'" + et.NgayMuon + "',N'"+et.NgayTra+"',N'"+et.NgayDangKy+"',N'"+et.NgayLay +"',N'"+et.GhiChu+"')");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(EC_ChiTietPhieuMuon et)
        {
            try
            {
                cn.ThucHienLenh(@"UPDATE ChiTietPhieuMuon SET NgayMuon = N'"+et.NgayMuon+"',NgayTra = N'"+et.NgayTra+"',NgayDangKy = N'"+ et.NgayDangKy+ "', NgayLay = N'"+et.NgayDangKy+"', GhiChu = N'"+et.GhiChu+"' where MaPM = N'"+et.MaPM+"'");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoa(string name)
        {
            cn.ThucHienLenh(@"DELETE FROM ChiTietPhieuMuon where GTCB = '" + name+ "'");
        }
    }
}
