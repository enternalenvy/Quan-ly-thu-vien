using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KetNoiDB;
namespace BangThuVien
{
    public class BUS_PhieuMuon
    {
        KetNoi cn = new KetNoi();
        public DataTable HienThiPhieuMuon()
        {
            string sql = "SELECT * FROM PhieuMuon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void ThemPhieuMuon(string MaPM, string MaBD, string TrangThai)
        {
            string sql = "INSERT INTO PhieuMuon(MaPM,MaBD,TrangThai) VALUES ('" + MaPM + "','" + MaBD + "','" + TrangThai + "')";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPM", MaPM);
            cmd.Parameters.AddWithValue("@MaBD", MaBD);
            cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void SuaPhieuMuon(string MaPM, string MaBD, string TrangThai)
        {
            string sql = "UPDATE PhieuMuon SET MaPM = ";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPM", MaPM);
            cmd.Parameters.AddWithValue("@MaBD", MaBD);
            cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void XoaPhieuMuon(string MaPM)
        {
            string sql = "XoaPhieuMuon";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBD", MaPM);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
