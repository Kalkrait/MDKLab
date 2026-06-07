using System;

namespace EMPmanager
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? VacationStart { get; set; }
        public DateTime? VacationEnd { get; set; }

        public Employee(string name, string position, DateTime hireDate)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя сотрудника не может быть пустым");
            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentException("Должность не может быть пустой");

            Name = name;
            Position = position;
            HireDate = hireDate;
            VacationStart = null;
            VacationEnd = null;
        }

        public bool IsOnVacation
        {
            get
            {
                if (VacationStart == null || VacationEnd == null)
                    return false;

                DateTime today = DateTime.Today;
                return today >= VacationStart.Value.Date && today <= VacationEnd.Value.Date;
            }
        }

        public override string ToString()
        {
            string vacationStatus = IsOnVacation ? "В отпуске" : "На работе";
            return $"{Name} - {Position} ({vacationStatus})";
        }
    }
}