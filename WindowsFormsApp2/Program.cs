using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
public class EmployeeManager
{
    public List<Employee> Employees { get; private set; }
    public EmployeeManager()
    {
        Employees = new List<Employee>();
        LoadEmployees();
    }
    public void AddEmployee(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }
        Employees.Add(employee);
        SaveEmployees();
    }
    public void RemoveEmployee(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }
        Employees.Remove(employee);
        SaveEmployees();
    }
    public void UpdateVacation(Employee employee, DateTime? vacationStart, DateTime?
    vacationEnd)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }
        employee.VacationStart = vacationStart;
        employee.VacationEnd = vacationEnd;
        SaveEmployees();
    }
    private void SaveEmployees()
    {
        File.WriteAllLines("employees.txt", Employees.Select(e => $"{e.Name}|{e.Position}|{e.HireDate.ToString("yyyy-MM-dd")}|{e.VacationStart?.ToString("yyyy - MM - dd")}|{e.VacationEnd?.ToString("yyyy - MM - dd")}"));
}
private void LoadEmployees()
    {
        if (File.Exists("employees.txt"))
        {
            var lines = File.ReadAllLines("employees.txt");
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5)
                {
                    DateTime hireDate;
                    DateTime? vacationStart = null;
                    DateTime? vacationEnd = null;
                    if (DateTime.TryParse(parts[2], out hireDate))
                    {
                        if (parts[3] != "")
                        {
                            if (DateTime.TryParse(parts[3], out DateTime temp))
                            {
                                vacationStart = temp;
                            }
                        }
                        if (parts[4] != "")
                        {
                            if (DateTime.TryParse(parts[4], out DateTime temp))
                            {
                                vacationEnd = temp;
                            }
                        }
                        Employees.Add(new Employee(parts[0], parts[1], hireDate)
                        {
                            VacationStart = vacationStart,
                            VacationEnd = vacationEnd
                        });
                    }
                }
            }
        }
    }
}
public class EmployeeForm : Form
{
    private EmployeeManager employeeManager;
    private TextBox nameTextBox;
    private TextBox positionTextBox;
    private DateTimePicker hireDatePicker;
    private DateTimePicker vacationStartPicker;
    private DateTimePicker vacationEndPicker;
    private Button addEmployeeButton;
    private Button removeEmployeeButton;
    private Button updateVacationButton;
    private ListBox employeesListBox;
    public EmployeeForm()
    {
        this.Text = "Управление сотрудниками";
        this.Width = 600;
        this.Height = 500;
        nameTextBox = new TextBox
        {
            Location = new System.Drawing.Point(10, 10),
            Width = 150,
        };
        positionTextBox = new TextBox
        {
            Location = new System.Drawing.Point(170, 10),
            Width = 150,
        };
        hireDatePicker = new DateTimePicker
        {
            Location = new System.Drawing.Point(330, 10)
        };
        vacationStartPicker = new DateTimePicker
        {
            Location = new System.Drawing.Point(10, 40)
        };
        vacationEndPicker = new DateTimePicker
        {
            Location = new System.Drawing.Point(170, 40)
        };
        addEmployeeButton = new Button
        {
            Location = new System.Drawing.Point(10, 70),
            Text = "Добавить",
            Width = 100
        };
        addEmployeeButton.Click += AddEmployeeButton_Click;
        removeEmployeeButton = new Button
        {
            Location = new System.Drawing.Point(120, 70),
            Text = "Удалить",
            Width = 100
        };
        removeEmployeeButton.Click += RemoveEmployeeButton_Click;
        updateVacationButton = new Button
        {
            Location = new System.Drawing.Point(220, 70),
            Text = "Обновить отпуск",
            Width = 120
        };
        updateVacationButton.Click += UpdateVacationButton_Click;
        employeesListBox = new ListBox
        {
            Location = new System.Drawing.Point(10, 100),
            Width = 560,
            Height = 250
        };
        this.Controls.Add(nameTextBox);
        this.Controls.Add(positionTextBox);
        this.Controls.Add(hireDatePicker);
        this.Controls.Add(vacationStartPicker);
        this.Controls.Add(vacationEndPicker);
        this.Controls.Add(addEmployeeButton);
        this.Controls.Add(removeEmployeeButton);
        this.Controls.Add(updateVacationButton);
        this.Controls.Add(employeesListBox);
        employeeManager = new EmployeeManager();
        UpdateEmployeesList();
    }
    private void UpdateEmployeesList()
    {
        employeesListBox.Items.Clear();
        foreach (var employee in employeeManager.Employees)
        {
            string vacationStatus = employee.IsOnVacation ? "В отпуске" : "На работе";
            employeesListBox.Items.Add($"{employee.Name} - {employee.Position} ({ vacationStatus})");
        }
    }
    private void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(nameTextBox.Text) ||
        string.IsNullOrEmpty(positionTextBox.Text))
        {
            MessageBox.Show("Заполните все поля!");
            return;
        }
        DateTime hireDate = hireDatePicker.Value;
        Employee newEmployee = new Employee(nameTextBox.Text, positionTextBox.Text,
        hireDate);
        try
        {
            employeeManager.AddEmployee(newEmployee);
            nameTextBox.Clear();
            positionTextBox.Clear();
            UpdateEmployeesList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void RemoveEmployeeButton_Click(object sender, EventArgs e)
    {
        if (employeesListBox.SelectedIndex == -1)
        {
            MessageBox.Show("Выберите сотрудника для удаления!");
            return;
        }
        string selectedItem = employeesListBox.SelectedItem.ToString();
        string[] parts = selectedItem.Split(new[] { '-' }, StringSplitOptions.None);
        if (parts.Length >= 2)
        {
            string name = parts[0].Trim();
            string position = parts[1].Trim();
            var employeeToRemove = employeeManager.Employees.Find(emp => emp.Name == name && emp.Position == position);
            if (employeeToRemove != null)
            {
                try
                {
                    employeeManager.RemoveEmployee(employeeToRemove);
                    UpdateEmployeesList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    private void UpdateVacationButton_Click(object sender, EventArgs e)
    {
        if (employeesListBox.SelectedIndex == -1)
        {
            MessageBox.Show("Выберите сотрудника для обновления отпуска!");
            return;
        }
        string selectedItem = employeesListBox.SelectedItem.ToString();
        string[] parts = selectedItem.Split(new[] { '-' }, StringSplitOptions.None);
        if (parts.Length >= 2)
        {
            string name = parts[0].Trim();
            string position = parts[1].Trim();
            var employeeToUpdate = employeeManager.Employees.Find(emp => emp.Name == name && emp.Position == position);
            if (employeeToUpdate != null)
            {
                DateTime? vacationStart = vacationStartPicker.Value;
                DateTime? vacationEnd = vacationEndPicker.Value;
                if (vacationStart >= vacationEnd)
                {
                    MessageBox.Show("Дата начала должна быть раньше даты окончания!");
                    return;
                }
                try
                {
                    employeeManager.UpdateVacation(employeeToUpdate, vacationStart,
                    vacationEnd);
                    UpdateEmployeesList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new EmployeeForm());
    }
}