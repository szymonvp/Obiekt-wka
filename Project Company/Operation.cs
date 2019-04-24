using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Operation
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public decimal Amount { get; set;}

        public Operation(string type, string label, decimal amount)
        {
            Type = type;
            Label = label;
            Amount = amount;
        }

        public void PrintOperationInfo()
        {
            Console.WriteLine
                (
                    "Operation: {0} is a {1} on amount {2}.",
                    Label/*Etykieta*/, Type/*Typ*/, Amount/*kwota*/
                );
        }

    }
}
