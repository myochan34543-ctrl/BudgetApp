using NUnit.Framework;
using BudgetApp.Models;
using System;

namespace BudgetApp.Tests
{
    public class BudgetManagerTests
    {
        [Test]
        public void Should_Calculate_Monthly_Income_Correctly()
        {
            // Arrange
            var manager = new BudgetManager();
            var salary = new Category("Salary");

            manager.AddTransaction(new Transaction(1000, salary, new DateTime(2026, 1, 5), true));
            manager.AddTransaction(new Transaction(500, salary, new DateTime(2026, 1, 20), true));

            // Act
            var totalIncome = manager.GetMonthlyIncome(2026, 1);

            // Assert
            Assert.AreEqual(1500, totalIncome);
        }

        [Test]
        public void Should_Calculate_Monthly_Expense_Correctly()
        {
            // Arrange
            var manager = new BudgetManager();
            var food = new Category("Food");

            manager.AddTransaction(new Transaction(200, food, new DateTime(2026, 1, 10), false));
            manager.AddTransaction(new Transaction(300, food, new DateTime(2026, 1, 15), false));

            // Act
            var totalExpense = manager.GetMonthlyExpense(2026, 1);

            // Assert
            Assert.AreEqual(500, totalExpense);
        }
    }
}