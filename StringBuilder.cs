using System;
using System.IO;
using static System.Console;
using System.Text;


namespace HomeWork_String
{
    public class BTVN_String
    {
        public static void Main()

        {
            BTVN_String b2 = new BTVN_String();
            b2.StringBuilder();

            BTVN_String b1 = new BTVN_String();
            b1.User();
        }

        public void StringBuilder()
        {
            StringBuilder build1 = new StringBuilder("Knock knock ", 100);
            StringBuilder build2 = new StringBuilder("Avadra Kedava", 100);
            string str1 = "\nJoe";
            string str2 = "\nWho's there";
            string str3 = "Meow ";
            Write("Chuoi ban dau {0}, {1}:", build1, build2);
            build1.Append(str2);
            Write("\nSau khi ghep chuoi bang Append: " + build1);
            build1.AppendFormat("{0}", str1);
            Write("\nGhep bang Append Format: " + build1);
            build2.Insert(6, str3);
            Write("\nChen mot chuoi vao giua string ban dau: " + build2);
            build2.Remove(3, 5);
            Write("\nXoa ky tu tu 3 den 5: " + build2);
            build2.Replace("e", "a");
            Write("\nThay e bang a: " + build2);
        }
        public struct NguoiDung
        {
            public string HoTen;
            public string TenDangNhap;
            public string MatKhau;
            public string SoDienThoai;
            public string Email;

        }
        public void User()
        {
            NguoiDung user1 = new NguoiDung();
            user1.HoTen = "Lee Nhung";
            user1.TenDangNhap = "leenhung";
            user1.MatKhau = "123456";
            user1.SoDienThoai = "0911057923";
            user1.Email = "hongnhungle491@gmail.com";

            Write("Ho ten cua nguoi dung: " + user1.HoTen);
            Write("\nTen dang nhap cua nguoi dung: " + user1.TenDangNhap);
            Write("\nMat khau: " + user1.MatKhau);
            Write("\nSo dien thoai: "+ user1.SoDienThoai);
            Write("\nEmail: " + user1.Email);
        }
    }
}
