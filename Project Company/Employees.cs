using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Employees
    {
        public List<Employee> EmployeesList { get; set; } = new List<Employee>();

        public Employee this [string name, string surname]
        {
            get

            {
                foreach (Employee Employee in EmployeesList)
                {
                    if (Employee.GetName() == name && Employee.Surname == surname)
                    {
                        return Employee;
                    }
                }
                return null;
            }
        }

        public Employee CreateEmployeeAndAddToList(string fullName, string position, decimal baseWage)
        {
            Employee Employee = Employee.CreateEmployee(fullName, position, baseWage);
            EmployeesList.Add(Employee);

            return Employee;
        }

        public void AddEmployee(Employee Employee)
        {
            if (!EmployeesList.Contains(Employee))
            {
                EmployeesList.Add(Employee);
            }
        }

        public void RemoveEmployee(Employee Employee)
        {
            if (!EmployeesList.Contains(Employee))
            {
                EmployeesList.Remove(Employee);
            }
        }

        public Employee GetEmployee(string name, string surname)
        {
            return this[name, surname];
        }

        public void  PrintEmployees()
        {
            foreach ( Employee Employee in EmployeesList)
            {
                Employee.PrintInfo();
            }
        }
    }
}
