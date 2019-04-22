using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();


            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.ID == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                emp.increaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

