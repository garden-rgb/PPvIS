using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Transaction
    {
        public Transaction()
        {
            Time = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Time { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        
    }
}
