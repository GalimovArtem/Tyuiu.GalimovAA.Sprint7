using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint7.Project.V7.Lib;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    public partial class FormChart_GAA : Form
    {
        private List<DataService.Apartment> apartments;

        public FormChart_GAA(List<DataService.Apartment> apartments)
        {
            InitializeComponent();
            this.apartments = apartments;
            InitializeChartData();
        }

        private void InitializeChartData()
        {
            // Очищаем панель
            panelChart_GAA.Controls.Clear();

            // Получаем данные по подъездам
            var dataService = new DataService("apartments_data.csv");
            var entranceData = dataService.GetApartmentsByEntrance();

            if (entranceData.Count == 0)
            {
                var label = new Label
                {
                    Text = "Нет данных для отображения",
                    AutoSize = true,
                    Location = new Point(20, 20),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red
                };
                panelChart_GAA.Controls.Add(label);
                return;
            }

            int maxValue = entranceData.Values.Max();
            int panelWidth = panelChart_GAA.Width - 40;
            int panelHeight = panelChart_GAA.Height - 60;
            int barWidth = Math.Max(30, (panelWidth - 20) / entranceData.Count);
            int spacing = 10;

            int x = 20;
            foreach (var item in entranceData)
            {
                int barHeight = (int)((item.Value / (double)maxValue) * (panelHeight - 40));

                // Столбец
                var bar = new Panel
                {
                    BackColor = Color.SteelBlue,
                    Location = new Point(x, panelHeight - barHeight),
                    Size = new Size(barWidth - spacing, barHeight),
                    BorderStyle = BorderStyle.FixedSingle
                };
                panelChart_GAA.Controls.Add(bar);

                // Подпись значения
                var valueLabel = new Label
                {
                    Text = item.Value.ToString(),
                    AutoSize = true,
                    Location = new Point(x + (barWidth - spacing) / 2 - 10, panelHeight - barHeight - 20),
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 8, FontStyle.Bold)
                };
                panelChart_GAA.Controls.Add(valueLabel);

                // Подпись подъезда
                var entranceLabel = new Label
                {
                    Text = $"Подъезд {item.Key}",
                    AutoSize = true,
                    Location = new Point(x + (barWidth - spacing) / 2 - 20, panelHeight + 5),
                    ForeColor = Color.Black
                };
                panelChart_GAA.Controls.Add(entranceLabel);

                x += barWidth;
            }

            // Заголовок
            var titleLabel = new Label
            {
                Text = "Распределение квартир по подъездам",
                AutoSize = true,
                Location = new Point(20, 10),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkBlue
            };
            panelChart_GAA.Controls.Add(titleLabel);
        }

        private void buttonClose_GAA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelChart_GAA_Resize(object sender, EventArgs e)
        {
            InitializeChartData();
        }
    }
}