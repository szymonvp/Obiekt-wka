using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Clients
    {
        public List<Client> ClientsList { get; set; } = new List<Client>();

        public Client this[string name, string surname]
        {
            get

            {
                foreach (Client Client in ClientsList)
                {
                    if (Client.GetName() == name && Client.Surname == surname)
                    {
                        return Client;
                    }
                }
                return null;
            }
        }
        public Client CreateClientAndAddToList(string fullName)
        {
            Client Client = Client.CreateClient(fullName);
            ClientsList.Add(Client);

            return Client;
        }

        public void AddClient(Client Client)
        {
            if (!ClientsList.Contains(Client))
            {
                ClientsList.Add(Client);
            }
        }

        public void RemoveCLient(Client Client)
        {
            if (!ClientsList.Contains(Client))
            {
               ClientsList.Remove(Client);
            }
        }

        public Client GetClient(string name, string surname)
        {
            return this[name, surname];
        }

        public void PrintClients()
        {
            foreach (Client Client in ClientsList)
            {
                Client.PrintInfo();
            }

        }
    }
}
