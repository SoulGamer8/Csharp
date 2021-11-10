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

            else if(!(int.TryParse(StudentLimittBox.Text, out test)))
                MessageBox.Show("Student Limitt must be number");
            else
            {
                EventSaveTeacher?.Invoke(NameBox.Text, SurnameBox.Text, Convert.ToInt32(AgeBox.Text), SexBox.Text, CountryBox.Text, DistrictBox.Text, CityBox4.Text, StreetBox.Text, HousenumberBox.Text, Convert.ToInt32(StudentLimittBox.Text));
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
