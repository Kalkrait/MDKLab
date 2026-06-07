namespace EMPmanager
{
    partial class EMPform
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Группа: Основная информация
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.hireDatePicker = new System.Windows.Forms.DateTimePicker();

            // Группа: Управление отпуском
            this.vacationGroupBox = new System.Windows.Forms.GroupBox();
            this.vacationStartLabel = new System.Windows.Forms.Label();
            this.vacationStartPicker = new System.Windows.Forms.DateTimePicker();
            this.vacationEndLabel = new System.Windows.Forms.Label();
            this.vacationEndPicker = new System.Windows.Forms.DateTimePicker();

            // Кнопки
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateVacationButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.notifyButton = new System.Windows.Forms.Button();

            // Список сотрудников
            this.employeesListBox = new System.Windows.Forms.ListBox();

            // Статус
            this.statusLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();

            // Панели
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();

            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.nameLabel);
            this.mainGroupBox.Controls.Add(this.nameTextBox);
            this.mainGroupBox.Controls.Add(this.positionLabel);
            this.mainGroupBox.Controls.Add(this.positionTextBox);
            this.mainGroupBox.Controls.Add(this.hireDateLabel);
            this.mainGroupBox.Controls.Add(this.hireDatePicker);
            this.mainGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(370, 125);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Основная информация";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameLabel.Location = new System.Drawing.Point(15, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя сотрудника:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(120, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.positionLabel.Location = new System.Drawing.Point(15, 58);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(68, 15);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "Должность:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.positionTextBox.Location = new System.Drawing.Point(120, 55);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(230, 23);
            this.positionTextBox.TabIndex = 3;
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hireDateLabel.Location = new System.Drawing.Point(15, 88);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(78, 15);
            this.hireDateLabel.TabIndex = 4;
            this.hireDateLabel.Text = "Дата приёма:";
            // 
            // hireDatePicker
            // 
            this.hireDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hireDatePicker.Location = new System.Drawing.Point(120, 85);
            this.hireDatePicker.Name = "hireDatePicker";
            this.hireDatePicker.Size = new System.Drawing.Size(150, 23);
            this.hireDatePicker.TabIndex = 5;
            this.hireDatePicker.Value = System.DateTime.Today;
            // 
            // vacationGroupBox
            // 
            this.vacationGroupBox.Controls.Add(this.vacationStartLabel);
            this.vacationGroupBox.Controls.Add(this.vacationStartPicker);
            this.vacationGroupBox.Controls.Add(this.vacationEndLabel);
            this.vacationGroupBox.Controls.Add(this.vacationEndPicker);
            this.vacationGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vacationGroupBox.Location = new System.Drawing.Point(12, 145);
            this.vacationGroupBox.Name = "vacationGroupBox";
            this.vacationGroupBox.Size = new System.Drawing.Size(370, 95);
            this.vacationGroupBox.TabIndex = 1;
            this.vacationGroupBox.TabStop = false;
            this.vacationGroupBox.Text = "Управление отпуском";
            // 
            // vacationStartLabel
            // 
            this.vacationStartLabel.AutoSize = true;
            this.vacationStartLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacationStartLabel.Location = new System.Drawing.Point(15, 28);
            this.vacationStartLabel.Name = "vacationStartLabel";
            this.vacationStartLabel.Size = new System.Drawing.Size(88, 15);
            this.vacationStartLabel.TabIndex = 0;
            this.vacationStartLabel.Text = "Начало отпуска:";
            // 
            // vacationStartPicker
            // 
            this.vacationStartPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacationStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vacationStartPicker.Location = new System.Drawing.Point(120, 25);
            this.vacationStartPicker.Name = "vacationStartPicker";
            this.vacationStartPicker.Size = new System.Drawing.Size(150, 23);
            this.vacationStartPicker.TabIndex = 1;
            this.vacationStartPicker.Value = System.DateTime.Today;
            // 
            // vacationEndLabel
            // 
            this.vacationEndLabel.AutoSize = true;
            this.vacationEndLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacationEndLabel.Location = new System.Drawing.Point(15, 58);
            this.vacationEndLabel.Name = "vacationEndLabel";
            this.vacationEndLabel.Size = new System.Drawing.Size(84, 15);
            this.vacationEndLabel.TabIndex = 2;
            this.vacationEndLabel.Text = "Конец отпуска:";
            // 
            // vacationEndPicker
            // 
            this.vacationEndPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacationEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vacationEndPicker.Location = new System.Drawing.Point(120, 55);
            this.vacationEndPicker.Name = "vacationEndPicker";
            this.vacationEndPicker.Size = new System.Drawing.Size(150, 23);
            this.vacationEndPicker.TabIndex = 3;
            this.vacationEndPicker.Value = System.DateTime.Today.AddDays(14);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.addButton);
            this.buttonsPanel.Controls.Add(this.removeButton);
            this.buttonsPanel.Controls.Add(this.updateVacationButton);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 248);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(370, 130);
            this.buttonsPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(10, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(350, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "➕ Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(10, 48);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(350, 32);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "🗑️ Удалить сотрудника";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // updateVacationButton
            // 
            this.updateVacationButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.updateVacationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateVacationButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.updateVacationButton.ForeColor = System.Drawing.Color.White;
            this.updateVacationButton.Location = new System.Drawing.Point(10, 86);
            this.updateVacationButton.Name = "updateVacationButton";
            this.updateVacationButton.Size = new System.Drawing.Size(350, 32);
            this.updateVacationButton.TabIndex = 2;
            this.updateVacationButton.Text = "📅 Обновить отпуск";
            this.updateVacationButton.UseVisualStyleBackColor = false;
            this.updateVacationButton.Click += new System.EventHandler(this.UpdateVacationButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.saveButton);
            this.bottomPanel.Controls.Add(this.loadButton);
            this.bottomPanel.Controls.Add(this.notifyButton);
            this.bottomPanel.Location = new System.Drawing.Point(12, 384);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(370, 115);
            this.bottomPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(10, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(350, 32);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "💾 Сохранить в файл";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(10, 44);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(350, 32);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "📂 Загрузить из файла";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // notifyButton
            // 
            this.notifyButton.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.notifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.notifyButton.ForeColor = System.Drawing.Color.White;
            this.notifyButton.Location = new System.Drawing.Point(10, 82);
            this.notifyButton.Name = "notifyButton";
            this.notifyButton.Size = new System.Drawing.Size(350, 32);
            this.notifyButton.TabIndex = 2;
            this.notifyButton.Text = "🔔 Проверить уведомления об отпусках";
            this.notifyButton.UseVisualStyleBackColor = false;
            this.notifyButton.Click += new System.EventHandler(this.NotifyButton_Click);
            // 
            // employeesListBox
            // 
            this.employeesListBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 15;
            this.employeesListBox.Location = new System.Drawing.Point(400, 12);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(380, 484);
            this.employeesListBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(12, 515);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 15);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Готов к работе";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countLabel.ForeColor = System.Drawing.Color.Black;
            this.countLabel.Location = new System.Drawing.Point(680, 515);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(80, 15);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Сотрудников: 0";
            // 
            // EMPform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.vacationGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EMPform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление сотрудниками - Кадровый учёт";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Поля компонентов
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.DateTimePicker hireDatePicker;

        private System.Windows.Forms.GroupBox vacationGroupBox;
        private System.Windows.Forms.Label vacationStartLabel;
        private System.Windows.Forms.DateTimePicker vacationStartPicker;
        private System.Windows.Forms.Label vacationEndLabel;
        private System.Windows.Forms.DateTimePicker vacationEndPicker;

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateVacationButton;

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button notifyButton;

        private System.Windows.Forms.ListBox employeesListBox;

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label countLabel;
    }
}