using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PhotoUser : Form
    {
        private string _name;
        private string _surname;
        private string _path;
        private bool _isTeacher;
        public PhotoUser(string name,string surname,string path,bool isTeacher)
        {
            InitializeComponent();
            _name = name;
            _surname = surname;
            _path= path;
            _isTeacher=isTeacher;

        }

        private void PhotoUser_Load(object sender, EventArgs e)
        {
            if (_isTeacher)
            {
                label4.Text = "Teacher";
            }
            else
            {
                label4.Text = "Student";
            }
            label1.Text = "Name: " + _name;
            label2.Text = "Surname: " + _surname;
            pictureBox1.ImageLocation = _path;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
