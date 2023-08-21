namespace Workdb.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }
        public City? EmployeeCity { get; set; }
        public List<EmployeeTransferSalary>? EmployeeTransferSalaryList { get; set; }
    }
}
