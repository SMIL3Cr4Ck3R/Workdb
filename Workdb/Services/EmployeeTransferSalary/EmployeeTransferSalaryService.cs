using Microsoft.EntityFrameworkCore;
using Workdb.Data;
using Workdb.WorkDTOs;

namespace Workdb.Services.EmployeeTransferSalary
{
    public class EmployeeTransferSalaryService : ITransferSalaryService
    {
        private readonly DataContext _dataContext;

        public EmployeeTransferSalaryService(DataContext dataContext) {
        
            _dataContext = dataContext;
            
        }

        public Task<List<EmployeeTransferSalaryDto>> GetSalariesList()
        {
            throw new NotImplementedException();
        }
    }
}
