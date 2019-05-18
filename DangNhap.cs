using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Quan_li_diem_HS_tieu_hoc
{
    public class DangNhap
    {
        public DataTable TaiKhoan(string TaiKhoan)
        {
            string strSQL = "Select TaiKhoan,MatKhau from TaiKhoan where TaiKhoan='"+TaiKhoan+"'";
            return DataProvider.LayDanhSach(strSQL);
        }

        public DataTable DoiMK(string TaiKhoan,string MKmoi)
        {
            string strSQL = "Update TaiKhoan set MatKhau='"+MKmoi+"' where TaiKhoan='"+TaiKhoan+"'";
            return DataProvider.LayDanhSach(strSQL);
        }
    }
}
