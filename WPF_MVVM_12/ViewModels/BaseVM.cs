using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPF_MVVM_12.Models;

namespace WPF_MVVM_12.ViewModels
{
    internal class BaseVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));    
        }
        
        public event EventHandler ChangeWorker;
        private string nameWorker;
        public string NameWorker { 
                                    get { return nameWorker; } 
                                    set { nameWorker = value; ChangeWorker?.Invoke(this, new EventArgs()); } 
                                  }
        public BaseVM() 
        {   
            ChangeWorker += Client.EventHandler;
        }
    }

}
