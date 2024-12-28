using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HrAdminManagmentSystem;

namespace HrAdminManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LoginDAL.DisplyHeading();
            string Username, Pass;
            LoginDAL loginDAL = new LoginDAL();

            try
            {
                label:
                Console.Write("Enter Username : ");
                Username = Console.ReadLine().ToString();
                if (!string.IsNullOrEmpty(Username) || Username != "")
                {
                    Console.Write("Enter Password : ");
                    Pass = Console.ReadLine().ToString();
                    bool res = loginDAL.IsValidLogin(Username, Pass);
                    if (res)
                    {
                        /* Make Menu To Perform Operations */
                        Console.Clear();
                        LoginDAL.DisplyHeading();
                        Console.WriteLine($"Welocome {Username}");


                    }
                    else
                    {
                        Console.WriteLine("Invalid Password Please Check Password Again Please Enter To Login Again");
                        Console.ReadLine();
                        Console.Clear();
                        LoginDAL.DisplyHeading();

                        goto label;
                    }
                }
                else
                {
                    Console.WriteLine("Usename Should Not Be Blank Please Enter To Login Again");
                    Console.ReadLine();
                    Console.Clear();
                    LoginDAL.DisplyHeading();
                    goto label;


                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            Console.ReadLine();

        }
    }
}
