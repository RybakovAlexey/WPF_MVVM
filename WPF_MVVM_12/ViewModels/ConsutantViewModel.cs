﻿
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_12.Models;

namespace WPF_MVVM_12.ViewModels
{
    internal class ConsutantViewModel:BaseVM
    {
        

        IBankWorker worker = new Consultant();
        BankRepo repo = new BankRepo();

        public ObservableCollection<Department> Departments
        {
            get { return repo.Departments; }
        }

        private Department selectedDepartament;
        public Department SelectedDepartment
        {
            get { return selectedDepartament; }
            set { selectedDepartament = value; OnPropertyChanged("SelectedDepartment");}
        }

        public ConsutantViewModel()
        {
            repo.ReadFromBase();
            
            NameWorker = worker.NameToString();
        }

        public ICommand ClickSave => new DelegateCommand((obj) =>
        {
            repo.SaveInBase();
            Application.Current.Shutdown();
        });
    }
}
