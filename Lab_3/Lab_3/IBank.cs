using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    /// <summary>
    /// Интерфейс банка
    /// </summary>
    public interface IBank
    {
        public decimal Balance { get; }
        void Withdraw(decimal amount);
        void CashIn(decimal amount);
    }
}
