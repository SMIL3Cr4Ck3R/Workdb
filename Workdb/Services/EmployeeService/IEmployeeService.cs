using Workdb.WorkDTOs;

namespace Workdb.Services.EmployeeService
{
    public interface IEmployeeService
    {
        
        Task<List<EmployeeDto>> GetEmployeesList();
        Task<EmployeeDto> AddNewEmployee(EmployeeDto employee);
    }
}
