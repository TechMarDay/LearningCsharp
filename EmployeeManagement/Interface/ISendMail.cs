using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Interface
{
    public interface ISendMail
    {
        void SendRegularMail(string mailFrom, string mailTo, string title, string content);

        void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string conent);

        void SendImportantMail(string mailFrom, string mailTo, string title, string content);

    }
}
