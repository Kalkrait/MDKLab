using System;
using System.Linq;
using System.Windows.Forms;

namespace EMPmanager
{
    public partial class EMPform : Form
    {
        private EmployeeManager _employeeManager;
        private VacationNotification _notification;

        public EMPform()
        {
            InitializeComponent();
            _employeeManager = new EmployeeManager();
            _notification = new VacationNotification();
            UpdateEmployeesList();
        }

        public void UpdateEmployeesList()
        {
            employeesListBox.Items.Clear();
            foreach (var employee in _employeeManager.Employees)
            {
                employeesListBox.Items.Add(employee.ToString());
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Заполните поле 'Имя сотрудника'!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(positionTextBox.Text))
                {
                    MessageBox.Show("Заполните поле 'Должность'!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    positionTextBox.Focus();
                    return;
                }

                var newEmployee = new Employee(nameTextBox.Text.Trim(),
                    positionTextBox.Text.Trim(), hireDatePicker.Value);

                if (vacationStartPicker.Value <= vacationEndPicker.Value)
                {
                    newEmployee.VacationStart = vacationStartPicker.Value;
                    newEmployee.VacationEnd = vacationEndPicker.Value;
                }

                _employeeManager.AddEmployee(newEmployee);

                nameTextBox.Clear();
                positionTextBox.Clear();

                UpdateEmployeesList();
                MessageBox.Show($"Сотрудник '{newEmployee.Name}' добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeesListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите сотрудника для удаления!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedItem = employeesListBox.SelectedItem.ToString();
                string name = selectedItem.Split('-')[0].Trim();

                var employeeToRemove = _employeeManager.Employees.FirstOrDefault(emp => emp.Name == name);

                if (employeeToRemove != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Удалить сотрудника '{employeeToRemove.Name}'?",
                        "Подтверждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _employeeManager.RemoveEmployee(employeeToRemove);
                        UpdateEmployeesList();
                        MessageBox.Show("Сотрудник удален!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateVacationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeesListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите сотрудника!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedItem = employeesListBox.SelectedItem.ToString();
                string name = selectedItem.Split('-')[0].Trim();

                var employeeToUpdate = _employeeManager.Employees.FirstOrDefault(emp => emp.Name == name);

                if (employeeToUpdate != null)
                {
                    if (vacationStartPicker.Value > vacationEndPicker.Value)
                    {
                        MessageBox.Show("Дата начала не может быть позже даты окончания!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _employeeManager.UpdateVacation(employeeToUpdate, vacationStartPicker.Value, vacationEndPicker.Value);
                    UpdateEmployeesList();
                    MessageBox.Show("Отпуск обновлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeManager.SaveToFile();
                MessageBox.Show("Данные сохранены в файл!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeManager.LoadFromFile();
                UpdateEmployeesList();
                MessageBox.Show("Данные загружены из файла!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                _notification.ShowNotifications(_employeeManager.Employees, DateTime.Today);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}