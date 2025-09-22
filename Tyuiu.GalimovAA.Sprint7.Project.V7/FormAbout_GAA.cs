using System;
using System.Windows.Forms;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    public partial class FormAbout_GAA : Form
    {
        public FormAbout_GAA()
        {
            InitializeComponent();
            LoadAuthorInfo();
        }

        private void LoadAuthorInfo()
        {
            // Устанавливаем информацию о программе
            labelTitle_GAA.Text = "Домоуправление";
            labelVersion_GAA.Text = "Версия: 1.0.0";
            labelAuthor_GAA.Text = "Автор: Галимов Артём Азатович";
            labelDescription_GAA.Text = "Приложение для управления данными о квартирах в многоквартирном доме. " +
                                      "Включает функции добавления, редактирования, поиска и анализа данных.";

         
        }

        private void buttonOk_GAA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxAuthor_GAA_Click(object sender, EventArgs e)
        {

        }

        private void labelAuthor_GAA_Click(object sender, EventArgs e)
        {

        }
    }
}