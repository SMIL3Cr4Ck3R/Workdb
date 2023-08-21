using Workdb.Models;

namespace Workdb.WorkDTOs
{
    public class EmployeeDto
    {
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }
        public CityDto? EmployeeCity { get; set; }
        public List<EmployeeTransferSalaryDto>? EmployeeTransferSalaryList { get; set; }
    }
}
