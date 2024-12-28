using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAdminManagmentSystem
{
    internal class LoginDAL
    {

        public bool IsValidLogin(string username, string password)
        {
            bool isValid = false;
            try
            {
                if(( username == "Kunal" && password== "123"))
                {
                    isValid = true;
                }
            }
            catch (Exception ex)
            {

            }
            return isValid;
        }
        public   static void DisplyHeading()
        {
            try
            {
                
                Console.WriteLine("========================================");
                Console.WriteLine("            * HR MANAGMENT SYSTEM *           ");
                Console.WriteLine("========================================");
            }
            catch (Exception ex) { }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("             Employee Manager           ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. View All Employees in Department");
            Console.WriteLine("2. Add Employee to Department");
            Console.WriteLine("3. Edit Employee Details");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("========================================");
            Console.WriteLine("Please select an option (1-4): ");
        }

    }
}
