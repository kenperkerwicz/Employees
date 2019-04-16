
using System;
using System.Collections.Generic;


//create a custom type for an employee add an employee that has: firstName, lastName, Title, StartDate
class Employee
{
  public string firstName {get; set;}
  public string lastName {get; set;}
  public string Title {get; set;}

  public DateTime StartDate;
   public DateTime dateConstructed {get; set;}

 public Employee (string name, string date)
    {
        StartDate = DateTime.Parse(date);
    }


 
}