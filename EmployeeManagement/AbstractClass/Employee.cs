
namespace EmployeeManagement.AbstractClass
{
    public abstract class Employee
    {
        public string EmpCode { get; set; }

        public string FristName { get; set; }

        public string LastName { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"{FristName} {LastName}");
        }

        public abstract void GetTasks();

        public abstract void GetEmployeeSkills();
    }
}
