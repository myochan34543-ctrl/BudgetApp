using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetApp.Models
{
    public class BudgetManager
    {
        private readonly List<Transaction> _transactions; 

        public BudgetManager()
        {
            _transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public decimal GetMonthlyIncome(int year, int month)
        {
            return _transactions
                .Where(t => t.IsIncome &&
                            t.Date.Year == year &&
                            t.Date.Month == month)
                .Sum(t => t.Amount);
        }

        public decimal GetMonthlyExpense(int year, int month)
        {
            return _transactions
                .Where(t => !t.IsIncome &&
                            t.Date.Year == year &&
                            t.Date.Month == month)
                .Sum(t => t.Amount);
        }
    }
}
