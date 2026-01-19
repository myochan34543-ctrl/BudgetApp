using System;

namespace BudgetApp.Models
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncome { get; set; }

        public Transaction(decimal amount, Category category, DateTime date, bool isIncome)
        {
            Amount = amount;
            Category = category;
            Date = date;
            IsIncome = isIncome;
        }
    }
}
