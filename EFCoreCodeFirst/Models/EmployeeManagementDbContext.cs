using Microsoft.EntityFrameworkCore;

namespace EFCoreCodeFirst.Models
{
    internal class EmployeeManagementDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions
                 //.UseLazyLoadingProxies()
                .UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog = EmployeeManagementCodeFirst; User ID = sa; Password = Asdf@123456; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "HR"
                },
                new Department
                {
                    Id = 2,
                    Name = "IT"
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        EmpCode = "Long.Nguyen",
                        Name = "Long Nguyen",
                        Age = 18,
                        IsDelete = false,
                        CreatedDate = DateTime.UtcNow,
                        DepartmentId = 1,
                    },
                    new Employee
                    {
                        EmpCode = "Long.Hoang",
                        Name = "Long Hoang",
                        Age = 19,
                        IsDelete = false,
                        CreatedDate = DateTime.UtcNow,
                        DepartmentId = 2
                    },
                    new Employee
                    {
                        EmpCode = "Long.Manh",
                        Name = "Long Manh",
                        Age = 18,
                        IsDelete = false,
                        CreatedDate = DateTime.UtcNow,
                        DepartmentId = 1
                    }
                );
        }
    }
}
