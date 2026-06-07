using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EMPmanager
{
    public class EmployeeManager
    {
        public List<Employee> Employees { get; private set; }
        private readonly string _filePath = "employees.txt";

        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            Employees.Remove(employee);
        }

        public void UpdateVacation(Employee employee, DateTime? vacationStart, DateTime? vacationEnd)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (vacationStart.HasValue && vacationEnd.HasValue && vacationStart.Value > vacationEnd.Value)
                throw new ArgumentException("Дата начала отпуска не может быть позже даты окончания");

            employee.VacationStart = vacationStart;
            employee.VacationEnd = vacationEnd;
        }

        public void SaveToFile()
        {
            var lines = Employees.Select(e =>
            {
                string vacationStartStr = e.VacationStart?.ToString("yyyy-MM-dd") ?? "";
                string vacationEndStr = e.VacationEnd?.ToString("yyyy-MM-dd") ?? "";
                return $"{e.Name}|{e.Position}|{e.HireDate:yyyy-MM-dd}|{vacationStartStr}|{vacationEndStr}";
            });
            File.WriteAllLines(_filePath, lines);
        }

        public void LoadFromFile()
        {
            Employees.Clear();

            if (!File.Exists(_filePath))
                return;

            var lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5 && DateTime.TryParse(parts[2], out DateTime hireDate))
                {
                    DateTime? vacationStart = null;
                    DateTime? vacationEnd = null;

                    if (!string.IsNullOrEmpty(parts[3]) && DateTime.TryParse(parts[3], out DateTime tempStart))
                        vacationStart = tempStart;

                    if (!string.IsNullOrEmpty(parts[4]) && DateTime.TryParse(parts[4], out DateTime tempEnd))
                        vacationEnd = tempEnd;

                    try
                    {
                        var employee = new Employee(parts[0], parts[1], hireDate)
                        {
                            VacationStart = vacationStart,
                            VacationEnd = vacationEnd
                        };
                        Employees.Add(employee);
                    }
                    catch (ArgumentException)
                    {
                        // Пропускаем некорректные строки
                    }
                }
            }
        }
    }
}