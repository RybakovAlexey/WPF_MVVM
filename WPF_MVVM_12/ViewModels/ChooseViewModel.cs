using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Animation;
using WPF_MVVM_12.Views;

namespace WPF_MVVM_12.ViewModels
{
    class ChooseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChenged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public ICommand ClickManager
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ManagerWindow ManagerWindow = new ManagerWindow();
                    ManagerWindow.Show();
                });
            }
        }

        public ICommand ClickConsultant
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ConsultantWindow ConsultantWindow = new ConsultantWindow();
                    ConsultantWindow.Show();
                });
            }
        }

    }
}
