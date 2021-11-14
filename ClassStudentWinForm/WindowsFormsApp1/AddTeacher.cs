using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddTeacher : Form
    {
        public delegate void SaveSTeacher(string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber,int studentLimit);
        public static event SaveSTeacher EventSaveTeacher;

        public AddTeacher()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int test;
            if (!(int.TryParse(AgeBox.Text, out test)))
                MessageBox.Show("Age must be number");
            else if (Convert.ToInt32(StudentLimittBox.Text) <= 0)
                MessageBox.Show("Student limitt be greater than or equal to 0");
            else if (Convert.ToInt32(AgeBox.Text) < 0)
                MessageBox.Show("Age Must be greater than 0");
            else if(!(int.TryParse(StudentLimittBox.Text, out test)))
                MessageBox.Show("Student Limitt must be number");
            else
            {
                EventSaveTeacher?.Invoke(NameBox.Text, SurnameBox.Text, Convert.ToInt32(AgeBox.Text), SexBox.Text, CountryBox.Text, DistrictBox.Text, CityBox4.Text, StreetBox.Text, HousenumberBox.Text, Convert.ToInt32(StudentLimittBox.Text));
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void SetButtonEnabled()
        {
            foreach (Control control in Controls)
            {
                if (string.IsNullOrEmpty(errorProvider1.GetError(control))) continue;
                button2.Enabled = false;
                return;
            }
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NameBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(NameBox, "Заполните поле!");
            else
                errorProvider1.SetError(NameBox, string.Empty);
            SetButtonEnabled();
        }

        private void SurnameBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(SurnameBox, "Заполните поле!");
            else
                errorProvider1.SetError(SurnameBox, string.Empty);
            SetButtonEnabled();
        }

        private void AgeBox_Validated(object sender, EventArgs e)
        {
            int age;
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(AgeBox, "Заполните поле!");
            else if (!(int.TryParse(AgeBox.Text, out age)))
                errorProvider1.SetError(AgeBox, "Age must be number");
            else if (Convert.ToInt32(AgeBox.Text) < 0)
                errorProvider1.SetError(AgeBox, ">0!");
            else
                errorProvider1.SetError(AgeBox, string.Empty);
            SetButtonEnabled();
        }

        private void SexBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(SexBox, "Заполните поле!");
            else
                errorProvider1.SetError(SexBox, string.Empty);
            SetButtonEnabled();
        }

        private void StudentLimittBox_Validated(object sender, EventArgs e)
        {
            int studentLimit;
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(StudentLimittBox, "Заполните поле!");
            else if (!(int.TryParse(StudentLimittBox.Text, out studentLimit)))
                errorProvider1.SetError(StudentLimittBox, "Age must be number");
            else if (Convert.ToInt32(StudentLimittBox.Text) < 0)
                errorProvider1.SetError(StudentLimittBox, ">0!");
            else
                errorProvider1.SetError(StudentLimittBox, string.Empty);
            SetButtonEnabled();
        }

        private void CountryBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(CountryBox, "Заполните поле!");
            else
                errorProvider1.SetError(CountryBox, string.Empty);
            SetButtonEnabled();
        }

        private void DistrictBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(DistrictBox, "Заполните поле!");
            else
                errorProvider1.SetError(DistrictBox, string.Empty);
            SetButtonEnabled();
        }

        private void CityBox4_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(CityBox4, "Заполните поле!");
            else
                errorProvider1.SetError(CityBox4, string.Empty);
            SetButtonEnabled();
        }

        private void StreetBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(StreetBox, "Заполните поле!");
            else
                errorProvider1.SetError(StreetBox, string.Empty);
            SetButtonEnabled();
        }

        private void HousenumberBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(HousenumberBox, "Заполните поле!");
            else
                errorProvider1.SetError(HousenumberBox, string.Empty);
            SetButtonEnabled();
        }
    }
}
