using System;
using System.IO;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace Chuan_Hoa_Chuoi
{
    public class Chuan_Hoa_String
    {
        public static void Main()
        {
            NguoiDung user1 = new NguoiDung();

            //Khai báo 1 biến kiểu chuỗi tên là HoTen
            //Khai báo 1 biến user chứa kết quả chuẩn hoá chuỗi.
            //Giá trị biến HoTen được nhập từ bàn phím.
          
            string HoTen= "";
            Write("Nhap ho va ten nguoi dung: ");
            user1.HoTen = ReadLine();
            user1.HoTen = user1.HoTen.Trim();                    // Cắt các khoảng trắng dư ở đầu và cuối chuỗi 
           
            while (user1.HoTen.Contains("  "))
            {
                user1.HoTen = user1.HoTen.Replace("  ", " ");          //thay thế 2 khoảng trắng bằng 1 khoảng trắng                                                        
            }           
            string[] substring = user1.HoTen.Split(' ');              //Cắt họ tên ra thành mảng 
            for (int i = 0; i < substring.Length; i++)
            {
                string FirstChar = substring[i].Substring(0, 1);          //Cắt ra chữ cái đầu trên và lưu trong biến FirstChar
                string OtherChar = substring[i].Substring(1);             //Cắt các chữ cái còn lại và lưu trong biến OtherChar.         
                substring[i] = FirstChar.ToUpper() + OtherChar.ToLower(); //Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
                HoTen += substring[i] + " ";
            }
            

            string TenDangNhap = "";
            Write("Nhap ten dang nhap: ");
            user1.TenDangNhap = ReadLine();
            user1.TenDangNhap = user1.TenDangNhap.Trim();
            while (user1.TenDangNhap.Contains(" "))
            {
                user1.TenDangNhap = user1.TenDangNhap.Replace(" ", "");          //thay thế 1 khoảng trắng bằng không có gì                                                      
            }     
            user1.TenDangNhap.ToLower();
            TenDangNhap = user1.TenDangNhap;
            


            char[] MatKhau;
            Write("Nhap mat khau nguoi dung: ");
            user1.MatKhau = ReadLine();
            user1.MatKhau = user1.MatKhau.Trim();
            string temp = user1.MatKhau;
            MatKhau = temp.ToCharArray();
            for(int i=0; i<MatKhau.Length; i++)
            {
                if (MatKhau[i] >= '0' && MatKhau[i] <= '9') /// ky tu i la so
                    continue;
                if (MatKhau[i] >= 'a' && MatKhau[i] <= 'z') /// ky tu i la chu cai thuong
                    continue;
                if (MatKhau[i] >= 'A' && MatKhau[i] <= 'Z') /// ky tu i la chu cai hoa
                    continue;

                /// con lai
                MatKhau[i] = ' ';
            }
            // bởi vì char[] không có tìm kiếm nên ta đổi về cho user1.MatKhau
            user1.MatKhau = new string(MatKhau);
            while (user1.MatKhau.Contains(" "))
            {
                user1.MatKhau = user1.MatKhau.Replace(" ", "");
            }
            

            nhaplaimatkhau:
            char[] SoDienThoai;
            Write("Nhap so dien thoai cua nguoi dung: ");
            user1.SoDienThoai = ReadLine();
            SoDienThoai = user1.SoDienThoai.ToCharArray();
            user1.SoDienThoai = user1.SoDienThoai.Trim();

            if(user1.SoDienThoai.Length != 10)
            {
                WriteLine("Do dai chua du. Hay nhap lai mat khau lan nua: ");
                goto nhaplaimatkhau;
            }

            for (int i =0; i< 10; i++)
            {
                if ( (SoDienThoai[i] >= '0' && SoDienThoai[i] <= '9') || SoDienThoai[i] == ' ')
                    continue;
                
                WriteLine("Hay nhap lai mat khau lan nua: ");
                goto nhaplaimatkhau;

            }                   
            

            string Email;
            Email = user1.Email;
            Write("Nhap email cua nguoi dung: ");
            user1.Email = ReadLine();
            user1.Email = user1.Email.Trim();                    // Cắt các khoảng trắng dư ở đầu và cuối chuỗi 

            while (user1.Email.Contains(" "))
            {
                user1.Email = user1.Email.Replace("  ", "");          //thay thế 2 khoảng trắng bằng 1 khoảng trắng                                                        
            }

            WriteLine("\n----------Hien thong tin nguoi dung----------");
            WriteLine("Ho ten cua nguoi dung: " + HoTen);
            WriteLine("Ten dang nhap cua nguoi dung: " + TenDangNhap);
            WriteLine("Mat khau cua nguoi dung: " + user1.MatKhau);
            WriteLine("So dien thoai cua nguoi dung: " + user1.SoDienThoai);
            WriteLine("Email cua nguoi dung la: " + user1.Email);


        }
        public struct NguoiDung
        {
            public string HoTen;
            public string TenDangNhap;
            public string MatKhau;
            public string SoDienThoai;
            public string Email;

        }
        
    }
}
