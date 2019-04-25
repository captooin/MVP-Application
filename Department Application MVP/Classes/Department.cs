using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Application_MVP.Classes
{
    public class Department
    {
        public string name { get; set; }

        public Department (string Name)
        {
            name = Name;
        }
    }
}
