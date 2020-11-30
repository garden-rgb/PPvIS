using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    /// <summary>
    /// Класс реализации функций банкомата
    /// </summary>
    public class SampleBank : Bank, IBank
    {
        private const int Limit = 100;

        private const decimal LowRate = 10;

        private const int LowRateAgeLimit = 28;

        private const decimal AverageRate = 20;

        private const int AverageRateAgeLimit = 45;

        private const decimal HighRate = 30;

        private Client client;
        public SampleBank(int age, decimal balance, string name):base(name,balance,age)
        {
            balance = Balance;
        }
        public decimal Balance => base.GetBalance();
        
        public void Withdraw(decimal amount)
        {
            if (amount > Limit)
            {
                Console.WriteLine("You have exceeded the allowed amount for cash withdraw");
            }
            else
            {
                var actualClient = client;
                var flag = VerifyPin(actualClient);

                if (flag)
                {
                    var delta = Balance - amount;
                    var finalAmount = amount; // avoiding editing argument

                    if (delta < 0)
                    {
                        var feeRate = CalculateRate(client.ScoringRate, LowRate, AverageRate, HighRate);
                        delta = Math.Abs(delta);
                        finalAmount += delta * feeRate - delta;
                    }
                    base.Withdraw(finalAmount);
                }
                else
                {
                    Console.WriteLine("Wrong Pin-Code");
                }
            }
        }
        public void CashIn(decimal amount)
        {
            var actualClient = client;
            var flag = VerifyPin(actualClient);
            if (flag)
            {
                var newBalance = Balance + amount;
                base.CashIn(newBalance);
            }
        }
    }
}
