using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Developer: Employee
    {
        public int YearExperiences { get; set; }

        public List<string> Skills { get; set; }

        public override string GetTasks()
        {
            return "Developer tasks";
        }

        public void SendMail(string mailFrom, string mailTo, string title,
            string content)
        {
            Console.WriteLine(@$"Developer send mail from {mailFrom} to {mailTo}
                    with title {title} and content {content}");
        }

        public void SendMail(string mailFrom, string mailTo, string mailCC,
            string title, string content)
        {
            Console.WriteLine(@$"Developer send mail from {mailFrom} to {mailTo}
                    and cc to {mailCC} with title {title} and content {content}");
        }

        public void SendMail(string mailFrom, string mailTo,
            string title, string content, bool active)
        {
            if (active)
                Console.WriteLine(@$"Developer send mail from {mailFrom} to {mailTo}
                     with title {title} and content {content}");
            else
                Console.WriteLine("Developer User disable");
        }

        public void SendMail(string mailFrom, string mailTo,
            string title, string content, int active)
        {
            if (active == 1)
                Console.WriteLine(@$"Developer send mail from {mailFrom} to {mailTo}
                     with title {title} and content {content}");
            else
                Console.WriteLine("Developer User disable");
        }
    }
}
