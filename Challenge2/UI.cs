using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class UI
    {
        static public int AdminMenu()
        {
            int choice = 0;
            Console.WriteLine("1.Addd product");
            Console.WriteLine("2.View all products");
            Console.WriteLine("3.Find product with highest price");
            Console.WriteLine("4.view sales tax of all products");
            Console.WriteLine("5.Products to be ordered");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Enter choice:");
           try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid choice");
            }
            return choice;
        }
        public static int MainMenu()
        {
            int choice = 0;
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid choice");
            }
            return choice;
            }
        public static int CustomerMenu()
        {
            int choice = 0;
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid choice");
            }
            return choice;
        }
        public static string AskRole()
        {
                string Role;
                Console.WriteLine("Enter role (admin/customer)");
                string role = Console.ReadLine();
                Role = role.ToLower();
                return Role;
        }
        public static string AskName()  
        {
            Console.WriteLine("Enter username");
            string name = Console.ReadLine();
            return name;
        }
        public static string AskPassword()
        {
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            return password;
        }
    }
}
