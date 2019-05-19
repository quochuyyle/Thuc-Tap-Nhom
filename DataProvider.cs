using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quan_li_diem_HS_tieu_hoc
{
    public class DataProvider
    {
        private static string ChuoiKetNoi= @"Server=DESKTOP-HTE04AH\SQLEXPRESS;Database=ThucTapNhom;Integrated Security=True";
        private static LuuTruDanhSach _lstDanhSach = new LuuTruDanhSach();
        public static LuuTruDanhSach lstDanhSach
        {
            get { return _lstDanhSach; }
            set { lstDanhSach = value; }
        }
        public static bool ThucHienChucNang(string strSQL,SqlParameter []pars=null)
        {
            bool ketQua = false;
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;

                if (pars!=null && pars.Length>0)
                {
                    comm.Parameters.AddRange(pars);
                }
                ketQua = comm.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                    throw ex;
            }
            return ketQua;
        }

        public static DataTable LayDanhSach(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlConnection conn =new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
