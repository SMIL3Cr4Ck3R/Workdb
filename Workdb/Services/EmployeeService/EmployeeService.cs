using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Workdb.Data;
using Workdb.Models;
using Workdb.WorkDTOs;


namespace Workdb.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {

        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public EmployeeService(DataContext dataContext, IMapper mapper) {
        
            _dataContext = dataContext;
            _mapper = mapper;
       
        }

        public async Task<EmployeeDto> AddNewEmployee(EmployeeDto employee)
        {
            var newRecord = _mapper.Map<Employee>(employee);
            await _dataContext.AddAsync(newRecord);
            await _dataContext.SaveChangesAsync();
            return employee;
        }

        public async Task<List<EmployeeDto>> GetEmployeesList()
        {
            var employeeModel = await _dataContext.Employees.Include(City => City.EmployeeCity).Include(Salary => Salary.EmployeeTransferSalaryList).ToListAsync();
            return _mapper.Map<List<EmployeeDto>>(employeeModel);
        }
    }
}
