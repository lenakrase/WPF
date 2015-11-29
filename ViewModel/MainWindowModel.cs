using System;
using System.Collections.Generic;
using Model;
using ViewModel.View.ViewModel;

namespace ViewModel
{
    public class MainWindowModel
    {
        public MainWindowModel()
        {
            FireCommand=new MyCommand(Fire);
        }

        private bool CanExecute(object o)
        {
            return SelectedEmployee != null && SelectedEmployee.IsDeleted == false;
        }

        public Employee SelectedEmployee { get; set; }

        public List<Employee> Employees { get; set; }
            = new List<Employee>
            {
                new Employee
                {
                    HireDate = DateTime.Now,
                    Name = "FirstMan"
                },

                new Employee
                {
                    HireDate = DateTime.Now,
                    Name = "SecondMan"
                }
            };

        public MyCommand FireCommand { get; set; }

        private void Fire()
        {
            SelectedEmployee.FireDate= DateTime.Now;
            SelectedEmployee.IsDeleted = true;
            
        }

    }
}
