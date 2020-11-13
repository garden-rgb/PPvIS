using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public interface IBank
    {
        void CreateClient(string name, int age);
        protected string AccountName { get; set; }
        protected decimal Balance(Guid id);
        void Withdraw(Guid id, decimal ammount);
        void CashIn(Guid id, decimal amount);
    }
}
