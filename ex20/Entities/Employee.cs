using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex20.Entities
{
    class Employee
    {

        public String Name { get; set; }
        public String Email { get; set; }
        public Double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}