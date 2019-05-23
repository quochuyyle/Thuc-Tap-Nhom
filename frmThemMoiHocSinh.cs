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
    public partial class frmThemMoiHocSinh : Form
    {
        public frmThemMoiHocSinh()
        {
            InitializeComponent();
        }

        private string _MaHS;
        public string MaHS
        {
            get { return _MaHS; }
            set { _MaHS = value; }
        }

        private void frmThemMoiHocSinh_Load(object sender, EventArgs e)
        {

 
            if (string.IsNullOrEmpty(MaHS))
            {
                this.Text = "Thêm mới nhân viên";

            }
            else
            {
                this.Text = "Cập nhật thông tin nhân viên";
                HienThiThongTinHocSinh();

            }
        }

          
            private void HienThiGT()
            {
            GT service = new GT();
            DataTable dt = service.GioiTinh();
            cbGioiTinh.DisplayMember = "GioiTinh";
            cbGioiTinh.ValueMember = "GioiTinh";
            cbGioiTinh.DataSource = dt;
            }
            
         
            private void btnDong_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnThucHien_Click(object sender, EventArgs e)
            {
                bool Insert = true;
                HocSinh objHocSinh = new HocSinh();
                if (!string.IsNullOrEmpty(MaHS))
                {
                    Insert = false;
                }
                objHocSinh.Ho = txtHo.Text;
                objHocSinh.Ten = txtTen.Text;
                objHocSinh.MaHS = txtMaHS.Text;
                objHocSinh.NgaySinh = dtNgaySinh.Value;
                objHocSinh.MaLop = txtMaLop.Text;
               string GioiTinh = "" + cbGioiTinh.SelectedItem;
                objHocSinh.GioiTinh = GioiTinh;
                bool ketQua = false;
                if (Insert)
                {
                    ketQua = DataProvider.lstDanhSach.ThemMoiHocSinh(objHocSinh);
                }
                else
                {
                    ketQua = DataProvider.lstDanhSach.CapNhatThongTinHS(objHocSinh);
                }
                if (ketQua)
                {
                    MessageBox.Show("Thực hiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }



            }

            private void HienThiThongTinHocSinh()
            {
                LuuTruDanhSach service = new LuuTruDanhSach();
                HocSinh objHocSinh = service.HienThiThongTinHocSinhTheoMaHS(MaHS);
                if (objHocSinh != null)
                {
                    txtHo.Text = objHocSinh.Ho;
                    txtTen.Text = objHocSinh.Ten;
                    txtMaHS.Text = objHocSinh.MaHS;
                    txtMaLop.Text = objHocSinh.MaLop;
                    dtNgaySinh.Value = objHocSinh.NgaySinh;
                  
                    cbGioiTinh.SelectedValue = objHocSinh.GioiTinh;
                }
            }
        }
    }

