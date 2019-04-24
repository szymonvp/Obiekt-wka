using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Program
    {
        static void Main(string[] args)

        {

                string s = "Hello! its Volkoff Industries";
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Messages.PrintInColor(s, ConsoleColor.Green);
                Console.WriteLine();

                Company Company = new Company("Volkoff Industries");

                // Clients.ClientsList.Add(clientOne);
                // Clients.ClientsList.Add(clientTwo);
                //searchedEmployee.PrintInfo();
                //employeeFour.PrintOperationInfo();
                //Employees.PrintEmployees();
                // Clients.PrintClients();

                int menu;
                int key = 10;

                do
                {

                    Console.WriteLine("[ 1 ] Login");
                    Console.WriteLine("[ 2 ] Logout");
                    Console.WriteLine("[ 3 ] Show Employees");
                    Console.WriteLine("[ 4 ] Add Employees");
                    Console.WriteLine("[ 5 ] Delete Employees");
                    Console.WriteLine("[ 6 ] Show Clients");
                    Console.WriteLine("[ 7 ] Back");
                    Console.WriteLine("[ 0 ] Exit");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Choose Number Options: ");
                    menu = Int32.Parse(Console.ReadLine());
                    switch (menu)

                    {
                        case 1:
                            login(key);
                            break;
                        case 2:
                            
                            logout(menu);

                        break;
                           
                        case 3:
                            showemployees(key);
                            Employee employeeOne = new Employee("Robert", "Nowak", "Carpenter")

                            {
                                Wage = new Wage(3000, 1800, 100.50m),
                                Contract = Employee.ContractTypes.FullTime
                            };

                            employeeOne.Operations.Add(new Operation("Wage October", "Payment", employeeOne.Wage.WageTotal()));
                            employeeOne.Operations.Add(new Operation("Wage November", "Payment", employeeOne.Wage.WageTotal()));


                            Employee employeeTwo = new Employee("Michał", "Koszneruk", "Electrician")

                            {
                                Wage = new Wage(3000, 500, 350.50m),
                                Contract = Employee.ContractTypes.PartTime
                            };

                            employeeTwo.Operations.Add(new Operation("Wage September", "Payment", employeeTwo.Wage.WageTotal()));
                            employeeTwo.Operations.Add(new Operation("Wage December", "Payment", employeeTwo.Wage.WageTotal()));


                            Employee employeeThree = new Employee("Waldek", "Kozioła", "Smoker")

                            {
                                Wage = new Wage(4500, 1100, 250.50m),
                                Contract = Employee.ContractTypes.Contract
                            };

                            employeeThree.Operations.Add(new Operation("Wage April", "Payment", employeeThree.Wage.WageTotal()));
                            employeeThree.Operations.Add(new Operation("Wage May", "Payment", employeeThree.Wage.WageTotal()));

                            Employee employeeFour = new Employee("Grzegorz", "Mitas", "Actor")

                            {
                                Wage = new Wage(5000, 2800, 220.50m),
                                Contract = Employee.ContractTypes.FullTime
                            };

                            employeeFour.Operations.Add(new Operation("Wage June", "Payment", employeeFour.Wage.WageTotal()));
                            employeeFour.Operations.Add(new Operation("Wage July", "Payment", employeeFour.Wage.WageTotal()));

                            Employee employeeFive = new Employee("Łukasz", "Biedroń", "Cleaner")

                            {
                                Wage = new Wage(2140, 1100, 55.50m),
                                Contract = Employee.ContractTypes.PartTime
                            };

                            employeeFive.Operations.Add(new Operation("Wage February", "Payment", employeeFive.Wage.WageTotal()));
                            employeeFive.Operations.Add(new Operation("Wage March", "Payment", employeeFive.Wage.WageTotal()));

                            Employees Employees = new Employees();
                            Employees.EmployeesList.Add(employeeOne);
                            Employees.EmployeesList.Add(employeeTwo);
                            Employees.EmployeesList.Add(employeeThree);
                            Employees.EmployeesList.Add(employeeFour);
                            Employees.EmployeesList.Add(employeeFive);
                            Employee searchedEmployee = Employees["Grzegorz", "Mitas"];


                            Employees.PrintEmployees();

                            break;
                        case 4:
                            addemployee(key);
                            break;
                        case 5:
                            deleteemployee(key);
                            break;
                        case 6:
                            showclients(key);
                            Client clientOne = new Client("Robert", "Ziemiec");
                            Client clientTwo = new Client("Kasia", "Krzysztof");

                            Clients Clients = new Clients();
                            Clients.PrintClients();

                        break;
                        case 7:
                            back();
                            break;
                        default:
                            exit();
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                while (menu != 0);
            }
        

        private static void login(int key)
        {
            if (Security.LogIn() == true)
            {
                Console.WriteLine("You are corect Login");

            }

            else
            {
                Console.WriteLine("Wrong Password or login");
                Messages.PrintInColor("Login: szymon - passwd: zebro123", ConsoleColor.White);

            }
        }

        private static void logout(int key)
        {
            Console.WriteLine("You are Logout");
            Console.WriteLine("Prees Any Key To Start");
            Console.WriteLine();
           
        }


        private static void showemployees(int key)
        {
            Console.WriteLine();
            Console.WriteLine("All Employees");
        }

        private static void addemployee(int key)
        {
            Console.WriteLine();
            Console.WriteLine("Add Employee");
        }

        private static void deleteemployee(int key)
        {
            Console.WriteLine();
            Console.WriteLine("Delete Employee");
        }

        private static void showclients(int key)
        {
            Console.WriteLine();
            Console.WriteLine("All Clients");
        }

        private static void back()
        {
            Console.WriteLine();
        }

        private static void exit()
        {
            Console.WriteLine();
            Console.WriteLine("GOODBYE");
        }


        //// https://code.msdn.microsoft.com/windowsdesktop/Menu-em-Console-Application-b1309a1c


    }
}
