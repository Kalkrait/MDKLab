using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using WindowsFormsApp2;

namespace EMPmanager.Tests
{
    [TestClass]
    public class EmployeeManagerTests
    {
        private string _testFilePath = "employees.txt";

        [TestInitialize]
        public void Setup()
        {
            // Удаляем тестовый файл перед каждым тестом
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }

        [TestMethod]
        public void AddEmployee_ValidEmployee_AddsToListAndSaves()
        {
            // Arrange
            var manager = new EmployeeManager();
            var emp = new Employee("Тест Тестов", "Инженер", DateTime.Now);

            // Act
            manager.AddEmployee(emp);

            // Assert
            Assert.AreEqual(1, manager.Employees.Count);
            Assert.AreEqual(emp.Name, manager.Employees.First().Name);
            Assert.IsTrue(File.Exists(_testFilePath));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddEmployee_NullEmployee_ThrowsException()
        {
            var manager = new EmployeeManager();
            manager.AddEmployee(null);
        }

        [TestMethod]
        public void RemoveEmployee_ExistingEmployee_RemovesFromList()
        {
            // Arrange
            var manager = new EmployeeManager();
            var emp = new Employee("Для удаления", "HR", DateTime.Now);
            manager.AddEmployee(emp);

            // Act
            manager.RemoveEmployee(emp);

            // Assert
            Assert.AreEqual(0, manager.Employees.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveEmployee_NullEmployee_ThrowsException()
        {
            var manager = new EmployeeManager();
            manager.RemoveEmployee(null);
        }

        [TestMethod]
        public void UpdateVacation_ValidDates_UpdatesEmployeeVacation()
        {
            // Arrange
            var manager = new EmployeeManager();
            var emp = new Employee("Отпускник", "Директор", DateTime.Now);
            manager.AddEmployee(emp);
            var start = new DateTime(2025, 7, 1);
            var end = new DateTime(2025, 7, 15);

            // Act
            manager.UpdateVacation(emp, start, end);

            // Assert
            Assert.AreEqual(start, emp.VacationStart);
            Assert.AreEqual(end, emp.VacationEnd);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateVacation_NullEmployee_ThrowsException()
        {
            var manager = new EmployeeManager();
            manager.UpdateVacation(null, DateTime.Now, DateTime.Now.AddDays(5));
        }

        [TestMethod]
        public void LoadEmployees_WhenFileExists_LoadsData()
        {
            // Arrange
            File.WriteAllLines(_testFilePath, new[]
            {
                "Иван|Разработчик|2023-01-01||",
                "Мария|Тестировщик|2023-02-01|2024-06-01|2024-06-10"
            });

            // Act
            var manager = new EmployeeManager();

            // Assert
            Assert.AreEqual(2, manager.Employees.Count);
            Assert.AreEqual("Иван", manager.Employees[0].Name);
            Assert.IsNull(manager.Employees[0].VacationStart);
            Assert.AreEqual("Мария", manager.Employees[1].Name);
            Assert.IsNotNull(manager.Employees[1].VacationStart);
        }
    }
}
