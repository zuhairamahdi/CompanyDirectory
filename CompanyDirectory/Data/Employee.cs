using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyDirectory.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoin { get; set; }
        public Department Department { get; set; }
        public Employee ReportsTo { get; set; }
    }
}
