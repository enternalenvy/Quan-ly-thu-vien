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
        private string _NgayMuon;
        public string NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }
        private string _NgayTra;
        public string NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
        private string _NgayDangKy;
        public string NgayDangKy
        {
            get { return _NgayDangKy; }
            set { _NgayDangKy = value; }
        }
        private string _NgayLay;
        public string NgayLay
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
