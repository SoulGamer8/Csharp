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
            int test;
            string[] words = comboBox2.Text.Split(' ');
            int numberTeacher = _teacherList.FindTeacher(words[0], words[1]);

            if (!(int.TryParse(AgeBox.Text, out test)))
            {
                MessageBox.Show("Age must be number");
            }
            /*else if(_teacherList.TeachersLst[numberTeacher].LimitStudentList == _teacherList.TeachersLst[numberTeacher].StudentsList.Count)
            {
                MessageBox.Show("Limit ");
            }*/
            else
            {
                EventSaveStudent?.Invoke(NameBox.Text, SurnameBox.Text, Convert.ToInt32(AgeBox.Text), SexBox.Text, CountryBox.Text, DistrictBox.Text, CityBox4.Text, StreetBox.Text, HousenumberBox.Text, comboBox2.Text,comboBox1.Text);
                this.DialogResult = DialogResult.Cancel;
            }
        }

    }
}
