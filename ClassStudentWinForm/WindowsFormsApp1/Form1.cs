using System;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private TeacherList teacherList = new TeacherList();
        
        private int _numberTeacher;
        DataTable dataTableTeacher = new DataTable();

        private DataTable dataTable = new DataTable();

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


       

        private void InitialChart()
        {
            chart1.Series[0].Points.Clear();

            foreach (Teacher teacher in teacherList.TeachersLst)
            {
                chart1.Series["Teacher"].Points.AddXY(teacher.Surname , teacher.Age);
                foreach (Student student in teacher.StudentsList)
                {
                    chart1.Series["Student"].Points.AddXY(student.Surname, student.Age);
                }
            }
        }

        private void InitialTree()
        {
            treeView2.Nodes.Clear();


            TreeNode noderoot = new TreeNode();

            noderoot.Text = "Name";



            int i = 0;

            foreach (Teacher teacher in teacherList.TeachersLst)
            {
                treeView2.Nodes.Add(teacher.Surname + teacher.Name);
                treeView2.Nodes[i].Nodes.Add("Student");
                foreach (Student student in teacher.StudentsList)
                {
                    treeView2.Nodes[i].Nodes[0].Nodes.Add(student.Surname + student.Name);
                }
                i++;
            }

        }

        private void InitialGrid()
        {
            

            dataTableTeacher.Columns.Add("Id");
            dataTableTeacher.Columns.Add("Name");
            dataTableTeacher.Columns.Add("Surname");
            dataTableTeacher.Columns.Add("Age");
            dataTableTeacher.Columns.Add("Sex");
            dataTableTeacher.Columns.Add("Country");
            dataTableTeacher.Columns.Add("District");
            dataTableTeacher.Columns.Add("City");
            dataTableTeacher.Columns.Add("Street");
            dataTableTeacher.Columns.Add("Housenumber");
            dataTableTeacher.Columns.Add("Student List");

            this.dataGridView1.DataSource = dataTableTeacher;
            DataGridColor();


        }


        private void RealodGrid()
        {
            try
            {
                dataTableTeacher.Rows.Clear();
            }
            catch (Exception)
            {

            }
            finally
            {
                foreach (Teacher teacher in teacherList.TeachersLst)
                {

                    dataTableTeacher.Rows.Add(teacher.Id, teacher.Name, teacher.Surname, teacher.Age, teacher.Sex, teacher.Address.Country, teacher.Address.District, teacher.Address.City, teacher.Address.Street, teacher.Address.Housenumber, Convert.ToString(teacher.StudentsList.Count + "/" + teacher.LimitStudentList));
                }
                LinkTeacher();
                this.dataGridView1.DataSource = dataTableTeacher;
                DataGridColor();
            }
        }

        private void LinkTeacher()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[10, i] = linkCell;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[1, i] = linkCell;
            }
        }


        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            DataGridColor();
            LinkTeacher();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10 )
                {
                    if (teacherList.TeachersLst[Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value)].StudentsList.Count == 0)
                        MessageBox.Show("Student list is empty");
                    else
                    {
                        InitialDataGridStudent(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value));
                        _numberTeacher = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    }
                }
                if(e.ColumnIndex == 1)
                {
                    Teacher teacher = teacherList.TeachersLst[Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value)];
                    PhotoUser photoUser = new PhotoUser(teacher.Name,teacher.Surname,teacher.PathToPhoto,true);
                    DialogResult result = photoUser.ShowDialog(this);
                }
               
            }
            catch
            {

            }
            
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox1.Text}%'";
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
                MessageBox.Show("Select teacher to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InitialDataGridStudent(int index)
        {

            DataTable dataTableStudent = new DataTable();

            dataTableStudent.Columns.Add("Id");
            dataTableStudent.Columns.Add("Name");
            dataTableStudent.Columns.Add("Surname");
            dataTableStudent.Columns.Add("Age");
            dataTableStudent.Columns.Add("Sex");
            dataTableStudent.Columns.Add("Mark");
            dataTableStudent.Columns.Add("Country");
            dataTableStudent.Columns.Add("District");
            dataTableStudent.Columns.Add("City");
            dataTableStudent.Columns.Add("Street");
            dataTableStudent.Columns.Add("Housenumber");

            int i = 0;
            foreach (Student student in teacherList.TeachersLst[index].StudentsList)
            {
                dataTableStudent.Rows.Add(i, student.Name, student.Surname, student.Age, student.Sex, student.Marks, student.Address.Country, student.Address.District, student.Address.City, student.Address.Street, student.Address.Housenumber);
                i++;
            }

            this.dataGridView2.DataSource = dataTableStudent;
            LinkStudent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    Student student = teacherList.TeachersLst[_numberTeacher].StudentsList[Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value)];
                    PhotoUser photoUser = new PhotoUser(student.Name,student.Surname,student.PathToPhoto,false);
                    DialogResult result = photoUser.ShowDialog(this);
                }

            }
            catch
            {

            } 

        }

        private void LinkStudent()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView2[1, i] = linkCell;
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


        private void AddStudentInList(string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber, string teacher , string marks,string PathToPhoto)
        {
            string[] words = teacher.Split(' ');
            int numberTeacher = teacherList.FindTeacher(words[0], words[1]);
            teacherList.TeachersLst[numberTeacher].AddStudent(teacherList.TeachersLst[numberTeacher].StudentsList.Count, name, surname, age, sex, country, district, city, street, housenumber, marks, PathToPhoto);
            int lenStudentsList = teacherList.TeachersLst[numberTeacher].StudentsList.Capacity;
            Reload();

        }

        private void AddTeacherInList(string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber, int studentLimit,string path)
        {
            teacherList.TeacherAdd(teacherList.TeachersLst.Count,name, surname, age, sex, country, district, city, street, housenumber, studentLimit, path);
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


      

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.json,*.soap)|*.json;*.soap|All files(*.*)|*.*";
            SoapFormatter formatter = new SoapFormatter();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".json"))
                    teacherList = JsonConvert.DeserializeObject<TeacherList>(File.ReadAllText(openFileDialog1.FileName));
                if (openFileDialog1.FileName.EndsWith(".soap"))
                {
                    using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
                    {
                        teacherList = (TeacherList)formatter.Deserialize(fs);
                    }
                }
                Reload();
            }
        }

     
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void sOAPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text files(*.soap)|*.soap|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    // сериализация (сохранение объекта в поток)
                    formatter.Serialize(fs, teacherList);
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



        private void Reload()
        {
            RealodGrid();
            InitialTree();
            InitialChart();
            Cheack();
        }

        private void Cheack()
        {
            if (teacherList.TeachersLst.Capacity == 0)
                addNewStudentToolStripMenuItem.Enabled = false;
            else
                addNewStudentToolStripMenuItem.Enabled = true;
        }

       
    }
}
