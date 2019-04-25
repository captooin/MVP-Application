using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Application_MVP.Classes
{
    public class Employee
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public Department department { get; set; }

        public Employee(string FN, string LN, int Age, int Salary, Department Dep)
        {
            firstname = FN;
            lastname = LN;
            age = Age;
            salary = Salary;
            department = Dep;
        }
    }
}
