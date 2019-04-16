
using System;
using System.Collections.Generic;

//created a custom type for Company. create the following properties: dateFounded, CompanyName, Employees
class Company {


   public DateTime CreatedOn { get; }
  private DateTime _dateFounded {get; set;}
  public string companyName {get; set;}
  public string Employees {get; set;}

    public string Name { get; }

public List<Employee> CurrentEmployees = new List<Employee>();

public Company (string name, string yearEst) {
        Name = name;
        CreatedOn = DateTime.Parse(yearEst);
}

 public void HireEmployee(Employee employee)

    {
        CurrentEmployees.Add(employee);

    }


// list Employees method which outputs the name of each employee to the console.


    public void ListEmployees()
    {
        foreach (Employee employee in CurrentEmployees)
        {
            Console.WriteLine($"{employee.firstName} {employee.lastName} works for {Name} as {employee.Title} since {employee.StartDate}");
        }
    }

}

