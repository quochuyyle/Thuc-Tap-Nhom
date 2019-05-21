using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quan_li_diem_HS_tieu_hoc
{
    public  class LuuTruDanhSach
    {
        private List<HocSinh> lstHocSinh = new List<HocSinh>();

        public DataTable DsHocSinh()
        {
            string strSQL = "Select STT,Ho,Ten,MaHS,Lop,NgaySinh,GioiTinh from HocSinh";
            return DataProvider.LayDanhSach(strSQL);
        }

        public bool ThemMoiHocSinh(HocSinh objHocSinh)
        {
            string strInsert = "Insert into HocSinh(Ho,Ten,MaHS,Lop,NgaySinh,GioiTinh) values(@Ho,@Ten,@MaHS,@Lop,@NgaySinh,@GioiTinh)";
            SqlParameter[] pars = new SqlParameter[6];

            pars[0] = new SqlParameter("@Ho",SqlDbType.NChar,20);
            pars[0].Value = objHocSinh.Ho;

            pars[1] = new SqlParameter("@Ten",SqlDbType.NChar,20);
            pars[1].Value = objHocSinh.Ten;

            pars[2] = new SqlParameter("@MaHS",SqlDbType.NVarChar,5);
            pars[2].Value = objHocSinh.MaHS;

            pars[3] = new SqlParameter("@Lop",SqlDbType.NVarChar,5);
            pars[3].Value = objHocSinh.Lop;

            pars[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            pars[4].Value = objHocSinh.NgaySinh;

            pars[5] = new SqlParameter("@GioiTinh", SqlDbType.NChar, 10);
            pars[5].Value = objHocSinh.GioiTinh;

            return DataProvider.ThucHienChucNang(strInsert,pars);
        }

        public HocSinh HienThiThongTinHocSinhTheoMaHS(string MaHS)
        {
            string str = "Select * from HocSinh where MaHS='"+MaHS+"'";
            HocSinh objHocSinh = null;
            DataTable dt = DataProvider.LayDanhSach(str);
            if (dt.Rows.Count>0)
            {
                objHocSinh = new HocSinh();
                objHocSinh.Ho = "" + dt.Rows[0]["Ho"];
                objHocSinh.Ten = "" + dt.Rows[0]["Ten"];
                objHocSinh.MaHS = "" + dt.Rows[0]["MaHS"];
                DateTime ngay = DateTime.Today;
                DateTime.TryParse(""+dt.Rows[0]["NgaySinh"],out ngay);
                objHocSinh.NgaySinh =ngay;
                objHocSinh.GioiTinh = ""+ dt.Rows[0]["GioiTinh"];
                objHocSinh.Lop = ""+ dt.Rows[0]["Lop"];
            }
            return objHocSinh;
            }


        public  Diem  HienThiDiemCuaHocSinhTheoMaHS(string MaHS)
        {
            Diem objDiem = null;
            string strSQL = "SELECT * FROM HocSinh ,Diem D WHERE D.MaHS='"+MaHS+"'";
            DataTable dt = DataProvider.LayDanhSach(strSQL);
            if(dt.Rows.Count>0)
            {
                objDiem = new Diem();
                objDiem.Ho = "" + dt.Rows[0]["Ho"];
                objDiem.Ten = "" + dt.Rows[0]["Ten"];
                objDiem.MaHS = "" + dt.Rows[0]["MaHS"];

                objDiem.TOAN15 = "" + dt.Rows[0]["Toan15"];
                objDiem.TOAN60 = "" + dt.Rows[0]["Toan60"];
                objDiem.TOANHK = "" + dt.Rows[0]["ToanHK"];
                objDiem.TOANTB = "" + dt.Rows[0]["ToanTB"];

                objDiem.ANH15 = "" + dt.Rows[0]["TA15"];
                objDiem.ANH60 = "" + dt.Rows[0]["TA60"];
                objDiem.ANHHK = "" + dt.Rows[0]["TAHK"];
                objDiem.ANHTB = "" + dt.Rows[0]["TATB"];

                objDiem.VAN15 = "" + dt.Rows[0]["Van15"];
                objDiem.VAN60 = "" + dt.Rows[0]["Van60"];
                objDiem.VANHK = "" + dt.Rows[0]["VanHK"];
                objDiem.VANTB = "" + dt.Rows[0]["VanTB"];

                objDiem.DIA15 = "" + dt.Rows[0]["DIA15"];
                objDiem.DIA60 = "" + dt.Rows[0]["DIA60"];
                objDiem.DIAHK = "" + dt.Rows[0]["DIAHK"];
                objDiem.DIATB = "" + dt.Rows[0]["DIATB"];

                objDiem.SU15 = "" + dt.Rows[0]["SU15"];
                objDiem.SU60 = "" + dt.Rows[0]["SU60"];
                objDiem.SUHK = "" + dt.Rows[0]["SUHK"];
                objDiem.SUTB = "" + dt.Rows[0]["SUTB"];

                // objDiem = new Diem();
                //objDiem.Ho = "" + dt.Rows[1]["Ho"];
                //objDiem.Ten = "" + dt.Rows[1]["Ten"];
                //objDiem.MaHS = "" + dt.Rows[1]["MaHS"];

                //objDiem.TOAN15 = "" + dt.Rows[1]["Toan15"];
                //objDiem.TOAN60 = "" + dt.Rows[1]["Toan60"];
                //objDiem.TOANHK = "" + dt.Rows[1]["ToanHK"];
                //objDiem.TOANTB = "" + dt.Rows[1]["ToanTB"];

                //objDiem.ANH15 = "" + dt.Rows[1]["TA15"];
                //objDiem.ANH60 = "" + dt.Rows[1]["TA60"];
                //objDiem.ANHHK = "" + dt.Rows[1]["TAHK"];
                //objDiem.ANHTB = "" + dt.Rows[1]["TATB"];

                //objDiem.VAN15 = "" + dt.Rows[1]["Van15"];
                //objDiem.VAN60 = "" + dt.Rows[1]["Van60"];
                //objDiem.VANHK = "" + dt.Rows[1]["VanHK"];
                //objDiem.VANTB = "" + dt.Rows[1]["VanTB"];

                //objDiem.DIA15 = "" + dt.Rows[1]["DIA15"];
                //objDiem.DIA60 = "" + dt.Rows[1]["DIA60"];
                //objDiem.DIAHK = "" + dt.Rows[1]["DIAHK"];
                //objDiem.DIATB = "" + dt.Rows[1]["DIATB"];

                //objDiem.SU15 = "" + dt.Rows[1]["SU15"];
                //objDiem.SU60 = "" + dt.Rows[1]["SU60"];
                //objDiem.SUHK = "" + dt.Rows[1]["SUHK"];
                //objDiem.SUTB = "" + dt.Rows[1]["SUTB"];

            }
            return objDiem;
        }


        public bool CapNhatThongTinHS(HocSinh objHocSinh)
        {
            string strUpdate = "Update HocSinh set Ho=@Ho,Ten=@Ten,MaHS=@MaHS,Lop=@Lop,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh";
            SqlParameter[] pars = new SqlParameter[6];

            pars[0] = new SqlParameter("@Ho",SqlDbType.NChar,20);
            pars[0].Value = objHocSinh.Ho;

            pars[1] = new SqlParameter("@Ten", SqlDbType.NChar, 20);
            pars[1].Value = objHocSinh.Ten;

            pars[2] = new SqlParameter("@MaHS", SqlDbType.NVarChar, 5);
            pars[2].Value = objHocSinh.MaHS;

            pars[3] = new SqlParameter("@Lop", SqlDbType.NVarChar, 5);
            pars[3].Value = objHocSinh.Lop;

            pars[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            pars[4].Value = objHocSinh.NgaySinh;

            pars[5] = new SqlParameter("@GioiTinh", SqlDbType.NChar,5);
            pars[5].Value = objHocSinh.GioiTinh;


            return DataProvider.ThucHienChucNang(strUpdate,pars); ;
        }

        public bool CapNhatDiemHocSinh(Diem objDiem)
        {
            string strUpdate = "Update Diem set Toan15=@Toan15,Toan60=@Toan60,ToanHK=@ToanHK,ToanTB=@ToanTB,Van15=@Van15,Van60=@Van60,VanHK=@VanHK,VanTB=@VanTB,TA15=@TA15,TA60=@TA60,TAHK=@TAHK,TATB=@TATB,DIA15=@DIA15,DIA60=@DIA60,DIAHK=@DIAHK,DIATB=@DIATB,SU15=@SU15,SU60=@SU60,SUHK=@SUHK,SUTB=@SUTB";
            SqlParameter[] pars = new SqlParameter[20];

            pars[0] =new SqlParameter("@Toan15",SqlDbType.NVarChar,50);
            pars[0].Value = objDiem.TOAN15;
            pars[1] = new SqlParameter("@Toan60", SqlDbType.NVarChar, 50);
            pars[1].Value = objDiem.TOAN60;
            pars[2] = new SqlParameter("@ToanHK", SqlDbType.NVarChar, 50);
            pars[2].Value = objDiem.TOANHK;
            pars[3] = new SqlParameter("@ToanTB", SqlDbType.NVarChar, 50);
            pars[3].Value = objDiem.TOANTB;



            pars[4] = new SqlParameter("@VAN15", SqlDbType.NVarChar, 50);
            pars[4].Value = objDiem.VAN15;
            pars[5] = new SqlParameter("@VAN60", SqlDbType.NVarChar, 50);
            pars[5].Value = objDiem.VAN60;
            pars[6] = new SqlParameter("@VANHK", SqlDbType.NVarChar, 50);
            pars[6].Value = objDiem.VANHK;
            pars[7] = new SqlParameter("@VANTB", SqlDbType.NVarChar, 50);
            pars[7].Value = objDiem.VANTB;


            pars[8] = new SqlParameter("@TA15", SqlDbType.NVarChar, 50);
            pars[8].Value = objDiem.ANH15;
            pars[9] = new SqlParameter("@TA60", SqlDbType.NVarChar, 50);
            pars[9].Value = objDiem.ANH60;
            pars[10] = new SqlParameter("@TAHK", SqlDbType.NVarChar, 50);
            pars[10].Value = objDiem.ANHHK;
            pars[11] = new SqlParameter("@TATB", SqlDbType.NVarChar, 50);
            pars[11].Value = objDiem.ANHTB;


            pars[12] = new SqlParameter("@DIA15", SqlDbType.NVarChar, 50);
            pars[12].Value = objDiem.DIA15;
            pars[13] = new SqlParameter("@DIA60", SqlDbType.NVarChar, 50);
            pars[13].Value = objDiem.DIA60;
            pars[14] = new SqlParameter("@DIAHK", SqlDbType.NVarChar, 50);
            pars[14].Value = objDiem.DIAHK;
            pars[15] = new SqlParameter("@DIATB", SqlDbType.NVarChar, 50);
            pars[15].Value = objDiem.DIATB;


            pars[16] = new SqlParameter("@SU15", SqlDbType.NVarChar, 50);
            pars[16].Value = objDiem.SU15;
            pars[17] = new SqlParameter("@SU60", SqlDbType.NVarChar, 50);
            pars[17].Value = objDiem.SU60;
            pars[18] = new SqlParameter("@SUHK", SqlDbType.NVarChar, 50);
            pars[18].Value = objDiem.SUHK;
            pars[19] = new SqlParameter("@SUTB", SqlDbType.NVarChar, 50);
            pars[19].Value = objDiem.SUTB;

            return DataProvider.ThucHienChucNang(strUpdate,pars);
        }

        public bool XoaThongTinHocSinh(string MaHS)
        {
            string strDelete = "Delete * from HocSinh where MaHS='"+MaHS+"'";
            SqlParameter[] pars = new SqlParameter[6];
            HocSinh objHocSinh = new HocSinh();

            pars[0] = new SqlParameter("@Ho", SqlDbType.NChar, 20);
            pars[0].Value = objHocSinh.Ho;

            pars[1] = new SqlParameter("@Ten", SqlDbType.NChar, 20);
            pars[1].Value = objHocSinh.Ten;

            pars[2] = new SqlParameter("@MaHS", SqlDbType.NVarChar, 5);
            pars[2].Value = objHocSinh.MaHS;

            pars[3] = new SqlParameter("@Lop", SqlDbType.NVarChar, 5);
            pars[3].Value = objHocSinh.Lop;

            pars[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            pars[4].Value = objHocSinh.NgaySinh;

            pars[5] = new SqlParameter("@GioiTinh", SqlDbType.NChar, 5);
            pars[5].Value = objHocSinh.GioiTinh;

            return DataProvider.ThucHienChucNang(strDelete,pars);
        }
    }
}
