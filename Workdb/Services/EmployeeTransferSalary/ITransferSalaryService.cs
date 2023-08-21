using Workdb.WorkDTOs;

namespace Workdb.Services.EmployeeTransferSalary
{
    public interface ITransferSalaryService 
    {
        Task<List<EmployeeTransferSalaryDto>> GetSalariesList();
    }
}
