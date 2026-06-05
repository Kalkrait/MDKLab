using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
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
                {
                    return false;
                }
                return DateTime.Now >= VacationStart.Value && DateTime.Now <=
                VacationEnd.Value;
            }
        }
    }
}
