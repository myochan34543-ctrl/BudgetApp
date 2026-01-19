using NUnit.Framework;
using BudgetApp.Models;

namespace BudgetApp.Tests
{
    public class CategoryTests
    {
        [Test]
        public void Category_Name_ShouldBeSetCorrectly()
        {
            // Arrange
            var category = new Category("Food");

            // Act
            var result = category.Name;

            // Assert
            Assert.AreEqual("Food", result);
        }
    }
}
