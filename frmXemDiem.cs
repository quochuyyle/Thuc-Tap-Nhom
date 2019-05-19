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
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private string _MaHS;
        public string MAHS
        {
            get { return _MaHS; }
            set { _MaHS = value; }
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {

            HienThiThongTin();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HienThiThongTin()
        {
            LuuTruDanhSach service = new LuuTruDanhSach();
            Diem objDiem = service.HienThiDiemCuaHocSinhTheoMaHS(MAHS);

            if (objDiem != null)
            {
                string HoVTen = objDiem.Ho + objDiem.Ten;
                txtHoTen.Text = HoVTen;
                txtMaHS.Text = objDiem.MaHS;

                txtTOAN15.Text = objDiem.TOAN15;
                txtTOAN60.Text = objDiem.TOAN60;
                txtTOANHK.Text = objDiem.TOANHK;
                txtTOANTB.Text = objDiem.TOANTB;

                txtVAN15.Text = objDiem.VAN15;
                txtVAN60.Text = objDiem.VAN60;
                txtVANHK.Text = objDiem.VANHK;
                txtVANTB.Text = objDiem.VANTB;

                txtTA15.Text = objDiem.ANH15;
                txtTA60.Text = objDiem.ANH60;
                txtTAHK.Text = objDiem.ANHHK;
                txtTATB.Text = objDiem.ANHTB;

                txtDIA15.Text = objDiem.DIA15;
                txtDIA60.Text = objDiem.DIA60;
                txtDIAHK.Text = objDiem.DIAHK;
                txtDIATB.Text = objDiem.DIATB;

                txtSU15.Text = objDiem.SU15;
                txtSU60.Text = objDiem.SU60;
                txtSUHK.Text = objDiem.SUHK;
                txtSUTB.Text = objDiem.SUTB;


            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool Insert = true;
            Diem objDiem = new Diem();
            if (!string.IsNullOrEmpty(MAHS))
            {
                Insert = false;
            }
            string HoVTen = txtHoTen.Text;

            objDiem.MaHS = txtMaHS.Text;

            objDiem.TOAN15 = txtTOAN15.Text;
            objDiem.TOAN60 = txtTOAN60.Text;
            objDiem.TOANHK = txtTOANHK.Text;
            objDiem.TOANTB = txtTOANTB.Text;

            objDiem.VAN15 = txtVAN15.Text;
            objDiem.VAN60 = txtVAN60.Text;
            objDiem.VANHK = txtVANHK.Text;
            objDiem.VANTB = txtVANTB.Text;

            objDiem.ANH15 = txtTA15.Text;
            objDiem.ANH60 = txtTA60.Text;
            objDiem.ANHHK = txtTAHK.Text;
            objDiem.ANHTB = txtTATB.Text;

            objDiem.SU15 = txtSU15.Text;
            objDiem.SU60 = txtSU60.Text;
            objDiem.SUHK = txtSUHK.Text;
            objDiem.SUTB = txtSUTB.Text;

            objDiem.DIA15 = txtSU15.Text;
            objDiem.DIA60 = txtSU60.Text;
            objDiem.DIAHK = txtSUHK.Text;
            objDiem.DIATB = txtSUTB.Text;

            bool ketQua = false;
            if (Insert)
            {
                ketQua = DataProvider.lstDanhSach.CapNhatDiemHocSinh(objDiem);
            }
            if (ketQua)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
