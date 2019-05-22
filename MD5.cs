using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_li_diem_HS_tieu_hoc
{
    public class MD5
    {
        public static String GetMD5(string txt)
        {
            String str= "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach(Byte b in buffer)
            {
                str +=b.ToString("x2");

            }
            return str;
        }

    }
}
