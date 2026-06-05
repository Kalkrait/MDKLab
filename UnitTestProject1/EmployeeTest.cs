using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace EMPmanager.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Constructor_ValidData_SetsPropertiesCorrectly()
        {
            // Arrange
            var hireDate = new DateTime(2020, 1, 1);

            // Act
            var emp = new Employee("Иван Петров", "Разработчик", hireDate);

            // Assert
            Assert.AreEqual("Иван Петров", emp.Name);
            Assert.AreEqual("Разработчик", emp.Position);
            Assert.AreEqual(hireDate, emp.HireDate);
            Assert.IsNull(emp.VacationStart);
            Assert.IsNull(emp.VacationEnd);
        }

        [TestMethod]
        public void IsOnVacation_WhenNoVacation_ReturnsFalse()
        {
            // Arrange
            var emp = new Employee("Анна Сидорова", "Тестировщик", DateTime.Now.AddYears(-1));

            // Act
            bool result = emp.IsOnVacation;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsOnVacation_WhenVacationInProgress_ReturnsTrue()
        {
            // Arrange
            var emp = new Employee("Ольга Иванова", "Менеджер", DateTime.Now.AddYears(-2));
            emp.VacationStart = DateTime.Now.AddDays(-5);
            emp.VacationEnd = DateTime.Now.AddDays(5);

            // Act
            bool result = emp.IsOnVacation;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOnVacation_WhenVacationEnded_ReturnsFalse()
        {
            // Arrange
            var emp = new Employee("Дмитрий Козлов", "Аналитик", DateTime.Now.AddYears(-3));
            emp.VacationStart = DateTime.Now.AddDays(-20);
            emp.VacationEnd = DateTime.Now.AddDays(-10);

            // Act
            bool result = emp.IsOnVacation;

            // Assert
            Assert.IsFalse(result);
        }
    }
}