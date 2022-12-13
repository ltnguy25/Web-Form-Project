using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebFormProject.Models
{
    public class EmployeeDatabaseInitializer : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            GetEmployees().ForEach(employee => context.Employees.Add(employee));
        }

        private static List<Employee> GetEmployees()
        {
            var employees = new List<Employee> {
                new Employee
                {
                    ID = 1,
                    FirstName = "Luan",
                    LastName = "Nguyen",
                    DOB = new DateTime(1995, 12, 06),
                    Email = "luan.nguyen@cognizant.com",
                    PhoneNumber = "6232826605",
                    StartDate = new DateTime(2022, 08, 18)
                }
            };
        
           return employees;
        }
    }
}