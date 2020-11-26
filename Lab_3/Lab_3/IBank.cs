using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public interface IBank
    {
        string InitializeClient(string name, int age);
        public decimal Balance { get; }
        void Withdraw(decimal amount);
        void CashIn(decimal amount);
    }
}
