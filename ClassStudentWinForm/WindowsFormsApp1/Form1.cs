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
    public partial class Form1 : Form
    {
        private TeacherList teacherList = new TeacherList();

      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teacherList.AddAll();
            teacherList.TeachersList[0].Add();
            InitialTree();
            InitialGrid();
            InitialChart();
        }


        private void InitialTree()
        {
           
            TreeNode noderoot = new TreeNode();
            
            noderoot.Text = "Name";

        

            int i = 0;
            foreach (Teacher teacher in teacherList.TeachersList)
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
              
            DataTable dataTable = new DataTable();

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

            int i = 1;
            foreach (Teacher teacher in teacherList.TeachersList)
            {
                dataTable.Rows.Add(i, teacher.Name, teacher.Surname, teacher.Age, teacher.Sex, teacher.Address.Country, teacher.Address.District, teacher.Address.City, teacher.Address.Street, teacher.Address.Housenumber);
                i++;
            }
            this.dataGridView1.DataSource = dataTable;
        }

        private void InitialChart()
        {
            this.chart1.Titles.Add("User");

            foreach (Teacher teacher in teacherList.TeachersList)
            {
                chart1.Series["Age"].Points.AddXY(teacher.Surname, teacher.Age);
                foreach (Student student in teacher.StudentsList)
                {
                    chart1.Series["Age"].Points.AddXY(student.Surname, student.Age);
                }
            }
        }




        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            DialogResult result = add.ShowDialog(this);

            if(result == DialogResult.Cancel) return;

            teacherList.TeachersList[0].AddStudent(add.NameBox.Text, add.SurnameBox.Text,Convert.ToInt32( add.AgeBox.Text), add.SexBox.Text);

            InitialGrid();
        }
    }
}
