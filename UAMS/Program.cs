using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 8)
            {
                UI.Header();
                choice = UI.Menu();
                if (choice == 1)
                {
                    if (DL.programList.Count > 0)
                    {
                        Student s = UI.InputAddStudent();
                        DL.AddIntoStudentList(s);
                    }

                }
                else if (choice == 2)
                {
                    DegreeProgram pro = UI.AddDegreeProgram();
                    DL.AddIntoDegreeList(pro);
                }
                else if (choice == 3)
                {
                    List<Student> sortedList = new List<Student>();
                    sortedList = DL.SortStudentByMerit();
                    DL.GiveAdmission(sortedList);
                    DL.PrintStudent();
                }
                else if (choice == 4)
                {
                    DL.ViewAllRegisteredStudent();
                }
                else if (choice == 5)
                {
                    string degName=UI.Choice5Input();
                    DL.ViewStudentInDegree(degName);
                }
                else if (choice == 6)
                {
                    string name = UI.Choice6Input();
                    Student s = DL.StudentPresent(name);
                    if (s != null)
                    {
                        DL.ViewSubjects(s);
                        DL.RegisterSubjects(s);
                    }
                }
                else if (choice == 7)
                {
                    DL.CalculateFeesForAll();
                }
            }
        }
    }
}
