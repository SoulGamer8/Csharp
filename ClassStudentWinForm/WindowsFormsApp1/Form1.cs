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

            AddStudent.EventSaveStudent += AddStudentInList;
            AddTeacher.EventSaveTeacher += AddTeacherInList;
        }


        private void LoadSave()
        {
            try
            {
                string catalog = @"..\save\list.json";
                teacherList = JsonConvert.DeserializeObject<TeacherList>(File.ReadAllText(catalog));
                Reload();
            }
            catch
            {

            }
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
            int j = 0;
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
                j = 0;
                foreach (Student student in teacher.StudentsList)
                {
                    treeView2.Nodes[j].Nodes[4].Nodes.Add(student.Surname);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes.Add(student.Name);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes.Add(Convert.ToString(student.Age));
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes.Add(student.Sex);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes.Add("Address");
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes[3].Nodes.Add(student.Address.Country);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes[3].Nodes.Add(teacher.Address.District);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes[3].Nodes.Add(teacher.Address.City);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes[3].Nodes.Add(teacher.Address.Street);
                    treeView2.Nodes[j].Nodes[4].Nodes[0].Nodes[3].Nodes.Add(teacher.Address.Housenumber);
                    j++;
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
                foreach (Teacher teacher in teacherList.TeachersLst)
                {

                    dataTable.Rows.Add(teacher.Id, teacher.Name, teacher.Surname, teacher.Age, teacher.Sex, teacher.Address.Country, teacher.Address.District, teacher.Address.City, teacher.Address.Street, teacher.Address.Housenumber, Convert.ToString(teacher.StudentsList.Count + "/" + teacher.LimitStudentList));
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

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            DataGridColor();
        }


        private void DataGridColor() 
        {
            try
            {
                for (int i = 0; i < teacherList.TeachersLst.Count; i++)
                {
                    if (teacherList.TeachersLst[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)].StudentsList.Count == teacherList.TeachersLst[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)].LimitStudentList)
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    else
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Green;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            } 
        }

        private void DataGridImageTeacher()
        {
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Normal;
            if (!(dataGridView1.Columns.Contains(dgvImage)))
                dataGridView1.Columns.Add(dgvImage);

            string catalog = @"..\img\Teacher";
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
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();

            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Normal;
            dataGridView2.Columns.Add(dgvImage);

            string catalog = @"..\img\Student";
            int i = 0;
          
            foreach (Student student in teacherList.TeachersLst[index].StudentsList)
            {

                string fileName = student.Name + " " + student.Surname + ".jfif";
               
                foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName))
                {
                    FileInfo FI;

                    PictureBox pictureBox = new PictureBox();

                    FI = new FileInfo(findedFile);
                    pictureBox.Image = Image.FromFile(FI.FullName);
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    dataGridView2.Rows[i].Cells[11].Value = img;
                }
                i++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10)
                {
                    if (teacherList.TeachersLst[Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value)].StudentsList.Count == 0)
                        MessageBox.Show("Student list is empty");
                    else
                    {
                        InitialDataGridStudent(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value));
                        DataGridImageStudent(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value));
                        _numberTeacher = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    }
                }
            }
            catch
            {

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
            teacherList.TeachersLst[numberTeacher].AddStudent(teacherList.TeachersLst[numberTeacher].StudentsList.Count, name, surname, age, sex, country, district, city, street, housenumber, marks);
            int lenStudentsList = teacherList.TeachersLst[numberTeacher].StudentsList.Capacity;
            Reload();

        }

        private void AddTeacherInList(string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber, int studentLimit)
        {
            teacherList.TeacherAdd(teacherList.TeachersLst.Count,name, surname, age, sex, country, district, city, street, housenumber, studentLimit);
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
                MessageBox.Show("Select teacher to remove", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
   
        }


        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.json)|*.json|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                teacherList = JsonConvert.DeserializeObject<TeacherList>(File.ReadAllText(openFileDialog1.FileName)); 
                Reload();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox1.Text}%'";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string catalog = @"..\save";
            saveFileDialog1.Filter = "Text files(*.json)|*.json|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JsonSerializer serializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
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
                MessageBox.Show("Select student to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox2.Text}%'";
            }
            catch 
            {
            }
           
        }


        private void Reload()
        {
            RealodGrid();
            //InitialTree();
            InitialChart();
            Cheack();
            DataGridImageTeacher();
        }

       
    }
}
