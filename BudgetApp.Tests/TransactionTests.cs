using BudgetApp.Models;
using NUnit.Framework;
using System;

namespace BudgetApp.Tests
{
    public class TransactionTests
    {
        [Test]
        public void Transaction_ShouldStoreDataCorrectly()
        {
            // Arrange
            var category = new Category("Food");
            var date = new DateTime(2026, 1, 1);

            // Act
            var transaction = new Transaction(100, category, date, false);

            // Assert
            Assert.AreEqual(100, transaction.Amount);
            Assert.AreEqual(category, transaction.Category);
            Assert.AreEqual(date, transaction.Date);
            Assert.IsFalse(transaction.IsIncome);
        }
    }
}
