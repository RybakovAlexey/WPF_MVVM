using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPF_MVVM_12.ViewModels;

namespace WPF_MVVM_12.Models
{
    class Client: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (!prop.Equals(nameof(DateChange)) && !prop.Equals(nameof(WhoChange)) && !prop.Equals(nameof(WhatChange)))
            {
                this.DateChange = $"{DateTime.Now}";
                this.WhatChange = $"{prop}";
                this.WhoChange = nameWorker;
                Debug.WriteLine($"{this.IdDepartment} {this.Surname} {prop} was changed ");
            }
            
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            
        }

        internal static void ClientPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Manager")) { nameWorker = e.PropertyName; }
            if (e.PropertyName.Equals("Consultant")) { nameWorker = e.PropertyName; }

        }

        static string nameWorker;
        public string IdDepartment { get; set; }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged("Surname"); }
        }
        private string name;
        public string Name 
        { 
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); } 
        }
        private string patronymic;
        public string Patronymic 
        {
            get { return patronymic; }
            set { patronymic = value; OnPropertyChanged("Patronymic"); } 
        }
        private string telefonNumber;
        public string TelefonNumber 
        { 
            get { return telefonNumber; } 
            set { telefonNumber = value; OnPropertyChanged("TelefonNumber"); } 
        }
        private string pasportNumber;
        public string PasportNumber 
        { 
            get { return pasportNumber; } 
            set { pasportNumber = value; OnPropertyChanged("PasportNumber"); } 
        }
        private string dateChange;
        public string DateChange 
        { 
            get { return dateChange; } 
            set { dateChange = value; OnPropertyChanged("DateChange"); } 
        }
        private string whoChange;
        public string WhoChange
        {
            get { return whoChange; }
            set { whoChange = value; OnPropertyChanged("WhoChange"); } }
        private string whatChange;
        public string WhatChange
        {
            get { return whatChange; }
            set { whatChange = value; OnPropertyChanged("WhatChange"); }
        }

        public Client(
            string IdDepartment,
            string Surname,
            string Name,
            string Patronymic,
            string TelefonNumber,
            string PasportNumber,
            string DateChange,
            string WhoChange,
            string WhatChange
            )
        {
            this.IdDepartment = IdDepartment;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.TelefonNumber = TelefonNumber;
            this.PasportNumber = PasportNumber;
            this.DateChange = DateChange;
            this.WhoChange = WhoChange;
            this.WhatChange = WhatChange;
        }

    }
}
