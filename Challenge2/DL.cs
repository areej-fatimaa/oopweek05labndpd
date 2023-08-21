using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Challenge2
{
    class DL
    {
       public static List<Admin> admin = new List<Admin>();
        public static List<Customer> customer = new List<Customer>();
        public static bool CheckRole(string Role)
        {
            if(Role=="admin"||Role=="customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckName(string name)
        {
            bool flag = false;
            bool Cflag = false;
           flag = admin.Any(obj => obj.Name == name);
            Cflag = customer.Any(obj => obj.Name == name);
            if (flag||Cflag)
            {
                flag = true;
            }
            return flag;
        }
        public static bool CheckPassword(string password)
        {
                bool hasUpperCase=false;
                bool hasLowerCase=false;
                bool hasDigit=false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            if (password.Length>8&&password.Length<15&& hasUpperCase && hasLowerCase && hasDigit)
            {
                    return true;
             }
            else
            {
                return false;
            }
        }
        public static bool SignUp(string name,string password ,string role)
        {
            bool flag = false;
                if (role == "admin")
                {
                    Admin ad = new Admin(name, password);
                    admin.Add(ad);
                    flag = true;
                }
                if (role == "customer")
                {
                    Customer cust = new Customer(name, password);
                    customer.Add(cust);
                    flag = true;
                }
                return flag;
        }
        public static string SignIn(string name)
        {
            bool isAdmin= admin.Any(obj => obj.Name == name);
            bool isCustomer = customer.Any(obj => obj.Name == name);
            if (isAdmin)
            {
                return "admin";
            }
            else if(isCustomer)
            {
                return "customer";
            }
            return null;
        }
        public static void StoreInFileAdmin(Admin admin)
        {
            string path = "D:\\oopWeek5lab\\Challenge2\\admin.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(admin.Name + "," + admin.Password );
            Console.ReadKey();
            file.Flush();
            file.Close();
        }
        public static void StoreInFileCustomer(Customer customer)
        {
            string path = "D:\\oopWeek5lab\\Challenge2\\customer.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(customer.Name + "," + customer.Password );
            Console.ReadKey();
            file.Flush();
            file.Close();
        }
        public static void ReadAdminfromFile()
        {
            string path = "D:\\oopWeek5lab\\Challenge2\\admin.txt";

            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.ReadKey();
                    string userName = record.Split(',')[0];
                    string password = record.Split(',')[1];
                    Admin s1 = new Admin(userName, password);
                    admin.Add(s1);
                    x++;
                    if (x > admin.Count)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            //else
            //{
            //    Console.WriteLine("Not Exists");
            //}
        }
        public static void ReadCustomerfromFile()
        {
            string path = "D:\\oopWeek5lab\\Challenge2\\customer.txt";

            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.ReadKey();
                    string userName = record.Split(',')[0];
                    string password = record.Split(',')[1];
                    Customer c1= new Customer(userName, password);
                    customer.Add(c1);
                    x++;
                    if (x > customer.Count)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            //else
            //{
            //    Console.WriteLine("Not Exists");
            //}
        }

    }
}
