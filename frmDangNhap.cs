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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static bool isThanhCong { get; set; }
        public static string TenDangNhap;


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TenDangNhap = txtTenDangNhap.Text;
            string MatKhau =MD5.GetMD5(txtMatKhau.Text) ;
            DangNhap service = new DangNhap();
            DataTable dt = service.TaiKhoan(TenDangNhap);
            if(dt.Rows.Count>0)
            {
                string MatKhauDB = "" + dt.Rows[0]["MatKhau"];
                if(MatKhauDB.Equals(MatKhau))
                {
                    isThanhCong = true;
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbShowMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
