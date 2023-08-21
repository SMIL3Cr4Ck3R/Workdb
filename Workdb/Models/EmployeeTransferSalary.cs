namespace Workdb.Models
{
    public class EmployeeTransferSalary
    {
        public int EmployeeTransferSalaryId { get; set; }
        public Employee Employee { get; set; }
        public DateTime TransferDate { get; set; }
        public int MonthOfTransfer { get; set; }


    }
}
