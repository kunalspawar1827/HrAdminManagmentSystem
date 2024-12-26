using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HrAdminManagmentSystem
{
    internal class Admin
    {
        private  string Username {  get; set; }
        private int Password { get; set; }

        public Admin(string username, int password )
        {
            this.Username = username;
            this.Password = password;
        }

        
        public bool GetRights()
        {
            bool Right = false;
            try
            {

            }
            catch(Exception ex)
            {

            }
            return Right;   
        }

    }
}
