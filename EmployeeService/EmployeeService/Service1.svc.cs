using EmployeeService.Data;
using EmployeeService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MyDbContext dbContext = new MyDbContext();
        public Employee Save(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }
        public List<Employee> GetList()
        {
            return dbContext.Employees.ToList();
        }

      
    }
}
