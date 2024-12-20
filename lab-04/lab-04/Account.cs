using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    // Lớp Account
    public class Account
    {

        protected decimal Balance;

        // Constructor

        public Account(decimal initialize)
        {
            if (initialize < 0)
            {
                throw new ArgumentException("Số tiền ban đầu không thể nhỏ hơn 0.");
            }
            Balance = initialize;
        }

        // Phương thức gửi tiền
        public virtual void Deposit(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Số tiền gửi phải lớn hơn 0.");
                return;
            }
            Balance += money;
            Console.WriteLine($"Gửi tiền thành công. Số dư hiện tại: {Balance:C}");
        }

        // Phương thức rút tiền
        public virtual void WithDraw(decimal money)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            if (money <= 0)
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0.");
                return;
            }
            if (money > Balance)
            {
                Console.WriteLine("Số tiền rút vượt quá số dư.");
                return;
            }
            Balance -= money;
            Console.WriteLine($"Rút tiền thành công. Số dư hiện tại: {Balance:C}");
        }

        // Phương thức trả về số dư
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}