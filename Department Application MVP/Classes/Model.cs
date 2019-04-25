using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Department_Application_MVP.Classes
{
    class Model
    {
        public ObservableCollection<Department> DepartmentList;
        public ObservableCollection<Employee> EmployeeList;
        public Random rnd = new Random();
        public Model()
        {

            DepartmentList = new ObservableCollection<Department>();
            EmployeeList = new ObservableCollection<Employee>();

            for (int i = 0; i < 5; i++)
                DepartmentList.Add(new Department($"Dep_{i + 1}"));

            for (int i = 0; i < 15; i++)
                EmployeeList.Add(new Employee($"Worker_{i + 1}", $"Workers_{i + 1}", rnd.Next(18, 35), rnd.Next(20000, 50000), DepartmentList[rnd.Next(DepartmentList.Count)]));
        }
    }
}
