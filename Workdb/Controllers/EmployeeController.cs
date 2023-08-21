using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workdb.Models;
using Workdb.Services.EmployeeService;
using Workdb.TasksSchedualing;
using Workdb.WorkDTOs;

namespace Workdb.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getEmployees")]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployeesList() {
            
            var listMapped = await _employeeService.GetEmployeesList();

            return Ok(listMapped);
            
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> addNewEmployee (EmployeeDto Employee)
        {
            return Ok(await _employeeService.AddNewEmployee(Employee));
        }

        [HttpGet("sendMessage")]
        public IActionResult SendMessageToEmployee(string employeeEmail) {
        
            ScheduleTasks.monthlyEmployeeSalaryMail(employeeEmail);
            return Ok("sent!");
            
        }
    }
}
