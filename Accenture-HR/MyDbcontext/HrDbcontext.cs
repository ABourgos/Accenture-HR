using Accenture_HR.Models;
using Microsoft.EntityFrameworkCore;
namespace Accenture_HR.MyDbcontext
{
    public class HrDbcontext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public HrDbcontext()
        {
        }
        public HrDbcontext(DbContextOptions<HrDbcontext> options) 
            : base(options) 
        { 
        }
    }
}
