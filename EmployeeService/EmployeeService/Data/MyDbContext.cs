using EmployeeService.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeService.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=HelloT2009MUpdatedContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}