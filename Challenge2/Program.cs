using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            DL.ReadAdminfromFile();
            DL.ReadCustomerfromFile();
            int adminOption=0;
            int customerOption=0;
            int choice = 0;
            while(choice!=3)
            {
                Console.Clear();
                choice = UI.MainMenu();
                if(choice==1)
                {
                   string name= UI.AskName();
                    string password = UI.AskPassword();
                    string role = DL.SignIn(name);
                    if (role == "admin")
                    {
                        while (adminOption != 6)
                        {
                            Console.Clear();
                            adminOption = UI.AdminMenu();
                            Console.ReadKey();
                        }

                    }
                    else if (role == "customer")
                    {
                        while (customerOption != 4)
                        {
                            Console.Clear();
                            customerOption = UI.CustomerMenu();
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered invalid information!");
                    }
                }
                else if(choice==2)
                {
                    string name, password, role;
                    while (true)
                    {
                        name = UI.AskName();
                        bool flag = DL.CheckName(name);
                        if(flag==false)
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        password = UI.AskPassword();
                        bool flag = DL.CheckPassword(password);
                        {
                            if(flag)
                            {
                                break;
                            }
                        }
                    }
                    while (true)
                    {
                        role = UI.AskRole();
                        bool flag = DL.CheckRole(role);
                        if(flag)
                        {
                            break;
                        }
                    }
                    bool isflag = DL.SignUp(name, password, role);
                    if (role == "admin")
                    { 
                        Admin admin = new Admin(name, password);
                        DL.StoreInFileAdmin(admin);
                    }
                    if (role == "customer")
                    { 
                        Customer customer = new Customer(name, password);
                        DL.StoreInFileCustomer(customer);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
