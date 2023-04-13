
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_12.Models;


namespace WPF_MVVM_12.ViewModels
{
    class ManagerViewModel: BaseVM
    {
        IBankWorker worker = new Manager();
        BankRepo repo = new BankRepo();
        public ObservableCollection<Department> Departments{get { return repo.Departments; } }

        private Department selectedDepartament=new Department("",0,new BindingList<Client>());

        public Department SelectedDepartment {
            get { return selectedDepartament; }
            set {selectedDepartament = value; OnPropertyChanged("SelectedDepartment");
            }
        }
       
        private Department selectedDepartmentToAdd;
        public Department SelectedDepartmentToAdd {set { selectedDepartmentToAdd = value; }}

        private string nameAdd;
        public string NameAdd { set { nameAdd = value; OnPropertyChanged("NameAdd"); } }

        private string surnameAdd;
        public string SurnameAdd { set {  surnameAdd = value; OnPropertyChanged("SurnameAdd"); } }

        private string patronymicAdd;

        public string PatronymicAdd { set {  patronymicAdd = value; OnPropertyChanged("PatronymicAdd"); } }

        private string telefonAdd;
        public string TelefonAdd { set { telefonAdd = value; OnPropertyChanged("TelefonAdd"); } }

        private string passportAdd;

        public string PassportAdd { set { passportAdd = value; OnPropertyChanged("PassportAdd"); } }

        public ManagerViewModel()
        {
            repo.ReadFromBase();
            NameWorker = worker.NameToString();
        }



        public ICommand ClickSave => new DelegateCommand((obj) =>
                                                  {
                                                      repo.SaveInBase();
                                                      Application.Current.Shutdown();
                                                  });
        public ICommand ClickAdd => new DelegateCommand((obj) =>
        {
            worker.AddClient(selectedDepartmentToAdd, nameAdd, surnameAdd, patronymicAdd, telefonAdd, passportAdd);
            ClearAddFields();
        }, (obj) => AddFieldsNotEmpty());
        
        private void ClearAddFields()
        {
            NameAdd = null;
            SurnameAdd = null;
            PatronymicAdd = null;
            TelefonAdd = null;
            PassportAdd = null;
        }

        private bool AddFieldsNotEmpty()
        {
            return 
                    selectedDepartmentToAdd != null &&
                    nameAdd != null &&
                    surnameAdd != null &&
                    patronymicAdd != null &&
                    telefonAdd != null &&
                    passportAdd != null;
        }
    }
}
