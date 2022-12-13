using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebFormProject.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("WebFormProject")
        {

        } 
        public DbSet<Employee> Employees { get; set; }
    }
}