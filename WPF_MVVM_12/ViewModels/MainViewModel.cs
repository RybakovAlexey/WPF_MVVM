using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_MVVM_12.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
                public event PropertyChangedEventHandler? PropertyChanged;

                public void OnPropertyChenged([CallerMemberName]string prop = "")
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
                }

        private int _Clicks;
        public int Clicks
        {
            get { return _Clicks; }
            set
            {
                _Clicks = value;
                OnPropertyChenged();
            }
        }

        //       public MainViewModel() 
        //       {
        //           Task.Factory.StartNew(() =>
        //           {
        //               while (true)
        //               {
        //                   Task.Delay(1000).Wait();
        //                   Clicks++;
        //               }
        //           });
        //       }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Clicks++;
                },(obj)=>Clicks<20);

            }

        }
    }
}

