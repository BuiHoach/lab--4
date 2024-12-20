using System.Text;

namespace lab_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Tạo danh sách nhân viên bán hàng và công nhân
            NhanVien nhanVienBanHang = new NhanVienBanHang("Nguyễn Văn A", "Hà Nội", 100);
            NhanVien congNhan = new CongNhan("Trần Thị B", "Hồ Chí Minh", 50);

            // Hiển thị thông tin và tính lương
            nhanVienBanHang.HienThi();
            Console.WriteLine();
            congNhan.HienThi();
        }
    }
}