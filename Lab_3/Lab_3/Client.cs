using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    /// <summary>
    /// Класс клиента
    /// </summary>
    public class Client
    {
        public Client()
        {
            Transactions = new List<decimal>();
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
        /// <summary>
        /// Список транзакций
        /// </summary>
        public List<decimal> Transactions { get; set; }
        /// <summary>
        /// Рейтинг клиента 
        /// </summary>
        public ClientScoringRate ScoringRate { get; set; }

    }
}
