using Workdb.Models;

namespace Workdb.WorkDTOs
{
    public class EmployeeTransferSalaryDto
    {
        public Employee? Employee { get; set; }
        public DateTime TransferDate { get; set; }
        public int MonthOfTransfer { get; set; }
    }
}
