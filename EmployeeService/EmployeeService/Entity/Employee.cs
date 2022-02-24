using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeService.Entity
{
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string Salary { get; set; }
        [DataMember]
        public string Department { get; set; }
    }
}