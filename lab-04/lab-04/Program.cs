using System.Text;
using System.Xml;

namespace lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
               
                // Kiểm thử lớp Account
                Account account = new Account(1000);
                account.Deposit(500);
                account.WithDraw(300);
                Console.WriteLine($"Số dư tài khoản: {account.GetBalance():C}\n");

                // Kiểm thử lớp SavingAccount
                SavingAccount savingAccount = new SavingAccount(2000, 5);
                Console.WriteLine($"Tiền lãi: {savingAccount.GetInterest():C}");

                // Kiểm thử lớp CheckAccount
                CheckAccount checkAccount = new CheckAccount(1500, 10);
                checkAccount.Deposit(500);
                checkAccount.WithDraw(300);
                Console.WriteLine($"Số dư tài khoản kiểm tra: {checkAccount.GetBalance():C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }
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
