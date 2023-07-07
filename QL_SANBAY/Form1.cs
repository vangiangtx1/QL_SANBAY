using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QL_SANBAY
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SqlConnection connect = new SqlConnection();
        public frmMain()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            CMND.Text = "CMND=" + Program.cmnd;
            HOTEN.Text = "HOTEN=" + Program.HoTen;
            NHOM.Text = "NHOM=" + Program.Nhom;
            if (Program.Nhom.Trim() == "PHICONG")
            {
                pgPhiCong.Visible = true;
                pgNhanVien.Visible = false;
                pgQuanTri.Visible = true;
                btnTaoTK.Enabled = false;
                pgBackupRestore.Visible = false ;
            }
            else if (Program.Nhom.Trim() == "NHANVIEN")
            {
                pgNhanVien.Visible = true;
                pgQuanTri.Visible = true;
                pgPhiCong.Visible = false;
                btnTaoTK.Enabled = false;
                pgBackupRestore.Visible = false;
            }
            else
            {
                pgQuanTri.Visible = true;
                pgPhiCong.Visible = false;
                pgNhanVien.Visible = false;
                btnTaoTK.Enabled = true;
                pgBackupRestore.Visible = true;
            }

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            pgBaoCao.Visible = true;
        }

        public void ExecSP(String strLenh)
        {
            connect.ConnectionString = Program.connstr_publiser;
            SqlCommand sqlcmd = new SqlCommand(strLenh, connect);
            sqlcmd.CommandType = CommandType.Text;
            if (connect.State == ConnectionState.Closed) connect.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Lỗi exec SP \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            connect.Close();
        }

        public void ExecSP1(String strLenh)
        {
            connect.ConnectionString = Program.connstr_publiser1;
            SqlCommand sqlcmd = new SqlCommand(strLenh, connect);
            sqlcmd.CommandType = CommandType.Text;
            if (connect.State == ConnectionState.Closed) connect.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Lỗi exec SP \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            connect.Close();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoai f = new frmLoai();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaChua f = new frmNhaChua();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMayBay f = new frmMayBay();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhiCong f = new frmPhiCong();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDichVuBaoTri f = new frmDichVuBaoTri();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuMayBay f = new frmChuMayBay();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSoHuu f = new frmSoHuu();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLai f = new frmLai();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoTri f = new frmBaoTri();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVienBaoTri f = new frmNhanVienBaoTri();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhiCongLaiMayBay f = new frmPhiCongLaiMayBay();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietNhanVienBaoTri f = new frmChiTietNhanVienBaoTri();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaiKhoanPhiCong f = new frmTaiKhoanPhiCong();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinNhanVien f = new frmThongTinNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rprtNhanVien rpt = new rprtNhanVien();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rprtMayBay rpt = new rprtMayBay();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.MdiParent = this;
            f.Show();
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaoTaiKhoan f = new frmTaoTaiKhoan();
            f.MdiParent = this;
            f.Show();
        }

        private void btnBackUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sao lưu tất cả dữ liệu ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ExecSP("EXEC [BACK_UP_DATABASE]");
                Program.KetNoi();
                MessageBox.Show("Sao lưu dữ liệu thành công !", "", MessageBoxButtons.OK);
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn phục hồi tất cả dữ liệu ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ExecSP1("ALTER DATABASE SANBAY \n"+
                        "SET SINGLE_USER \n"+
                        "WITH ROLLBACK IMMEDIATE \n"+
                        "RESTORE DATABASE SANBAY \n" +
                        @"FROM DISK = 'C:\BackupSQL\SANBAY.bak' "+
                        "WITH REPLACE, RECOVERY; ");
                Program.KetNoi();
                MessageBox.Show("Phục hồi dữ liệu thành công !", "", MessageBoxButtons.OK);
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
