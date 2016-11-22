using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity
{
    public class EC_PhieuMuon
    {
        private string _MaPM;
        public string MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }
        private string _MaBD;
        public string MaBD
        {
            get { return _MaBD; }
            set { _MaBD = value; }
        }
        private int _TrangThai;
        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
