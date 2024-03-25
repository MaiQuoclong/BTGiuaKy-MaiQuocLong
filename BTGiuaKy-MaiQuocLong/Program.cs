using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTGiuaKy_MaiQuocLong
{
    public class Program
    {
        static void Main(string[] args)
        {
            DanhMuc danhMuc = new DanhMuc();

            Console.WriteLine("Nhap thong tin Sach:");
            Sach sach = NhapSachTuBanPhim();
            danhMuc.ThemTaiLieu(sach);

            Console.WriteLine("\nNhap thong tin tap chi:");
            TapChi tapChi = NhapTapChiTuBanPhim();
            danhMuc.ThemTaiLieu(tapChi);

            Console.WriteLine("\nNhap thong tin Bao:");
            Bao bao = NhapBaoTuBanPhim();
            danhMuc.ThemTaiLieu(bao);

            Console.WriteLine("\nDanh sach Sach:");
            foreach (var item in danhMuc.TimTheoLoai<Sach>())
            {
                Console.WriteLine($"{item.MaXuatBan} - {item.TenTaiLieu}");
            }

            Console.WriteLine("\nDanh sach Bao:");
            foreach (var item in danhMuc.TimTheoLoai<Bao>())
            {
                Console.WriteLine($"{item.MaXuatBan} - {item.TenTaiLieu}");
            }

            Console.WriteLine("\nDanh sach Tap chi:");
            foreach (var item in danhMuc.TimTheoLoai<TapChi>())
            {
                Console.WriteLine($"{item.MaXuatBan} - {item.TenTaiLieu}");
            }

            Console.WriteLine("\nDanh sach Bao co ngay phat hanh trong thang 3 nam 24:");
            foreach (var item in danhMuc.TimBaoTheoThangNam(3, 2024))
            {
                Console.WriteLine($"{item.MaXuatBan} - {item.TenTaiLieu}");
            }
        }

        static Sach NhapSachTuBanPhim()
        {
            Sach sach = new Sach();
            Console.Write("Nhap mxb: ");
            sach.MaXuatBan = Console.ReadLine();
            Console.Write("Nhap ten sach: ");
            sach.TenTaiLieu = Console.ReadLine();
            Console.Write("Nhap nph: ");
            sach.NhaPhatHanh = Console.ReadLine();
            Console.Write("Nhap ten tac gia: ");
            sach.TenTacGia = Console.ReadLine();
            Console.Write("Nhap so trang: ");
            sach.SoTrang = int.Parse(Console.ReadLine());
            return sach;
        }

        static TapChi NhapTapChiTuBanPhim()
        {
            TapChi tapChi = new TapChi();
            Console.Write("Nhap mxb: ");
            tapChi.MaXuatBan = Console.ReadLine();
            Console.Write("Nhap ten tap chi: ");
            tapChi.TenTaiLieu = Console.ReadLine();
            Console.Write("Nhap nph: ");
            tapChi.NhaPhatHanh = Console.ReadLine();
            Console.Write("Nhap so phat hanh: ");
            tapChi.SoPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhap trang phat hanh: ");
            tapChi.TrangPhatHanh = int.Parse(Console.ReadLine());
            return tapChi;
        }

        static Bao NhapBaoTuBanPhim()
        {
            Bao bao = new Bao();
            Console.Write("Nhap mxb: ");
            bao.MaXuatBan = Console.ReadLine();
            Console.Write("Nhap ten bao: ");
            bao.TenTaiLieu = Console.ReadLine();
            Console.Write("Nhap nph: ");
            bao.NhaPhatHanh = Console.ReadLine();
            Console.Write("Nhap ngay phat hanh (yyyy-MM-dd): ");
            bao.NgayPhatHanh = DateTime.Parse(Console.ReadLine());
            return bao;
        }
    }
}
