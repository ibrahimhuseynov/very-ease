using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        public string _name;
        private  int EmployeeLimit;
        private  int SalaryLimit;
        public Employees[] emp = new Employees[0];
        static string AddEmployee( string  Employees)

        {
            if (Employees.Length < SalaryLimit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = Employees;
            }
        }
    }
}
