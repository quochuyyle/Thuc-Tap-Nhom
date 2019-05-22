using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_diem_HS_tieu_hoc
{
    public partial class frmDanhSachNhanVien : Form
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void HienThiThongTin()
        {
            LuuTruDanhSach service = new LuuTruDanhSach();
            DataTable dt = service.DSNhanVien();
            gridThongTin.DataSource = dt;
            for (int i=0;i<gridThongTin.RowCount-1;i++)
            {
                gridThongTin.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MaNV;
            MaNV = "" + gridThongTin.CurrentRow.Cells[1].Value;
            frmThemMoiNhanVien frm = new frmThemMoiNhanVien();
            frm.MANV = MaNV;
            frm.ShowDialog();
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
