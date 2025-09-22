using System;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint7.Project.V7.Lib;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    public partial class FormEdit_GAA : Form
    {
        public DataService.Apartment Apartment { get; private set; }

        public FormEdit_GAA()
        {
            InitializeComponent();
            Apartment = new DataService.Apartment
            {
                RegistrationDate = DateTime.Today
            };
        }

        public FormEdit_GAA(DataService.Apartment apartment)
        {
            InitializeComponent();
            Apartment = apartment;
            LoadData();
        }

        private void LoadData()
        {
            numericUpDownEntrance_GAA.Value = Apartment.EntranceNumber;
            numericUpDownApartment_GAA.Value = Apartment.ApartmentNumber;
            numericUpDownTotalArea_GAA.Value = (decimal)Apartment.TotalArea;
            numericUpDownLivingArea_GAA.Value = (decimal)Apartment.LivingArea;
            numericUpDownRooms_GAA.Value = Apartment.RoomsCount;
            textBoxTenant_GAA.Text = Apartment.TenantName;
            dateTimePickerRegistration_GAA.Value = Apartment.RegistrationDate;
            numericUpDownFamily_GAA.Value = Apartment.FamilyMembers;
            numericUpDownChildren_GAA.Value = Apartment.ChildrenCount;
            checkBoxDebt_GAA.Checked = Apartment.HasDebt;
            textBoxNotes_GAA.Text = Apartment.Notes;
        }

        private void buttonSave_GAA_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Apartment = new DataService.Apartment
                {
                    EntranceNumber = (int)numericUpDownEntrance_GAA.Value,
                    ApartmentNumber = (int)numericUpDownApartment_GAA.Value,
                    TotalArea = (double)numericUpDownTotalArea_GAA.Value,
                    LivingArea = (double)numericUpDownLivingArea_GAA.Value,
                    RoomsCount = (int)numericUpDownRooms_GAA.Value,
                    TenantName = textBoxTenant_GAA.Text,
                    RegistrationDate = dateTimePickerRegistration_GAA.Value,
                    FamilyMembers = (int)numericUpDownFamily_GAA.Value,
                    ChildrenCount = (int)numericUpDownChildren_GAA.Value,
                    HasDebt = checkBoxDebt_GAA.Checked,
                    Notes = textBoxNotes_GAA.Text
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxTenant_GAA.Text))
            {
                MessageBox.Show("Введите фамилию квартиросъёмщика");
                return false;
            }
            return true;
        }

        private void buttonCancel_GAA_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}