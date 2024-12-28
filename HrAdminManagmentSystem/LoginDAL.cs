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
                Console.WriteLine("====== HR MANAGMENT SYSTEM ====== ");

            }
            catch (Exception ex) { }
        }
    }
}
