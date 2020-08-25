using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            StaffManager manager = new StaffManager();
            manager.Menu();
        }

        // kan brytas ut i egen Class
        public class Staff
        {
            public string firstName;
            public string lastName;
            public int salary;


            public Staff(string firstName, string lastName, int salary)
            {
                //egenskaper
                this.firstName = firstName;
                this.lastName = lastName;
                this.salary = salary;
            }

            public string GetFirstName()
            {
                return firstName;
            }

            public string GetLastName()
            {
                return lastName;
            }

            public int GetSalary()
            {
                return salary;
            }

            public void SetFirstName(string firstName)
            {
                this.firstName = firstName;
            }

        }

        // kan brytas ut i egen Class
        public class StaffManager
        {
            //deklarera lista Personal
            private List<Staff> staffList;

            public StaffManager()
            {
                staffList = new List<Staff>();
            }
            public void Menu()
            {
                bool running = true;

                while (running)
                {
                    int choice = GetMenuChoice();

                    switch(choice)
                    {
                        case 1:
                            AddStaff();
                            break;
                        case 2:
                            ListAllStaff();
                            break;
                        case 3:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("\n Välj en siffra mellan 1 och 3");
                            break;
                    }
                }



            }

            private int GetMenuChoice()
            {
                Console.WriteLine("\nGör ett menuval med hjälp av siffrorna 1 till 3 ");
                Console.WriteLine("\n\t[1] Registrera ny personal ");
                Console.WriteLine("\n\t[2] Visa all personal");
                Console.WriteLine("\n\t[3] Avsluta");

                Console.WriteLine("\n\t skriv ditt val nu ");

                int menuVal;
                int.TryParse(Console.ReadLine(), out menuVal);

                return menuVal;
            }

            private void AddStaff()
            {
                Console.WriteLine("Add Firstname");
                string firstName = Console.ReadLine();

                Console.WriteLine("Add Lirstname");
                string lastName = Console.ReadLine();

                Console.WriteLine("Add Salary");
                int salary;
                int.TryParse(Console.ReadLine(), out salary);

               

                bool run = true;

                while(run)
                {
                    Staff staffPerson = new Staff(firstName, lastName, salary);
                    staffList.Add(staffPerson);
                    break;

                    //Console.WriteLine("Personal sparad");
                }
            }

            private void ListAllStaff()
            {
                if (staffList.Count <= 0)
                {
                    Console.WriteLine("Finns ingen listad personal");
                }
                else
                {
                    Console.WriteLine("Befintlig personal:");
                    foreach (Staff item in staffList)
                    {

                        Console.WriteLine("\n\t********************");
                        Console.WriteLine("\n\t " + item + "\n");
                    }
                }
            }
        }

    }

    
}
