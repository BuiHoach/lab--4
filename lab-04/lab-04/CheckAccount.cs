using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    // Lớp CheckAccount
    public class CheckAccount : Account
    {
        private decimal FeeTransfer; // Phí giao dịch

        // Constructor
        public CheckAccount(decimal initialize, decimal feeTransfer) : base(initialize)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            if (feeTransfer < 0)
            {
                throw new ArgumentException("Phí giao dịch không thể nhỏ hơn 0.");
            }
            FeeTransfer = feeTransfer;
        }

        // Ghi đè phương thức gửi tiền
        public override void Deposit(decimal money)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            base.Deposit(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Phí giao dịch {FeeTransfer:C} đã được trừ. Số dư hiện tại: {Balance:C}");
        }

        // Ghi đè phương thức rút tiền
        public override void WithDraw(decimal money)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            if (money + FeeTransfer > Balance)
            {
                Console.WriteLine("Số tiền rút cộng phí giao dịch vượt quá số dư.");
                return;
            }
            base.WithDraw(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Phí giao dịch {FeeTransfer:C} đã được trừ. Số dư hiện tại: {Balance:C}");
        }
    }

}
