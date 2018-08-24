using System;
using System.Collections.Generic;

public class Company {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> Employees { get; } = new List<Employee>();

    public void ListEmployees (Employee employee) {
            System.Console.WriteLine ($"{employee.FirstName} {employee.LastName} works as a {employee.Title} for {this.Name} since {employee.StartDate}.");
    }

    public void AddEmployee (Employee EmployeeName) {
        Employees.Add(EmployeeName); 
    }

    public Company (string name, DateTime created) {
        Name = name;
        CreatedOn = created;
    }
}
/*
    Create a constructor method that accepts two arguments:
        1. The name of the company
        2. The date it was created
    The constructor will set the value of the public properties
*/

public class Employee {

    public string FirstName { get; }
    public string LastName { get; }
    public string Title { get; }
    public string StartDate { get; }

    public Employee (string firstName, string lastName, string title, string startDate) {
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        StartDate = startDate;
    }
}
namespace Classes {

}

class Program {
    static void Main (string[] args) {
        // Create an instance of a company. Name it whatever you like.

        Company Tesla = new Company ("Tesla", new DateTime(2008, 7, 14));

        Employee William = new Employee ("William", "Kimball", "Chief", new DateTime(2012, 8, 14).ToString("dd/MM/yyyy"));
        Employee Sathvik = new Employee ("Sathvik", "Reddy", "Other Chief", new DateTime(2014, 2, 03).ToString("dd/MM/yyyy"));
        Employee Natasha = new Employee ("Natasha", "Cox", "Other Other Chief", new DateTime(2013, 6, 30).ToString("dd/MM/yyyy"));

        Tesla.AddEmployee(William);
       Tesla.Employees.Add(Sathvik);
       Tesla.AddEmployee(Natasha);

       foreach (Employee Name in Tesla.Employees)
       {
           Tesla.ListEmployees(Name);
       }

        //  Tesla.Employees.Add()

        // Create three employees

        // Assign the employees to the company

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}