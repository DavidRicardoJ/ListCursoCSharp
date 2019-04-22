using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListCursoCSharp
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary *= (1 + percentage/100);
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
