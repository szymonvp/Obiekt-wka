using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Employee : Person
    {
        public string Position { get; set; }

        public static decimal HolidayBonus { get; set; } = 1000;

        public Employee(string name, string surname, string position) : base(name, surname)
        {
            Position = position;
        }



        public ContractTypes Contract { get; set; }

        public enum ContractTypes { FullTime, PartTime, Contract}

        public string TranslateContractToJobName(ContractTypes Contract)
        {
            string Jobname = "";

            switch (Contract)
            {
                case ContractTypes.FullTime:
                    Jobname = "Full Time";
                    break;
                case ContractTypes.PartTime:
                    Jobname = "Part Time";
                    break;
                case ContractTypes.Contract:
                    Jobname = "Contract";
                    break;
            }
            return Jobname;
        }
        private Wage wage;
        public Wage Wage
        {
            get { return wage; }
            set
            {
                if (Security.LogIn() == true)
                {
                    wage = value;
                    Messages.PrintInColor("Wage set to " + wage.WageTotal(), ConsoleColor.Yellow);
                }

                else
                {
                    Messages.PrintInColor("Wrong credentials - wage not set.", ConsoleColor.Red);
                }
            }

        }
        public static Employee CreateEmployee(string fullName, string position, decimal baseWage)
        {
            string[] nameData = fullName.Split();
            string name = nameData[0];
            string surname = nameData[1];

            Employee Employee = new Employee(name, surname, position);
            Employee.Wage = new Wage(baseWage);

            return Employee;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine();
            Messages.PrintInColor("Employee:", ConsoleColor.Yellow);
            Console.WriteLine
                (
                        "{0}, is hired as a {1} and earning {2} + bonus {3}. It's a {4} job.", GetFullName(), Position, 
                        Wage.WageTotal(), HolidayBonus, TranslateContractToJobName(Contract)
                );
        }

        public List<Operation> Operations { get; set; } = new List<Operation>();

        public void PrintOperationInfo()
        {
            Console.WriteLine();
            Messages.PrintInColor("Operations for " + GetFullName() + ":", ConsoleColor.Yellow);

            foreach (Operation Operation in Operations)
            {
                Operation.PrintOperationInfo();
            }
        }
    }
    public struct Wage
    {

        public decimal Basic { get; set; }
        public decimal Bonus { get; set; }
        public decimal Other { get; set; }

        public Wage(decimal basic, decimal bonus = 0, decimal other = 0)
        {
            Basic = basic;
            Bonus = bonus;
            Other = other;
        }

        public decimal WageTotal()
        {
            return Basic + Bonus + Other + Employee.HolidayBonus;
        }
    }
}
