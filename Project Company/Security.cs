using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Security
    {
        public static bool LoggedIn { get; set; } = false;

        public static bool LogIn()
        {
            if (LoggedIn == false)
            {
                Messages.PrintInColor("Login and password required to set a wage for emploee", ConsoleColor.Yellow);

                Console.Write("Login: ");
                string login = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (login == "szymon" && password == "zebro123")
                {
                    LoggedIn = true;
                    return true;
                }

                return false;
            }

            return true;
        }
    }
}
