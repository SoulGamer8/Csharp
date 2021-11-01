using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            TeacherList teacherList = new TeacherList();
            teacherList.AddAll();
            while (true)
            {
                int numberTeacher;
                int numberStudent;
                Console.WriteLine("Work with\n" +
                                  "1 - Teacher\n" +
                                  "2 - Student\n" +
                                  "3 - Save to file \n" +
                                  "4 - Exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("1 - Add teacher.\n" +
                                          "2 - Remove Teacher.\n" +
                                          "3 - Sort\n" +
                                          "4 - Print List Teacher\n" +
                                          "5 - Print all info about Teacher\n" +
                                          "6 - Find Teacher\n" +
                                          "7 - Return");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                teacherList.TeacherAdd();
                                break;
                            case 2:
                                Console.Write("Teacher number:");
                                numberTeacher = Convert.ToInt32(Console.ReadLine());
                                teacherList.RemoveTeacher(numberTeacher);
                                break;
                            case 3:
                                teacherList.Sort();
                                break;
                            case 4:
                                teacherList.PrintLIstTeacher();
                                break;
                            case 5:
                                Console.Write("Teacher number:");
                                numberTeacher = Convert.ToInt32(Console.ReadLine());
                                teacherList.PrintInfoTeacher(numberTeacher);
                                break;
                            case 6:
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Surname: ");
                                string surname = Console.ReadLine(); 
                                Console.WriteLine(teacherList.FindTeacher(surname,name));
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("1 - Add Student\n" +
                                          "2 - Remove Student\n" +
                                          "3 - Print List Student\n" +
                                          "4 - Print all info about student\n" +
                                          "5 - Return");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Console.Write("Teacher number:");
                                numberTeacher = Convert.ToInt32(Console.ReadLine());
                                teacherList.TeachersList[numberTeacher].AddStudent();
                                break;
                            case 2:
                                Console.Write("Teacher number:");
                                numberTeacher = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Student number:");
                                numberStudent = Convert.ToInt32(Console.ReadLine());
                                teacherList.TeachersList[numberTeacher].RemoveStudent(numberStudent);
                                break;
                            case 3:
                                Console.Write("Teacher number:");
                                numberTeacher = Convert.ToInt32(Console.ReadLine());
                                teacherList.TeachersList[numberTeacher].PrintListStudent();
                                break;
                            case 4: 
                                Console.Write("Teacher number:");
                                numberTeacher = Convert.ToInt32(Console.ReadLine());
                                while(!(numberTeacher<teacherList.TeachersList.Count))
                                {
                                    Console.Write("Try again: ");
                                    numberTeacher = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("Student number: ");
                                numberStudent = Convert.ToInt32(Console.ReadLine());
                                teacherList.TeachersList[numberTeacher].GetInfoAboutStudent(numberStudent);
                                break;
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("1 - Save XML\n" +
                                          "2 - Save JSON\n" +
                                          "3 - Return");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                           case 1:
                               SaveXML(teacherList);
                               break;
                           case 2:
                               SaveJson(teacherList);
                               break;
                        }
                        break;
                    default: 
                        System.Environment.Exit(1);
                        break;
                }

            }
        }

        private static void SaveXML(TeacherList teacherList)
        {
            Console.WriteLine("Name file:");
            string nameFile = Console.ReadLine();
            while (String.IsNullOrEmpty(nameFile))
            {
                Console.WriteLine("Name file:");
                nameFile = Console.ReadLine();
            }

            XDocument xvoc = new XDocument(new XElement("Human"));
            xvoc.Save(nameFile);
            
            XDocument xDoc = XDocument.Load(nameFile);
            foreach (Teacher teacher in teacherList.TeachersList)
            {
                xDoc.Element("Human").Add
                (new XElement("Teacher",
                            new XAttribute("Surname", teacher.Surname),
                            new XElement("Name", teacher.Name),
                            new XElement("Age", teacher.Age),
                            new XElement("Sex", teacher.Sex),
                            new XElement("Country", teacher.Address.Country),
                            new XElement("District", teacher.Address.District),
                            new XElement("City", teacher.Address.City),
                            new XElement("Street", teacher.Address.Street),
                            new XElement("Housenumber", teacher.Address.Housenumber),
                            new XElement("Limit", teacher.LimitStudentList)));
            }
            
            foreach (Teacher teacher in teacherList.TeachersList)
            {
                foreach (Student student in teacher.StudentsList)
                {
                    xDoc.Element("Human").Add(
                        new XElement("Student",
                            new XAttribute("Surname", student.Surname),
                            new XElement("Name", student.Name),
                            new XElement("Age", student.Age),
                            new XElement("Sex", student.Sex),
                            new XElement("Country", student.Address.Country),
                            new XElement("District", student.Address.District),
                            new XElement("City", student.Address.City),
                            new XElement("Street", student.Address.Street),
                            new XElement("Housenumber", student.Address.Housenumber)));
                }
            }
            xDoc.Save(nameFile);
            Console.WriteLine("Data has been saved to file");
        }
            
        
         static async Task SaveJson(TeacherList teacherList)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                for (int i = 0; i < teacherList.TeachersList.Count; i++)
                {
                    await JsonSerializer.SerializeAsync<Teacher>(fs, teacherList.TeachersList[i],options);
                }

                Console.WriteLine("Data has been saved to file");
            }
        }
    }
}