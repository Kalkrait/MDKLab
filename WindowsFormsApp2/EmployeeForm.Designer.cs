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
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.hireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.vacationStartLabel = new System.Windows.Forms.Label();
            this.vacationEndLabel = new System.Windows.Forms.Label();
            this.vacationStartPicker = new System.Windows.Forms.DateTimePicker();
            this.vacationEndPicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateVacationButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.notifyButton = new System.Windows.Forms.Button();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.vacationGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainGroupBox.SuspendLayout();
            this.vacationGroupBox.SuspendLayout();
            this.buttonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameLabel.Location = new System.Drawing.Point(15, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя сотрудника:";
            // 
            // positionLabel
            // 
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.positionLabel.Location = new System.Drawing.Point(15, 58);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(100, 20);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "Должность:";
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hireDateLabel.Location = new System.Drawing.Point(15, 88);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(100, 20);
            this.hireDateLabel.TabIndex = 4;
            this.hireDateLabel.Text = "Дата приёма:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(120, 55);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(230, 25);
            this.positionTextBox.TabIndex = 3;
            // 
            // hireDatePicker
            // 
            this.hireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hireDatePicker.Location = new System.Drawing.Point(120, 85);
            this.hireDatePicker.Name = "hireDatePicker";
            this.hireDatePicker.Size = new System.Drawing.Size(150, 25);
            this.hireDatePicker.TabIndex = 5;
            this.hireDatePicker.Value = new System.DateTime(2026, 6, 7, 0, 0, 0, 0);
            // 
            // vacationStartLabel
            // 
            this.vacationStartLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacationStartLabel.Location = new System.Drawing.Point(15, 28);
            this.vacationStartLabel.Name = "vacationStartLabel";
            this.vacationStartLabel.Size = new System.Drawing.Size(100, 20);
            this.vacationStartLabel.TabIndex = 0;
            this.vacationStartLabel.Text = "Начало отпуска:";
            // 
            // vacationEndLabel
            // 
            this.vacationEndLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacationEndLabel.Location = new System.Drawing.Point(15, 58);
            this.vacationEndLabel.Name = "vacationEndLabel";
            this.vacationEndLabel.Size = new System.Drawing.Size(100, 20);
            this.vacationEndLabel.TabIndex = 2;
            this.vacationEndLabel.Text = "Конец отпуска:";
            // 
            // vacationStartPicker
            // 
            this.vacationStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vacationStartPicker.Location = new System.Drawing.Point(120, 25);
            this.vacationStartPicker.Name = "vacationStartPicker";
            this.vacationStartPicker.Size = new System.Drawing.Size(150, 25);
            this.vacationStartPicker.TabIndex = 1;
            this.vacationStartPicker.Value = new System.DateTime(2026, 6, 7, 0, 0, 0, 0);
            // 
            // vacationEndPicker
            // 
            this.vacationEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vacationEndPicker.Location = new System.Drawing.Point(120, 55);
            this.vacationEndPicker.Name = "vacationEndPicker";
            this.vacationEndPicker.Size = new System.Drawing.Size(150, 25);
            this.vacationEndPicker.TabIndex = 3;
            this.vacationEndPicker.Value = new System.DateTime(2026, 6, 21, 0, 0, 0, 0);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(10, 25);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(350, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(10, 68);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(350, 35);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить сотрудника";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // updateVacationButton
            // 
            this.updateVacationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.updateVacationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateVacationButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.updateVacationButton.ForeColor = System.Drawing.Color.White;
            this.updateVacationButton.Location = new System.Drawing.Point(10, 111);
            this.updateVacationButton.Name = "updateVacationButton";
            this.updateVacationButton.Size = new System.Drawing.Size(350, 35);
            this.updateVacationButton.TabIndex = 2;
            this.updateVacationButton.Text = "Обновить отпуск";
            this.updateVacationButton.UseVisualStyleBackColor = false;
            this.updateVacationButton.Click += new System.EventHandler(this.UpdateVacationButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(10, 154);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить в файл";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(190, 154);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(170, 35);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Загрузить из файла";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // notifyButton
            // 
            this.notifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.notifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.notifyButton.ForeColor = System.Drawing.Color.Black;
            this.notifyButton.Location = new System.Drawing.Point(10, 195);
            this.notifyButton.Name = "notifyButton";
            this.notifyButton.Size = new System.Drawing.Size(350, 35);
            this.notifyButton.TabIndex = 5;
            this.notifyButton.Text = "🔔 Проверить уведомления об отпусках";
            this.notifyButton.UseVisualStyleBackColor = false;
            this.notifyButton.Click += new System.EventHandler(this.NotifyButton_Click);
            // 
            // employeesListBox
            // 
            this.employeesListBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.employeesListBox.ItemHeight = 15;
            this.employeesListBox.Location = new System.Drawing.Point(400, 12);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(380, 439);
            this.employeesListBox.TabIndex = 3;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.nameLabel);
            this.mainGroupBox.Controls.Add(this.nameTextBox);
            this.mainGroupBox.Controls.Add(this.positionLabel);
            this.mainGroupBox.Controls.Add(this.positionTextBox);
            this.mainGroupBox.Controls.Add(this.hireDateLabel);
            this.mainGroupBox.Controls.Add(this.hireDatePicker);
            this.mainGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(370, 130);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Основная информация";
            // 
            // vacationGroupBox
            // 
            this.vacationGroupBox.Controls.Add(this.vacationStartLabel);
            this.vacationGroupBox.Controls.Add(this.vacationStartPicker);
            this.vacationGroupBox.Controls.Add(this.vacationEndLabel);
            this.vacationGroupBox.Controls.Add(this.vacationEndPicker);
            this.vacationGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.vacationGroupBox.Location = new System.Drawing.Point(12, 150);
            this.vacationGroupBox.Name = "vacationGroupBox";
            this.vacationGroupBox.Size = new System.Drawing.Size(370, 95);
            this.vacationGroupBox.TabIndex = 1;
            this.vacationGroupBox.TabStop = false;
            this.vacationGroupBox.Text = "Управление отпуском";
            // 
            // buttonsGroupBox
            // 
            this.buttonsGroupBox.Controls.Add(this.addButton);
            this.buttonsGroupBox.Controls.Add(this.removeButton);
            this.buttonsGroupBox.Controls.Add(this.updateVacationButton);
            this.buttonsGroupBox.Controls.Add(this.saveButton);
            this.buttonsGroupBox.Controls.Add(this.loadButton);
            this.buttonsGroupBox.Controls.Add(this.notifyButton);
            this.buttonsGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonsGroupBox.Location = new System.Drawing.Point(12, 255);
            this.buttonsGroupBox.Name = "buttonsGroupBox";
            this.buttonsGroupBox.Size = new System.Drawing.Size(370, 252);
            this.buttonsGroupBox.TabIndex = 2;
            this.buttonsGroupBox.TabStop = false;
            this.buttonsGroupBox.Text = "Действия";
            // 
            // EMPform
            // 
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.buttonsGroupBox);
            this.Controls.Add(this.vacationGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EMPform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление сотрудниками";
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.vacationGroupBox.ResumeLayout(false);
            this.buttonsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Поля
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.DateTimePicker hireDatePicker;

        private System.Windows.Forms.Label vacationStartLabel;
        private System.Windows.Forms.Label vacationEndLabel;
        private System.Windows.Forms.DateTimePicker vacationStartPicker;
        private System.Windows.Forms.DateTimePicker vacationEndPicker;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateVacationButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button notifyButton;  // ← ДОБАВЛЕНО

        private System.Windows.Forms.ListBox employeesListBox;

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox vacationGroupBox;
        private System.Windows.Forms.GroupBox buttonsGroupBox;
    }
}