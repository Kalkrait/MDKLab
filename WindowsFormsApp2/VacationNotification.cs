using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EMPmanager
{
    public class VacationNotification
    {
        public int DaysBeforeStart { get; set; } = 3;
        public int DaysBeforeEnd { get; set; } = 1;

        // Получить сотрудников, которые начинают отпуск сегодня или в ближайшие дни (но ещё не в отпуске)
        public List<Employee> GetEmployeesStartingVacationSoon(List<Employee> employees, DateTime currentDate)
        {
            return employees.Where(e =>
                e.VacationStart.HasValue &&
                !e.IsOnVacation && // НЕ в отпуске сейчас
                (e.VacationStart.Value.Date - currentDate.Date).Days <= DaysBeforeStart &&
                (e.VacationStart.Value.Date - currentDate.Date).Days >= 0).ToList();
        }

        // Получить сотрудников, у которых отпуск заканчивается в ближайшие дни (и они сейчас в отпуске)
        public List<Employee> GetEmployeesEndingVacationSoon(List<Employee> employees, DateTime currentDate)
        {
            return employees.Where(e =>
                e.VacationEnd.HasValue &&
                e.IsOnVacation && // Только если сейчас в отпуске
                (e.VacationEnd.Value.Date - currentDate.Date).Days <= DaysBeforeEnd &&
                (e.VacationEnd.Value.Date - currentDate.Date).Days >= 0).ToList();
        }

        // Получить сотрудников, которые сейчас в отпуске (без дублирования)
        public List<Employee> GetEmployeesCurrentlyOnVacation(List<Employee> employees, DateTime currentDate)
        {
            return employees.Where(e => e.IsOnVacation).ToList();
        }

        public string GetNotificationsText(List<Employee> employees, DateTime currentDate)
        {
            var startingSoon = GetEmployeesStartingVacationSoon(employees, currentDate);
            var endingSoon = GetEmployeesEndingVacationSoon(employees, currentDate);
            var onVacationNow = GetEmployeesCurrentlyOnVacation(employees, currentDate);

            // Убираем из списка "в отпуске" тех, кто уже попал в endingSoon (чтобы не дублировать)
            var onVacationNotEndingSoon = onVacationNow.Where(e => !endingSoon.Contains(e)).ToList();

            string message = "";

            // 1. Сотрудники, которые возвращаются из отпуска в ближайшие дни (приоритет 1)
            if (endingSoon.Any())
            {
                message += "⚠️ Сотрудники, возвращающиеся из отпуска:\n";
                foreach (var emp in endingSoon)
                {
                    int daysToEnd = (emp.VacationEnd.Value.Date - currentDate.Date).Days;
                    string daysText = daysToEnd == 0 ? "СЕГОДНЯ!" : $"через {daysToEnd} дн.";
                    message += $"   • {emp.Name} - {daysText} (до {emp.VacationEnd.Value:dd.MM.yyyy})\n";
                }
                message += "\n";
            }

            // 2. Сотрудники, которые сейчас в отпуске (без тех, кто возвращается)
            if (onVacationNotEndingSoon.Any())
            {
                message += "🏖️ Сотрудники в отпуске:\n";
                foreach (var emp in onVacationNotEndingSoon)
                {
                    int daysLeft = (emp.VacationEnd.Value.Date - currentDate.Date).Days;
                    message += $"   • {emp.Name} - вернётся через {daysLeft} дн.\n";
                }
                message += "\n";
            }

            // 3. Сотрудники, которые уходят в отпуск (только если ещё не в отпуске)
            if (startingSoon.Any())
            {
                message += "🔔 Сотрудники, уходящие в отпуск:\n";
                foreach (var emp in startingSoon)
                {
                    int daysToStart = (emp.VacationStart.Value.Date - currentDate.Date).Days;
                    string daysText = daysToStart == 0 ? "СЕГОДНЯ!" : $"через {daysToStart} дн.";
                    message += $"   • {emp.Name} - {daysText} (с {emp.VacationStart.Value:dd.MM.yyyy})\n";
                }
                message += "\n";
            }

            if (string.IsNullOrEmpty(message))
            {
                message = "✅ Нет предстоящих отпусков в ближайшие дни.\n\n" +
                         $"Настройки уведомлений:\n" +
                         $"   • О начале отпуска за {DaysBeforeStart} дн.\n" +
                         $"   • О завершении отпуска за {DaysBeforeEnd} дн.";
            }

            return message;
        }

        public void ShowNotifications(List<Employee> employees, DateTime currentDate)
        {
            string message = GetNotificationsText(employees, currentDate);
            MessageBox.Show(message, "📅 Уведомления об отпусках",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool HasNotifications(List<Employee> employees, DateTime currentDate)
        {
            return GetEmployeesStartingVacationSoon(employees, currentDate).Any() ||
                   GetEmployeesEndingVacationSoon(employees, currentDate).Any() ||
                   GetEmployeesCurrentlyOnVacation(employees, currentDate).Any();
        }
    }
}