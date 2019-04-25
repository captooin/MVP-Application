using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Department_Application_MVP.Classes
{
    public interface IView
    {
        ObservableCollection<Employee> EmployeeList { get; set; }
        ObservableCollection<Department> DepartmentList { get; set; }
    }
}
