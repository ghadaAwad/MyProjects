using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTAPI.Data;
using RESTAPI.Services;

namespace RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeServiceDapper empService = new EmployeeServiceDapper();
        public async Task<IEnumerable<Employeeinfo>> GetEmployee()
        {
            return await empService.GetEmployee();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Employeeinfo GetEmployeeByID(int id)
        {
            return empService.GetEmployeeByID(id);
        }
        [HttpPost]
        public void AddEmployee(Employeeinfo ecAdd)
        {
            empService.AddEmployee(ecAdd);
        }
        [HttpPut]
        public void UpdateEmp(Employeeinfo Emp)
        {
            empService.UpdateEmp(Emp);
        }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void DeleteEmp(int id)
        {
            empService.DeleteEmp(id);
        }
    }
}
