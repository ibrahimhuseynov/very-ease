using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employees = new Employee();
            employees.Name = "Azad";
            Console.WriteLine(employees._name);
            employees.Salary = 350;
            Console.WriteLine(employees._salary);
            Console.ReadLine();
        }
    }
}
