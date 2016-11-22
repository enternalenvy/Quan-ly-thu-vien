using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_ChiTietPhieuMuon
    {
        private string _MaPM;
        public string MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }
        private string _GTCB;
        public string GTCB
        {
            get { return _GTCB; }
            set { _GTCB = value; }
        }
        private DateTime _NgayMuon;
        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }
        private DateTime _NgayTra;
        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
        private DateTime _NgayDangKy;
        public DateTime NgayDangKy
        {
            get { return _NgayDangKy; }
            set { _NgayDangKy = value; }
        }
        private DateTime _NgayLay;
        public DateTime NgayLay
        {
            get { return _NgayLay; }
            set { _NgayLay = value; }
        }
        private string _GhiChu;
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
