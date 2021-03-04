using System;
using System.Collections.Generic;

namespace Classes
{
  public class Company
  {
  // Some readonly properties (let's talk about gets, baby)
    public String Name {get; }
    public DateTime CreatedOn { get; }
    // Create a public property for holding a list of current employees
    public List<Employee> EmployeeList { get; set;}
    
    /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
    public Company(string name, DateTime createdOn, List<Employee> employeeList)
    {
      Name = name;
      CreatedOn = createdOn;
      EmployeeList = employeeList;
    }

    // The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
    public void ListEmployees()
    {
      foreach (Employee employee in EmployeeList)
      {
      Console.WriteLine($"{employee.FullName} works for {Name} as {employee.Title} since {employee.StartDate.ToString("MM/dd/yyyy")}");
      }
    }
  }
}
