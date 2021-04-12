using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPI.Data
{
    public class Employeeinfo
    {
        [Key]
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String Department { get; set; }
        public int Salary { get; set; }

            }
}
