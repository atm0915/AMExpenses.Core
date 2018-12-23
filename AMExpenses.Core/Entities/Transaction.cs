using System;

namespace AMExpenses.Core.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}