using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Client
    {
        public Client()
        {
            Transactions = new List<decimal>();
        }
        public Guid Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public List<decimal> Transactions { get; set; }

    }
}
