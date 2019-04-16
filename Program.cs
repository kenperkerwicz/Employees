using System;
using System.Collections.Generic;


namespace classes
{
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.

        // Create three employees

        // Assign the employees to the company

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

        Employee Ken = new Employee("ken", "01/07/2007") {
            firstName = "Ken",
            lastName = "Perk",
            Title = "Owner"
        };

        Employee Chad = new Employee("chad", "01/08/2000") {
            firstName = "chad",
            lastName = "carl",
            Title = "employee"
        };


        Employee Bob = new Employee("bob", "01/08/1999") {
            firstName = "Bob",
            lastName = "Barker",
            Title = "employee"
        };


// creating a new instance of Company, and 3 instances of Employee. Then assign the employees to the company.


        Company KenCo = new Company ("Apple INC.", "04/04/2000");

        KenCo.HireEmployee(Ken);
        KenCo.HireEmployee(Chad);
        KenCo.HireEmployee(Bob);

        KenCo.ListEmployees();
    }


}}