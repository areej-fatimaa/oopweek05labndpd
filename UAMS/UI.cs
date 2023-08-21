using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class UI
    {
        public static void Header()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("                      UMAS                           ");
            Console.WriteLine("*****************************************************");
        }
       public static int Menu()
        {
            Console.WriteLine("1.Add student");
            Console.WriteLine("2.Add degree program");
            Console.WriteLine("3.Generate merit");
            Console.WriteLine("4.View registered students");
            Console.WriteLine("5.View students of specific program");
            Console.WriteLine("6.Register subjects for specific student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static DegreeProgram AddDegreeProgram()
        {
            Console.WriteLine("Enter degree name:");
            string degName = Console.ReadLine();
            Console.WriteLine("Enter degree duration:");
            int degreeDuration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seats for degree:");
            int degSeats = int.Parse(Console.ReadLine());

            DegreeProgram program = new DegreeProgram(degName, degreeDuration, degSeats);
            Console.WriteLine("How many subjects you want to enter");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                program.AddSubject(InputAddSubject());
            }
            return program;
        }
       public static Subject InputAddSubject()
        {
            Console.WriteLine("Enter subject code:");
            string subCode = Console.ReadLine();
            Console.WriteLine("Enter subject type:");
            string subType = Console.ReadLine();
            Console.WriteLine("Subject credit hours:");
            int creditHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subject fee:");
            int subFee = int.Parse(Console.ReadLine());
            Subject sub = new Subject(subCode, subType, creditHour, subFee);
            return sub;
        }
        public static Student InputAddStudent()
        {
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter FSC marks:");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ECAT marks:");
            int ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Available degree programs");
            DL.ViewDegreeProgram();
            Console.WriteLine("How many preferences you want to enter");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string degName = Console.ReadLine();
                bool flag = DL.CheckDegreeName(degName, preferences);
                if (flag == false)
                {
                    Console.WriteLine("Enter valid degree name");
                }
            }
            Student stu = new Student(name, age, fscMarks, ecatMarks, preferences);
            return stu;
        }
        public static string Choice5Input()
        {
            Console.WriteLine("Enter degree name:");
            string degName = Console.ReadLine();
            return degName;
        }
        public static string Choice6Input()
        {
            Console.WriteLine("Enter student name:");
            string Name = Console.ReadLine();
            return Name;
        }

        public static void ViewDP(string name)
        {
            Console.WriteLine(name);
        }
        public static void ViewSub1()
        {
            Console.WriteLine("Subject code \t Subject type");
        }
        public static void ViewSub2(string code,string type)
        {
            Console.WriteLine(code + "\t" + type);
        }
        public static void CalculateFeeOutput()
        {
            string str = DL.CalculateFeesForAll();
           if(str!=null)
            {
                Console.WriteLine(str);
            }
        }
        public static int RegisterSubject1()
        {
            Console.WriteLine("Enter how many subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            return count;
        }
        public static string RegisterSubject2()
        {
            Console.WriteLine("Enter the subject code");
            string code = Console.ReadLine();
            return code;
        }
        public static void InvalidCode()
        {
            Console.WriteLine("Enter valid course");
        }
        public static void GotAdmission(string name, string degname)
        {
            Console.WriteLine(name + " got admission in " + degname);

        }
        public static void NotAdmission(string name)
        {
            Console.WriteLine(name + " did not get admission");
        }
        public static void ViewStuInDeg1(string name , int fsc, int ecat , string age)
        {
            Console.WriteLine(name + "\t" +fsc + "\t" +ecat + "\t" + age);
        }
        public static void ViewStuInDeg()
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
        }
    }
}
