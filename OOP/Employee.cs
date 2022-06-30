using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Employee
    {
        //Là đại diện cho đối tượng có chung các đặc điểm, hành vi, phương thức hoạt động.

        public string Empcode { get; set; } //auto-implemented property

        public string FristName { get; set; }

        public string LastName { get; set; }

        private DateTime _DateOfBirth; //Field

        internal int Age { get; set; }

        //property
        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                _DateOfBirth = value;
            }
        }

        public string GetFullName()
        {
            return $"{FristName} {LastName}";
        }

        public virtual string GetTasks()
        {
            return string.Empty;
        }

    }
}
