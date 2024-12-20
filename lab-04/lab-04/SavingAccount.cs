using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    // Lớp SavingAccount
    public class SavingAccount : Account
    {
        private decimal Rate; // Tỷ lệ lãi suất

        // Constructor
        public SavingAccount(decimal initialize, decimal rate) : base(initialize)
        {
            if (rate < 0)
            {
                throw new ArgumentException("Tỷ lệ lãi suất không thể nhỏ hơn 0.");
            }
            Rate = rate;
        }

        // Phương thức lấy tiền lãi
        public decimal GetInterest()
        {
            return Balance * Rate / 100;
        }
    }
}