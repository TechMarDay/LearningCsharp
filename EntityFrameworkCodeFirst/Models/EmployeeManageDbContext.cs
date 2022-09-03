using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Models
{
    //DbContext: Tương ứng database và connection, action update, delete, update...
    //
    //DbSet: tương ứng table trong database


    public class EmployeeManageDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=EmployeeManagementCodeFirst;User ID=sa;Password=Asdf@123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //https://www.learnentityframeworkcore.com/migrations/seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Thêm dữ liệu mặc định cho table department
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "HR",
                    CreatedDate = DateTime.UtcNow
                },
                new Department
                {
                    Id = 2,
                    Name = "IT",
                    CreatedDate = DateTime.UtcNow
                },
                new Department
                {
                    Id = 3,
                    Name = "Sales",
                    CreatedDate = DateTime.UtcNow
                }
                );

            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        EmpCode = "Long.Nguyen",
                        FristName = "Long",
                        LastName = "Nguyen",
                        Age = 18,
                        DepartmentId = 2,
                        CreatedDate = DateTime.UtcNow
                    },
                    new Employee
                    {
                        Id = 2,
                        EmpCode = "Long.Hoang",
                        FristName = "Long",
                        LastName = "Hoang",
                        Age = 18,
                        DepartmentId = 1,
                        CreatedDate = DateTime.UtcNow
                    },
                    new Employee
                    {
                        Id = 3,
                        EmpCode = "Long.Manh",
                        FristName = "Long",
                        LastName = "Manh",
                        Age = 19,
                        DepartmentId = 2,
                        CreatedDate = DateTime.UtcNow
                    }
                );
        }
    }
}
