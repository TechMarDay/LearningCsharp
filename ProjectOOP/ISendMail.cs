using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOOP
{
    public interface ISendMail
    {
        public void SendEmail(string mailFrom, string mailTo, string title, string content);
    }
}