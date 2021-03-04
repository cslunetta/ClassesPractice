using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company littleMoon = new Company("Little Moon, LLC.", new DateTime(2021, 1,25), new List<Employee>());

            // Create three employees
            Employee john = new Employee("John", "Smith", "CIO", new DateTime(2021, 1 , 27));
            Employee jane = new Employee("Jane", "Doe", "CEO", new DateTime(2021, 1 , 25));
            Employee sarah = new Employee("Sarah", "Scott", "CMO", new DateTime(2021, 2 , 1));

            // Assign the employees to the company
            littleMoon.EmployeeList.Add(john);
            littleMoon.EmployeeList.Add(jane);
            littleMoon.EmployeeList.Add(sarah);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            littleMoon.ListEmployees();
        }
    }
}