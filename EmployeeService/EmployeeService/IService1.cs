﻿using EmployeeService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Employee Save(Employee Employee);
        [OperationContract]

        List<Employee> GetList(string department);
              
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
