using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Input;
using System.Windows.Media.Animation;
using WPF_MVVM_12.Models;
using WPF_MVVM_12.Views;

namespace WPF_MVVM_12.ViewModels
{
    class ManagerViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChenged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        BankRepo repo = new BankRepo();
        IBankWorker worker = new Manager();
        public ObservableCollection<Department> Departments
        {
            get { return BankRepo.Departments; }
            set { }
        }
        private Department selectedDepartament;
        public Department SelectedDepartment {

            set { 
                selectedDepartament = value; 
                OnPropertyChenged(); }
        }

        public Department GetDepartment {
            get { return selectedDepartament; } 
            set { selectedDepartament = value; } 
        }

        public ManagerViewModel() {

;
            repo.AddClients();
            //repo.ReadClients();     
            
        }

        public ICommand ClickSave => new DelegateCommand((obj) =>
                                                  {
                                                      repo.SaveClientsAsync();
                                                  });
        public ICommand ClickAdd => new DelegateCommand((obj) =>
        {
            worker.AddClient("1","qqq", "123", "345");
        });
    }
}
