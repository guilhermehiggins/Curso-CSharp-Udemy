using Exceções.Entities.Exceptions;
namespace Exceções.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int number, string holder, double inicialBalance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = inicialBalance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance - amount < 0)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
