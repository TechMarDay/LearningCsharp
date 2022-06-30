using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Tester: Employee
    {

        public List<string> TesterSkills { get; set; }

        public override string GetTasks()
        {
            return "Tester tasks";
        }
    }
}
