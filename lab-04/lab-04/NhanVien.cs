using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    abstract class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        public NhanVien(string ten, string diaChi)
        {
            Ten = ten;
            DiaChi = diaChi;
        }

        // Phương thức trừu tượng
        public abstract double TinhLuong();
        public abstract void HienThi();
    }
    class NhanVienBanHang : NhanVien
    {
        public int SoLuongBanDuoc { get; set; }

        public NhanVienBanHang(string ten, string diaChi, int soLuongBanDuoc)
            : base(ten, diaChi)
        {
            SoLuongBanDuoc = soLuongBanDuoc;
        }

        public override double TinhLuong()
        {
            // Giả định lương mỗi sản phẩm bán được là 50.000 VNĐ
            return SoLuongBanDuoc * 50000;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Nhân viên bán hàng: {Ten}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Số lượng bán được: {SoLuongBanDuoc}");
            Console.WriteLine($"Lương: {TinhLuong():C}");
        }
    }
    class CongNhan : NhanVien
    {
        public int SoLuongSanPham { get; set; }

        public CongNhan(string ten, string diaChi, int soLuongSanPham)
            : base(ten, diaChi)
        {
            SoLuongSanPham = soLuongSanPham;
        }

        public override double TinhLuong()
        {
            // Giả định lương mỗi sản phẩm là 20.000 VNĐ
            return SoLuongSanPham * 20000;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Công nhân: {Ten}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Số lượng sản phẩm: {SoLuongSanPham}");
            Console.WriteLine($"Lương: {TinhLuong():C}");
        }
    }

}
