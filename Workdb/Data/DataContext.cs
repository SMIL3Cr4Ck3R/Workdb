using Microsoft.EntityFrameworkCore;
using Workdb.Models;
using Workdb.WorkDTOs;

namespace Workdb.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {
            
        }    

        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTransferSalary> EmployeeTransferSalaries { get; set; }

    }
}
