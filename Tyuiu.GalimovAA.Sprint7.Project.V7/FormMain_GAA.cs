using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint7.Project.V7.Lib;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    public partial class FormMain_GAA : Form
    {
        private DataService dataService;
        private const string DataFilePath = "apartments_data.csv";

        public FormMain_GAA()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataService = new DataService(DataFilePath);
            LoadData();
            UpdateStatistics();
        }

        private void InitializeDataGridView()
        {
            dataGridViewApartments_GAA.AutoGenerateColumns = false;
            dataGridViewApartments_GAA.Columns.Clear();

            dataGridViewApartments_GAA.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "Entrance", HeaderText = "Подъезд", DataPropertyName = "EntranceNumber" },
                new DataGridViewTextBoxColumn { Name = "Apartment", HeaderText = "Квартира", DataPropertyName = "ApartmentNumber" },
                new DataGridViewTextBoxColumn { Name = "TotalArea", HeaderText = "Общая площадь", DataPropertyName = "TotalArea" },
                new DataGridViewTextBoxColumn { Name = "LivingArea", HeaderText = "Жилая площадь", DataPropertyName = "LivingArea" },
                new DataGridViewTextBoxColumn { Name = "Rooms", HeaderText = "Комнаты", DataPropertyName = "RoomsCount" },
                new DataGridViewTextBoxColumn { Name = "Tenant", HeaderText = "Квартиросъёмщик", DataPropertyName = "TenantName" },
                new DataGridViewTextBoxColumn { Name = "Registration", HeaderText = "Дата прописки", DataPropertyName = "RegistrationDate" },
                new DataGridViewTextBoxColumn { Name = "Family", HeaderText = "Члены семьи", DataPropertyName = "FamilyMembers" },
                new DataGridViewTextBoxColumn { Name = "Children", HeaderText = "Дети", DataPropertyName = "ChildrenCount" },
                new DataGridViewCheckBoxColumn { Name = "Debt", HeaderText = "Долг", DataPropertyName = "HasDebt" },
                new DataGridViewTextBoxColumn { Name = "Notes", HeaderText = "Примечание", DataPropertyName = "Notes" }
            );
        }

        private void LoadData()
        {
            var apartments = dataService.GetAllApartments();
            dataGridViewApartments_GAA.DataSource = apartments;

            // Блокируем кнопки если нет данных
            bool hasData = apartments.Any();
            buttonEdit_GAA.Enabled = hasData;
            buttonDelete_GAA.Enabled = hasData;
            buttonFilterDebt_GAA.Enabled = hasData;
            buttonSort_GAA.Enabled = hasData;
            buttonChart_GAA.Enabled = hasData;
        }

        private void UpdateStatistics()
        {
            var stats = dataService.GetStatistics();
            labelTotalApartments_GAA.Text = $"Всего квартир: {stats["TotalApartments"]}";
            labelTotalArea_GAA.Text = $"Общая площадь: {stats["TotalArea"]:F1} м²";
            labelAverageArea_GAA.Text = $"Средняя площадь: {stats["AverageArea"]:F1} м²";
            labelDebtCount_GAA.Text = $"С долгом: {stats["DebtCount"]}";
            labelResidents_GAA.Text = $"Жителей: {stats["TotalResidents"]}";
        }

        private void buttonAdd_GAA_Click(object sender, EventArgs e)
        {
            var form = new FormEdit_GAA();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataService.AddApartment(form.Apartment);
                LoadData();
                UpdateStatistics();
            }
        }

        private void buttonEdit_GAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewApartments_GAA.SelectedRows.Count > 0)
            {
                int index = dataGridViewApartments_GAA.SelectedRows[0].Index;
                var apartments = dataService.GetAllApartments();

                if (index >= 0 && index < apartments.Count)
                {
                    var apartment = apartments[index];
                    var form = new FormEdit_GAA(apartment);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dataService.UpdateApartment(index, form.Apartment);
                        LoadData();
                        UpdateStatistics();
                    }
                }
            }
        }

        private void buttonDelete_GAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewApartments_GAA.SelectedRows.Count > 0)
            {
                int index = dataGridViewApartments_GAA.SelectedRows[0].Index;
                var apartments = dataService.GetAllApartments();

                if (index >= 0 && index < apartments.Count)
                {
                    dataService.DeleteApartment(index);
                    LoadData();
                    UpdateStatistics();
                }
            }
        }

        private void buttonSearch_GAA_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch_GAA.Text;
            var results = dataService.SearchApartments(searchTerm);
            dataGridViewApartments_GAA.DataSource = results;
        }

        private void buttonFilterDebt_GAA_Click(object sender, EventArgs e)
        {
            var results = dataService.FilterByDebt(true);
            dataGridViewApartments_GAA.DataSource = results;
        }

        private void buttonSort_GAA_Click(object sender, EventArgs e)
        {
            string field = comboBoxSort_GAA.SelectedItem?.ToString()?.ToLower() ?? "apartment";
            var results = dataService.SortBy(field);
            dataGridViewApartments_GAA.DataSource = results;
        }

        private void buttonChart_GAA_Click(object sender, EventArgs e)
        {
            var apartments = dataService.GetAllApartments();
            if (!apartments.Any())
            {
                MessageBox.Show("Нет данных для построения графика", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var form = new FormChart_GAA(apartments);
            form.ShowDialog();
        }

        private void buttonAbout_GAA_Click(object sender, EventArgs e)
        {
            var form = new FormAbout_GAA();
            form.ShowDialog();
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Домоуправление v1.0\n\n" +
                "Добавление: Создание новой записи о квартире\n" +
                "Редактирование: Изменение выбранной записи\n" +
                "Удаление: Удаление выбранной записи\n" +
                "Поиск: Поиск по номеру квартиры или фамилии\n" +
                "Фильтр: Показать квартиры с долгами\n" +
                "Сортировка: Упорядочить данные\n" +
                "График: Показать статистику на графике",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxSearch_GAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSearch_GAA_Click(sender, e);
                e.Handled = true;
            }
        }

        private void buttonReset_GAA_Click(object sender, EventArgs e)
        {
            textBoxSearch_GAA.Text = "";
            LoadData();
        }

        private void dataGridViewApartments_GAA_SelectionChanged(object sender, EventArgs e)
        {
            // Обновляем состояние кнопок при изменении выбора
            bool hasSelection = dataGridViewApartments_GAA.SelectedRows.Count > 0;
            buttonEdit_GAA.Enabled = hasSelection;
            buttonDelete_GAA.Enabled = hasSelection;
        }
    }
}