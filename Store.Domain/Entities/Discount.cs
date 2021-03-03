using System;

namespace Store.Domain.Entities
{
    public class Discount : Entity
    {
        public double Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public Discount(double amount, DateTime expireDate)
        {
            Amount = amount;
            ExpireDate = expireDate;
        }

        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public double Value()
        {
            if (IsValid())
                return Amount;
            else
                return 0;
        }
    }
}