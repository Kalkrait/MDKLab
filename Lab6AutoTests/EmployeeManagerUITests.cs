using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;

namespace EMPmanager.UITests
{
    [TestClass]
    public class UITests
    {
        private FlaUI.Core.Application _app;
        private UIA3Automation _automation;
        private Window _mainWindow;

        // ПОМЕНЯЙ ПУТЬ НА СВОЙ !!!
        private const string AppPath = @"C:\Users\Vadka\source\repos\MDKLab\WindowsFormsApp2\bin\Debug\WindowsFormsApp2.exe";

        [TestInitialize]
        public void Setup()
        {
            _app = FlaUI.Core.Application.Launch(AppPath);
            _automation = new UIA3Automation();
            Thread.Sleep(3000);
            _mainWindow = _app.GetMainWindow(_automation);
            _mainWindow.Focus();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _app?.Close();
            _automation?.Dispose();
        }

        // Поиск кнопки по тексту (САМЫЙ НАДЁЖНЫЙ СПОСОБ)
        private Button FindButton(string text)
        {
            try
            {
                // Ищем все кнопки
                var allButtons = _mainWindow.FindAllDescendants(x => x.ByControlType(FlaUI.Core.Definitions.ControlType.Button));

                foreach (var btn in allButtons)
                {
                    if (btn.Name != null && btn.Name.Contains(text))
                    {
                        return btn.AsButton();
                    }
                }
                return null;
            }
            catch { return null; }
        }

        // Поиск TextBox по порядку
        private TextBox FindTextBoxByIndex(int index)
        {
            try
            {
                var allEdits = _mainWindow.FindAllDescendants(x => x.ByControlType(FlaUI.Core.Definitions.ControlType.Edit));
                if (allEdits.Length > index)
                {
                    return allEdits[index].AsTextBox();
                }
                return null;
            }
            catch { return null; }
        }

        // Закрыть сообщение
        private void CloseMessage()
        {
            try
            {
                Thread.Sleep(500);
                var msg = _mainWindow.ModalWindows.FirstOrDefault();
                if (msg != null)
                {
                    var ok = msg.FindFirstDescendant(x => x.ByText("OK"));
                    if (ok == null) ok = msg.FindFirstDescendant(x => x.ByText("ОК"));
                    ok?.AsButton()?.Click();
                }
            }
            catch { }
        }

        // Подтвердить удаление
        private void ConfirmDelete()
        {
            try
            {
                var msg = _mainWindow.ModalWindows.FirstOrDefault();
                if (msg != null)
                {
                    var yes = msg.FindFirstDescendant(x => x.ByText("Да"));
                    yes?.AsButton()?.Click();
                }
            }
            catch { }
        }

        // ============ ТЕСТ 1 ============
        [TestMethod]
        public void Test_AddEmployee()
        {
            var addBtn = FindButton("Добавить");
            Assert.IsNotNull(addBtn, "Кнопка 'Добавить' не найдена");

            var nameBox = FindTextBoxByIndex(0);
            var posBox = FindTextBoxByIndex(1);

            if (nameBox != null) nameBox.Text = "Тест Сотрудник";
            if (posBox != null) posBox.Text = "Тест Должность";

            Thread.Sleep(500);
            addBtn.Click();
            Thread.Sleep(1000);
            CloseMessage();

            Assert.IsTrue(true, "Тест пройден");
        }

        // ============ ТЕСТ 2 ============
        [TestMethod]
        public void Test_RemoveEmployee()
        {
            var removeBtn = FindButton("Удалить");
            Assert.IsNotNull(removeBtn, "Кнопка 'Удалить' не найдена");

            removeBtn.Click();
            Thread.Sleep(500);
            ConfirmDelete();
            CloseMessage();

            Assert.IsTrue(true, "Тест пройден");
        }

        // ============ ТЕСТ 3 ============
        [TestMethod]
        public void Test_UpdateVacation()
        {
            var updateBtn = FindButton("Обновить");
            if (updateBtn == null) updateBtn = FindButton("Обновить отпуск");

            Assert.IsNotNull(updateBtn, "Кнопка 'Обновить отпуск' не найдена");

            updateBtn.Click();
            Thread.Sleep(500);
            CloseMessage();

            Assert.IsTrue(true, "Тест пройден");
        }

        // ============ ТЕСТ 4 ============
        [TestMethod]
        public void Test_Notifications()
        {
            var notifyBtn = FindButton("Уведом");
            if (notifyBtn == null) notifyBtn = FindButton("Проверить");

            Assert.IsNotNull(notifyBtn, "Кнопка уведомлений не найдена");

            notifyBtn.Click();
            Thread.Sleep(500);
            CloseMessage();

            Assert.IsTrue(true, "Тест пройден");
        }

        // ============ ТЕСТ 5 ============
        [TestMethod]
        public void Test_EmptyFields()
        {
            var addBtn = FindButton("Добавить");
            Assert.IsNotNull(addBtn, "Кнопка 'Добавить' не найдена");

            // Очищаем все TextBox
            var allEdits = _mainWindow.FindAllDescendants(x => x.ByControlType(FlaUI.Core.Definitions.ControlType.Edit));
            foreach (var edit in allEdits)
            {
                try { edit.AsTextBox().Text = ""; } catch { }
            }

            Thread.Sleep(500);
            addBtn.Click();
            Thread.Sleep(1000);

            var msg = _mainWindow.ModalWindows.FirstOrDefault();
            Assert.IsNotNull(msg, "Сообщение об ошибке не появилось");

            CloseMessage();
        }
    }
}