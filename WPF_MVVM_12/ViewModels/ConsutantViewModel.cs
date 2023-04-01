using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_12.Models;

namespace WPF_MVVM_12.ViewModels
{
    internal class ConsutantViewModel:BaseVM
    {

        BankRepo repo = new BankRepo();
        IBankWorker worker = new Consultant();

        public ObservableCollection<Department> Departments
        {
            get { return repo.Departments; }
        }

        private Department selectedDepartament;
        public Department SelectedDepartment
        {
            get { return selectedDepartament; }
            set { selectedDepartament = value; OnPropertyChanged("SelectedDepartment"); }
        }

        public ConsutantViewModel()
        {
            repo.ReadFromBase();     
        }

        public ICommand ClickSave => new DelegateCommand((obj) =>
        {
            repo.SaveInBase();
            Application.Current.Shutdown();
        });
    }
}
