using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_BanDoc
    {
        private string _MaBD;
        public string MaBD
        {
            get { return _MaBD; }
            set { _MaBD = value; }
        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _GioiTinh;
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _CMND;
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        private string _MaLop;
        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _DienThoai;
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
    }
}
