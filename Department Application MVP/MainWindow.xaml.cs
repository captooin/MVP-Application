using Department_Application_MVP.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Department_Application_MVP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Presenter(this);
            p.LoadData();

            btnAddDep.Click += delegate { p.AddDepartment(); };
            btnAddEmp.Click += delegate { p.AddEmloyee(); };
            btnEditDep.Click += delegate
            {
                new EditDepartmentWindow(DepartmentView.SelectedItem as Department).ShowDialog();
            };

        }


        public ObservableCollection<Employee> EmployeeList { get => (ObservableCollection<Employee>)EmloyeeView.ItemsSource; set => EmloyeeView.ItemsSource = value; }
        public ObservableCollection<Department> DepartmentList { get => (ObservableCollection<Department>)DepartmentView.ItemsSource; set =>  DepartmentView.ItemsSource = value;  }
    }
}
