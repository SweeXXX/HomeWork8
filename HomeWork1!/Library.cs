using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Employer
    {
        Employer EmployerHead;
        string Department;
        string Role;
        string Name;
        public Employer(string Department, string Role, string name)
        {
            this.Department = Department;
            this.Role = Role;
            this.Name = name;
        }
        public Employer(Employer employerHead, string department, string role, string name)
        {
            EmployerHead = employerHead;
            Department = department;
            Role = role;
            Name = name;
        }
        public string GetTitle
        {
            get { return $"{Department}-{Role}-{Name}"; }
        }
        public string GetHead
        {
            get { return EmployerHead.GetTitle; }
        }
        public bool TakeTask(Employer p)
        {
            if (EmployerHead == p)
                return true;
            return false;
        }
    }
}
