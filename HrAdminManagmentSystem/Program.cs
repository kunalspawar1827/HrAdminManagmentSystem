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
                    PrintMenu:
                        Console.Clear();
                        LoginDAL.DisplyHeading();
                        Console.WriteLine($"Welocome {Username}");
                        Console.WriteLine();
                        LoginDAL.PrintMenu();

                        int Choice = Convert.ToInt32(Console.ReadLine());
                        if (typeof(int) == Choice.GetType())
                        {
                            switch (Choice)
                            {
                                case 1:
                                    Console.WriteLine("List Of All Employees");
                                    break;
                                case 2:
                                    Console.WriteLine("Add Employees");
                                    break;
                                case 3:
                                    Console.WriteLine("Edit Employees");
                                    break;
                                case 4:
                                    Console.WriteLine("Delete Employees");
                                    break;
                                default: Console.WriteLine("Choose Option between Given Menu");
                                         Console.ReadLine();
                                   
                                    goto PrintMenu;
                                   
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eneter Valid Integer Input");
                            Console.ReadLine();
                            goto PrintMenu;
                        }






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
