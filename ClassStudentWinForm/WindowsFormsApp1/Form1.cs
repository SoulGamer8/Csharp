using System;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private TeacherList teacherList = new TeacherList();
        
        private int _numberTeacher;

        private DataTable dataTable = new DataTable();

        DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
        public Main()
        {
            InitializeComponent();
            InitialGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cheack();
            AddStudent.EventSaveStudent += AddStudentInList;
            AddTeacher.EventSaveTeacher += AddTeacherInList;
        }


        private void Cheack()
        {
            if (teacherList.TeachersLst.Capacity == 0)
                addNewStudentToolStripMenuItem.Enabled = false;
            else
                addNewStudentToolStripMenuItem.Enabled = true;
        }

        private void InitialTree()
        {
            treeView2.Nodes.Clear();


            TreeNode noderoot = new TreeNode();

            noderoot.Text = "Name";



            int i = 0;
            foreach (Teacher teacher in teacherList.TeachersLst)
            {
                treeView2.Nodes.Add(teacher.Surname);
                treeView2.Nodes[i].Nodes.Add(teacher.Name);
                treeView2.Nodes[i].Nodes.Add(Convert.ToString(teacher.Age));
                treeView2.Nodes[i].Nodes.Add(teacher.Sex);
                treeView2.Nodes[i].Nodes.Add("Address");
                treeView2.Nodes[i].Nodes[3].Nodes.Add(teacher.Address.Country);
                treeView2.Nodes[i].Nodes[3].Nodes.Add(teacher.Address.District);
                treeView2.Nodes[i].Nodes[3].Nodes.Add(teacher.Address.City);
                treeView2.Nodes[i].Nodes[3].Nodes.Add(teacher.Address.Street);
                treeView2.Nodes[i].Nodes[3].Nodes.Add(teacher.Address.Housenumber);
                treeView2.Nodes[i].Nodes.Add("Student");
                foreach (Student student in teacher.StudentsList)
                {
                    treeView2.Nodes[i].Nodes[4].Nodes.Add(student.Name);
                    treeView2.Nodes[i].Nodes[4].Nodes.Add(student.Surname);
                    treeView2.Nodes[i].Nodes[4].Nodes.Add(Convert.ToString(student.Age));
                    treeView2.Nodes[i].Nodes[4].Nodes.Add(student.Sex);
                    treeView2.Nodes[i].Nodes[4].Nodes.Add("Address");
                    treeView2.Nodes[i].Nodes[4].Nodes[4].Nodes.Add(student.Address.Country);
                    treeView2.Nodes[i].Nodes[4].Nodes[4].Nodes.Add(teacher.Address.District);
                    treeView2.Nodes[i].Nodes[4].Nodes[4].Nodes.Add(teacher.Address.City);
                    treeView2.Nodes[i].Nodes[4].Nodes[4].Nodes.Add(teacher.Address.Street);
                    treeView2.Nodes[i].Nodes[4].Nodes[4].Nodes.Add(teacher.Address.Housenumber);
                }

                i++;
            }

        }

        private void InitialGrid()
        {
       
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Sex");
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("District");
            dataTable.Columns.Add("City");
            dataTable.Columns.Add("Street");
            dataTable.Columns.Add("Housenumber");
            dataTable.Columns.Add("Student List");

          
            this.dataGridView1.DataSource = dataTable;
            DataGridColor();
        }


        private void RealodGrid()
        {
            try
            {
                dataTable.Rows.Clear();
            }
            catch (Exception)
            {

            }
            finally
            {
                int i = 1;
                foreach (Teacher teacher in teacherList.TeachersLst)
                {

                    dataTable.Rows.Add(i, teacher.Name, teacher.Surname, teacher.Age, teacher.Sex, teacher.Address.Country, teacher.Address.District, teacher.Address.City, teacher.Address.Street, teacher.Address.Housenumber, Convert.ToString(teacher.StudentsList.Count + "/" + teacher.LimitStudentList));
                    i++;
                }
                this.dataGridView1.DataSource = dataTable;
                DataGridColor();
            }
        }

        private void InitialDataGridStudent(int index)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Sex");
            dataTable.Columns.Add("Mark");
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("District");
            dataTable.Columns.Add("City");
            dataTable.Columns.Add("Street");
            dataTable.Columns.Add("Housenumber");

            int i = 1;
            foreach (Student student in teacherList.TeachersLst[index].StudentsList)
            {
                dataTable.Rows.Add(i, student.Name, student.Surname, student.Age, student.Sex, student.Marks, student.Address.Country, student.Address.District, student.Address.City, student.Address.Street, student.Address.Housenumber);
                i++;
            }
            this.dataGridView2.DataSource = dataTable;
        }

     
         private void DataGridColor() 
        {
            try
            {
                int i = 0;
                foreach (Teacher teacher in teacherList.TeachersLst)
                {
                    if (teacher.StudentsList.Count == teacher.LimitStudentList)
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    else
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    i++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("EROR");
            } 
        }

        private void DataGridImageTeacher()
        {
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Normal;
            if (!(dataGridView1.Columns.Contains(dgvImage)))
                dataGridView1.Columns.Add(dgvImage);

            string catalog = @"D:\ХДУ\Лабы\Csharp\ClassStudentWinForm\WindowsFormsApp1\img\Teacher";
            int i = 0;

            foreach (Teacher teacher in teacherList.TeachersLst)
            {

                string fileName = teacher.Name + " " + teacher.Surname + ".jfif";
               
                foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName))
                {
                    FileInfo FI;

                    PictureBox pictureBox = new PictureBox();

                    FI = new FileInfo(findedFile);
                    pictureBox.Image = Image.FromFile(FI.FullName);
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    dataGridView1.Rows[i].Cells[11].Value =Image.FromStream(ms);


                }
                i++;
            }
        }

        private void DataGridImageStudent(int index)
        {
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Normal;
            dataGridView2.Columns.Add(dgvImage);

            string catalog = @"D:\ХДУ\Лабы\Csharp\ClassStudentWinForm\WindowsFormsApp1\img\Student";
            int i = 0;
            foreach (Student student in teacherList.TeachersLst[index].StudentsList)
            {

                string fileName = student.Name + " " + student.Surname + ".jfif";

                foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName))
                {
                    FileInfo FI;

                    FI = new FileInfo(findedFile);
                    pictureBox2.Image = Image.FromFile(FI.FullName);
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    dataGridView2.Rows[i].Cells[11].Value = img;
                    

                }
                i++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (teacherList.TeachersLst[e.RowIndex].StudentsList.Count == 0)
                    MessageBox.Show("Null");
                else
                {
                    InitialDataGridStudent(e.RowIndex);
                    DataGridImageStudent(e.RowIndex);
                    _numberTeacher = e.RowIndex;
                }
            }
        }

        private void InitialChart()
        {
            chart1.Series[0].Points.Clear();

            foreach (Teacher teacher in teacherList.TeachersLst)
            {
                chart1.Series["Age"].Points.AddXY(teacher.Surname, teacher.Age);
                foreach (Student student in teacher.StudentsList)
                {
                    chart1.Series["Age"].Points.AddXY(student.Surname, student.Age);
                }
            }
        }


        private void AddStudentInList(string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber, string teacher , string marks)
        {
            string[] words = teacher.Split(' ');
            int numberTeacher = teacherList.FindTeacher(words[0], words[1]);
            teacherList.TeachersLst[numberTeacher].AddStudent(name, surname, age, sex, country, district, city, street, housenumber, marks);
            int lenStudentsList = teacherList.TeachersLst[numberTeacher].StudentsList.Capacity;
            Reload();

        }

        private void AddTeacherInList(string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber, int studentLimit)
        {
            teacherList.TeacherAdd(name, surname, age, sex, country, district, city, street, housenumber, studentLimit);
            Reload();
            Cheack();
        }


        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent(teacherList);
            DialogResult result = add.ShowDialog(this);
        }

        private void addNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            DialogResult result = addTeacher.ShowDialog(this);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                teacherList.RemoveTeacher(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Successfully deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
                Cheack();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
   
        }


        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose (*.json)|*.json";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                teacherList = JsonConvert.DeserializeObject<TeacherList>(File.ReadAllText(opf.FileName)); 
                Reload();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox1.Text}%'";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JsonSerializer serializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, teacherList);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                teacherList.TeachersLst[_numberTeacher].RemoveStudent(dataGridView2.SelectedRows[0].Index);
                MessageBox.Show("Successfully deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
                InitialDataGridStudent(_numberTeacher);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox2.Text}%'";
        }


        private void Reload()
        {
            RealodGrid();
            InitialTree();
            InitialChart();
            Cheack();
            DataGridImageTeacher();
        }

       
    }
}
