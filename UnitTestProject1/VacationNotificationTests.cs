using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EMPmanager.Tests
{
    [TestClass]
    public class VacationNotificationTests
    {
        private VacationNotification _notification;
        private List<Employee> _employees;

        [TestInitialize]
        public void Setup()
        {
            _notification = new VacationNotification();
            _employees = new List<Employee>();
        }

        [TestMethod]
        public void GetEmployeesStartingVacationSoon_WhenVacationStartsIn3Days_ReturnsEmployee()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Иван", "Программист", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 6, 10);
            employee.VacationEnd = new DateTime(2026, 6, 20);
            _employees.Add(employee);
            _notification.DaysBeforeStart = 3;

            // Act
            var result = _notification.GetEmployeesStartingVacationSoon(_employees, currentDate);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Иван", result[0].Name);
        }

        [TestMethod]
        public void GetEmployeesStartingVacationSoon_WhenVacationStartsToday_ReturnsEmptyBecauseAlreadyOnVacation()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Кирилл", "Стажер", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 6, 7);
            employee.VacationEnd = new DateTime(2026, 6, 21);
            _employees.Add(employee);
            _notification.DaysBeforeStart = 3;

            // Act
            var result = _notification.GetEmployeesStartingVacationSoon(_employees, currentDate);

            // Assert
            // Сотрудник уже в отпуске, поэтому не должен показываться в "уходящих"
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetEmployeesStartingVacationSoon_WhenVacationStartsTomorrow_ReturnsEmployee()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Кирилл", "Стажер", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 6, 8);
            employee.VacationEnd = new DateTime(2026, 6, 22);
            _employees.Add(employee);
            _notification.DaysBeforeStart = 3;

            // Act
            var result = _notification.GetEmployeesStartingVacationSoon(_employees, currentDate);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Кирилл", result[0].Name);
        }

        [TestMethod]
        public void GetEmployeesEndingVacationSoon_WhenVacationEndsIn1Day_ReturnsEmployee()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Мария", "Дизайнер", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 5, 25);
            employee.VacationEnd = new DateTime(2026, 6, 8);
            _employees.Add(employee);
            _notification.DaysBeforeEnd = 1;

            // Act
            var result = _notification.GetEmployeesEndingVacationSoon(_employees, currentDate);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Мария", result[0].Name);
        }

        [TestMethod]
        public void GetEmployeesEndingVacationSoon_WhenVacationEndsToday_ReturnsEmployee()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Петр", "Менеджер", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 5, 20);
            employee.VacationEnd = new DateTime(2026, 6, 7);
            _employees.Add(employee);
            _notification.DaysBeforeEnd = 1;

            // Act
            var result = _notification.GetEmployeesEndingVacationSoon(_employees, currentDate);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Петр", result[0].Name);
        }

        [TestMethod]
        public void GetEmployeesCurrentlyOnVacation_WhenOnVacation_ReturnsEmployee()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Петр", "Менеджер", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 6, 1);
            employee.VacationEnd = new DateTime(2026, 6, 10);
            _employees.Add(employee);

            // Act
            var result = _notification.GetEmployeesCurrentlyOnVacation(_employees, currentDate);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result[0].IsOnVacation);
        }

        [TestMethod]
        public void GetEmployeesCurrentlyOnVacation_WhenNotOnVacation_ReturnsEmpty()
        {
            // Arrange
            var employee = new Employee("Анна", "Тестировщик", new DateTime(2025, 1, 1));
            employee.VacationStart = null;
            employee.VacationEnd = null;
            _employees.Add(employee);

            // Act
            var result = _notification.GetEmployeesCurrentlyOnVacation(_employees, DateTime.Today);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetNotificationsText_WhenNoVacations_ReturnsMessage()
        {
            // Arrange
            var employee = new Employee("Сергей", "Разработчик", new DateTime(2025, 1, 1));
            _employees.Add(employee);

            // Act
            var result = _notification.GetNotificationsText(_employees, DateTime.Today);

            // Assert
            Assert.IsTrue(result.Contains("Нет предстоящих отпусков"));
        }

        [TestMethod]
        public void GetNotificationsText_WhenVacationStartsSoon_ReturnsCorrectMessage()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Иван", "Программист", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 6, 10);
            employee.VacationEnd = new DateTime(2026, 6, 20);
            _employees.Add(employee);
            _notification.DaysBeforeStart = 3;

            // Act
            var result = _notification.GetNotificationsText(_employees, currentDate);

            // Assert
            Assert.IsTrue(result.Contains("уходящие в отпуск"));
            Assert.IsTrue(result.Contains("Иван"));
        }

        [TestMethod]
        public void GetNotificationsText_WhenVacationEndsSoon_ReturnsCorrectMessage()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Мария", "Дизайнер", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 5, 25);
            employee.VacationEnd = new DateTime(2026, 6, 8);
            _employees.Add(employee);
            _notification.DaysBeforeEnd = 1;

            // Act
            var result = _notification.GetNotificationsText(_employees, currentDate);

            // Assert
            Assert.IsTrue(result.Contains("возвращающиеся из отпуска"));
            Assert.IsTrue(result.Contains("Мария"));
        }

        [TestMethod]
        public void HasNotifications_WhenNoVacations_ReturnsFalse()
        {
            // Arrange
            var employee = new Employee("Сергей", "Разработчик", new DateTime(2025, 1, 1));
            _employees.Add(employee);

            // Act
            var result = _notification.HasNotifications(_employees, DateTime.Today);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasNotifications_WhenVacationStartsSoon_ReturnsTrue()
        {
            // Arrange
            var currentDate = new DateTime(2026, 6, 7);
            var employee = new Employee("Иван", "Программист", new DateTime(2025, 1, 1));
            employee.VacationStart = new DateTime(2026, 6, 10);
            employee.VacationEnd = new DateTime(2026, 6, 20);
            _employees.Add(employee);

            // Act
            var result = _notification.HasNotifications(_employees, currentDate);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShowNotifications_WhenNoUpcomingVacations_DoesNotThrow()
        {
            // Arrange
            var employee = new Employee("Сергей", "Разработчик", new DateTime(2025, 1, 1));
            _employees.Add(employee);

            // Act & Assert
            try
            {
                _notification.ShowNotifications(_employees, DateTime.Today);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail("Метод не должен выбрасывать исключение");
            }
        }
    }
}