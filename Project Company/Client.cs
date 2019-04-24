using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Client : Person
    {
        public Client(string name, string surname) : base(name, surname)
        {
        }

        public static Client CreateClient(string fullName)
        {
            string[] nameData = fullName.Split();
            string name = nameData[0];
            string surname = nameData[1];

            Client Client = new Client(name, surname);

            return Client;
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Messages.PrintInColor("Name of Client:", ConsoleColor.Yellow);
            Console.WriteLine(GetFullName());
        }
    }
}
