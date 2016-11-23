using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;
namespace QL_ThuVien
{
    public partial class frmPhieuMuon : Form
    {
        DAL_PhieuMuon phieumuon = new DAL_PhieuMuon();
        DAL_ChiTietPhieuMuon ctpm = new DAL_ChiTietPhieuMuon();
        DAL_BanDoc bandoc = new DAL_BanDoc();
        DAL_TaiLieu tl = new DAL_TaiLieu();
        EC_PhieuMuon etphieumuon = new EC_PhieuMuon();
        EC_ChiTietPhieuMuon et_ctpm = new EC_ChiTietPhieuMuon();
        DataTable dt = new DataTable();
        DataTable tbl = new DataTable();
        string dieukien;
        string MaTL;
        string GTCB;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dieukien = "";
            if(rbtnMaBD.Checked == true)
            {
                dieukien += "where BanDoc.MaBD = PhieuMuon.MaBD and PhieuMuon.MaBD like '%" + txtTimKiem.Text + "%'";
                dgvTimKiem.DataSource = phieumuon.GetThongTinTimKiem(dieukien); 
            }
            if(rbtnHoten.Checked == true)
            {
                dieukien += "where BanDoc.MaBD = PhieuMuon.MaBD and HoTen like N'%" + txtTimKiem.Text + "%'";
                dgvTimKiem.DataSource = phieumuon.GetThongTinTimKiem(dieukien);
            }  
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.SelectionStart = txtTimKiem.Text.Length;
        }

        private void cbTrangThai_Click(object sender, EventArgs e)
        {
            cbTrangThai.SelectionStart = cbTrangThai.Text.Length;
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Đang Mượn");
            cbTrangThai.Items.Add("Đã Trả");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbTrangThai.Text == "Đang Mượn")
            {
                //dieukien = "";
                dieukien += "and TrangThai = 1";
                dgvTimKiem.DataSource = phieumuon.GetThongTinTimKiem(dieukien);
            }
            if (cbTrangThai.Text == "Đã Trả")
            {
                dieukien = "";
                dieukien += "where TrangThai = 0";
                dgvTimKiem.DataSource = phieumuon.GetThongTinTimKiem(dieukien);
            }
            
        }

        private void dgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                etphieumuon.MaPM = dgvTimKiem.Rows[dong].Cells[0].Value.ToString();
                etphieumuon.MaBD = dgvTimKiem.Rows[dong].Cells[1].Value.ToString();
                //Thông tin bạn đọc
                
                dt = bandoc.GetThongTinBanDoc(etphieumuon.MaBD);
                txtHoTen.Text = dt.Rows[0][0].ToString();
                dtpNgaySinh.Text = dt.Rows[0][1].ToString();
                txtCMND.Text = dt.Rows[0][2].ToString();
                txtLop.Text = dt.Rows[0][3].ToString();
                if (dt.Rows[0][4].ToString() == "Nam") chkBoxNam.Checked = true;
                else chkBoxNu.Checked = true;
                txtDiaChi.Text = dt.Rows[0][5].ToString();
                txtEmail.Text = dt.Rows[0][6].ToString();
                txtDienThoai.Text = dt.Rows[0][7].ToString();
                //ChiTietPhieuMuon
                tbl = ctpm.getAllChiTietPhieuMuon(etphieumuon.MaPM);
                dgvChiTietPhieuMuon.DataSource = tbl;
                txtMaPM.Text = tbl.Rows[0][0].ToString();
                dtpNgayMuon.Text = tbl.Rows[0][1].ToString();
                dtpNgayTra.Text = tbl.Rows[0][2].ToString();
                cbTenSach.Text = tbl.Rows[0][3].ToString();
                txtGhiChu.Text = tbl.Rows[0][4].ToString();
            }
            catch { }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            et_ctpm.MaPM = txtMaPM.Text;
            et_ctpm.NgayMuon = dtpNgayMuon.Value.ToShortDateString();
            et_ctpm.NgayTra = dtpNgayTra.Value.ToShortDateString();
            if (ctpm.Sua(et_ctpm) == true)
            {
                MessageBox.Show("Gia Hạn Thành Công","Thông Báo",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            dgvChiTietPhieuMuon.DataSource = ctpm.getAllChiTietPhieuMuon(etphieumuon.MaPM);
        }

        private void btnAddSach_Click(object sender, EventArgs e)
        {
            dtpNgayTra.Text = "";
            dtpNgayMuon.Text = "";
            cbTenSach.DataSource = tl.getTenSach();
            cbTenSach.DisplayMember = "NhanDe";
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MaTL = tl.getMaTL(cbTenSach.Text).Rows[0][0].ToString();
            GTCB = tl.getGTCB(MaTL).Rows[0][0].ToString();
            // them du lieu
            et_ctpm.MaPM = txtMaPM.Text;
            et_ctpm.GTCB = GTCB;
            et_ctpm.NgayMuon = dtpNgayMuon.Value.ToShortDateString();
            et_ctpm.NgayTra = dtpNgayTra.Value.ToShortDateString();
            et_ctpm.NgayDangKy = DateTime.Now.ToShortDateString();
            et_ctpm.NgayLay = DateTime.Now.ToShortDateString();
            et_ctpm.GhiChu = txtGhiChu.Text;
            if (ctpm.Them(et_ctpm))
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            MaTL = tl.getMaTL(cbTenSach.Text).Rows[0][0].ToString();
            GTCB = tl.getGTCB(MaTL).Rows[0][0].ToString();
            traloi = MessageBox.Show("Bạn có muốn xóa??","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
            {
                ctpm.Xoa(GTCB);
            }
        }
    }
}
