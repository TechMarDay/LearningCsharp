using EmployeeManagement.AbstractClass;
using EmployeeManagement.Interface;

namespace EmployeeManagement.RegularClass
{
    public class Developer : Employee, ISendMail, IExportExcelReport, IExportPdfFile
    {
        public List<string> DevSkills { get; set; }

        public void ExportExcelReport()
        {
            Console.WriteLine("Developer export excel report");
        }

        public void ExportPdfReport()
        {
            Console.WriteLine("Developer export pdf file");
        }

        public override void GetEmployeeSkills()
        {
            Console.WriteLine($"Developer skilss: {string.Join(";", DevSkills)}");
        }

        public override void GetTasks()
        {
            Console.WriteLine("Developer tasks");
        }

        public void SendImportantMail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Developer mail:Send important mail from {mailFrom} to {mailTo}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string title, string content)
        {
            Console.WriteLine($"Developer mail:Send regualr mail from {mailFrom} to {mailTo}");

        }

        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string conent)
        {
            Console.WriteLine($"Developer mail:Send regualr mail from {mailFrom} to {mailTo} cc {mailCC}");

        }
    }
}
