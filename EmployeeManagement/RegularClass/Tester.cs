using EmployeeManagement.AbstractClass;
using EmployeeManagement.Interface;

namespace EmployeeManagement.RegularClass
{
    public class Tester: Employee, ISendMail, IExportExcelReport
    {
        public List<string> TesterSkills { get; set; }

        public void ExportExcelReport()
        {
            Console.WriteLine("Tester export excel report");
        }

        public override void GetEmployeeSkills()
        {
            Console.WriteLine($"Tester skilss: {string.Join(";", TesterSkills)}");
        }

        public override void GetTasks()
        {
            Console.WriteLine("Testers tasks");
        }

        public void SendImportantMail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Tester mail:Send important mail from {mailFrom} to {mailTo}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Tester mail:Send regualar mail from {mailFrom} to {mailTo}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string conent)
        {
            Console.WriteLine($"Tester mail:Send regualr mail from {mailFrom} to {mailTo} cc {mailCC}");
        }
    }
}
