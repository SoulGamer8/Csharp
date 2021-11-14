using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudent : Form
    {
        public delegate void SaveStudent(string name, string surname, int age, string sex, string country,string district,string city ,string street ,string housenumber, string teacher, string mark);
        public static event SaveStudent EventSaveStudent;


        private TeacherList _teacherList;
        public AddStudent(TeacherList teacherList)
        {
            _teacherList = teacherList;
            InitializeComponent();
            InitialComboBox();
            InitialComboBoxTeacher();

        }

        private void InitialComboBox()
        {
            comboBox1.Items.Add(Marks.A);
            comboBox1.Items.Add(Marks.B);
            comboBox1.Items.Add(Marks.C);
            comboBox1.Items.Add(Marks.D);
            comboBox1.Items.Add(Marks.F);
        }
        private void InitialComboBoxTeacher()
        {
            foreach (Teacher teacher in _teacherList.TeachersLst)
            {
                if (teacher.LimitStudentList == teacher.StudentsList.Count)
                    continue;
                else
                    comboBox2.Items.Add(teacher.Surname + " " + teacher.Name);
            }
   
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] words = comboBox2.Text.Split(' ');
            int numberTeacher = _teacherList.FindTeacher(words[0], words[1]);
            EventSaveStudent?.Invoke(NameBox.Text, SurnameBox.Text, Convert.ToInt32(AgeBox.Text), SexBox.Text, CountryBox.Text, DistrictBox.Text, CityBox4.Text, StreetBox.Text, HousenumberBox.Text, comboBox2.Text, comboBox1.Text);
            this.DialogResult = DialogResult.Cancel;
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
            int temp;
            if (string.IsNullOrEmpty((sender as TextBox).Text))
                errorProvider1.SetError(AgeBox, "Заполните поле!");
            else if (!(int.TryParse(AgeBox.Text, out temp)))
                errorProvider1.SetError(AgeBox, "Age must be number");
            else if(Convert.ToInt32(AgeBox.Text) < 0)
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

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox1, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox1, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.SetError(comboBox1, string.Empty);
            }
            SetButtonEnabled();
        }

        private void comboBox2_Validated(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox2, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox2, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.SetError(comboBox1, string.Empty);
            }
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
