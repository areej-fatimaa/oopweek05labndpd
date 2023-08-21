using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class DL
    {
        public static List<Student> studentList = new List<Student>();
        public static List<DegreeProgram> programList = new List<DegreeProgram>();
        public static List<Student> student = new List<Student>();
        public static List<string> preference = new List<string>();
        public static List<DegreeProgram> degrees = new List<DegreeProgram>();
        public static void AddIntoDegreeList(DegreeProgram deg)
        {
            programList.Add(deg);
        }
        public static bool CheckDegreeName(string degName, List<DegreeProgram> pref)
        {
            bool flag = false;
            foreach (DegreeProgram dp in programList)
            {
                if (degName == dp.Name && !(pref.Contains(dp)))
                {
                    pref.Add(dp);
                    flag = true;
                }
            }
            return flag;
        }
       public  static void AddIntoStudentList(Student s)
        {
            studentList.Add(s);
        }
        public static void ViewDegreeProgram()
        {
            foreach (DegreeProgram dp in programList)
            {
                UI.ViewDP(dp.Name);
                //Console.WriteLine(dp.Name);
            }
        }
        public static void ViewSubjects(Student stu)
        {
            if (stu.regDegree != null)
            {
                UI.ViewSub1();
                foreach (Subject sub in stu.regDegree.subjects)
                {
                    UI.ViewSub2(sub.subCode, sub.subType);
                }
            }
        }
        public static Student StudentPresent(string name)
        {
            foreach (Student stu in studentList)
            {
                if (name == stu.Name && stu.regDegree != null)
                {
                    return stu;
                }
            }
            return null;
        }
        public static string CalculateFeesForAll()
        {
            foreach (Student stu in studentList)
            {
                if (stu.regDegree != null)
                {
                    string str =stu.Name + "has" + stu.CalculateFee() + "fees";
                    return str;
                }
            }
            return null;
        }
        public static void RegisterSubjects(Student stu)
        {
            int count = UI.RegisterSubject1();
            for (int i = 0; i < count; i++)
            {
                string code = UI.RegisterSubject2();
                bool flag = false;
                foreach (Subject sub in stu.regDegree.subjects)
                {
                    if (code == sub.subCode && !(stu.regSubject.Contains(sub)))
                    {
                        stu.RegStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    UI.InvalidCode();
                    i--;
                }
            }
        }
        public static List<Student> SortStudentByMerit()
        {
            List<Student> sortedList = new List<Student>();
            foreach (Student stu in studentList)
            {
                stu.CalculateMerit();
            }
            sortedList = studentList.OrderByDescending(s => s.merit).ToList();
            return sortedList;
        }
        public static void GiveAdmission(List<Student> sortedList)
        {
            foreach (Student stu in sortedList)
            {
                foreach (DegreeProgram deg in stu.preference)
                {
                    if (deg.Seats > 0 && stu.regDegree == null)
                    {
                        stu.regDegree = deg;
                        deg.Seats--;
                        break;
                    }
                }

            }
        }
       public  static void PrintStudent()
        {
            foreach (Student stu in studentList)
            {
                if (stu.regDegree != null)
                {
                    UI.GotAdmission(stu.Name, stu.regDegree.Name);               
                }
                else
                {
                    UI.NotAdmission(stu.Name);
                }
            }
        }
        public static void ViewStudentInDegree(string degName)
        {
            UI.ViewStuInDeg();
            foreach (Student stu in studentList)
            {
                if (degName == stu.regDegree.Name)
                {
                    UI.ViewStuInDeg1(stu.Name, stu.FscMarks, stu.EcatMarks, stu.Age);
                }
            }
        }
        public static void ViewAllRegisteredStudent()
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach (Student stu in studentList)
            {
                if (stu.regDegree != null)
                {
                    Console.WriteLine(stu.Name + "\t" + stu.FscMarks + "\t" + stu.EcatMarks + "\t" + stu.Age);
                }
            }
        }
    }
}