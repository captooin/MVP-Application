using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Application_MVP.Classes
{
    class Presenter
    {
        private IView view;
        private Model model;


        public Presenter(IView View)
        {
            this.view = View;
            model = new Model();
        }

        public void LoadData()
        {
            view.DepartmentList = model.DepartmentList;
            view.EmployeeList = model.EmployeeList;
        }

        public void AddDepartment()
        {
            model.DepartmentList.Add(new Department($"Dep_{model.DepartmentList.Count + 1}"));
        }

        public void AddEmloyee()
        {
            model.EmployeeList.Add(new Employee($"Worker_{model.EmployeeList.Count + 1}",
                $"Workers_{model.EmployeeList.Count + 1}",
                model.rnd.Next(18, 35), model.rnd.Next(20000, 50000),
                model.DepartmentList[model.rnd.Next(model.DepartmentList.Count)]));
        }
    }
}
