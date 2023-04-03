using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_12.ViewModels;

namespace WPF_MVVM_12.Models
{
    class Client: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            Debug.WriteLine($"{this.IdDepartment} {this.Surname} {prop} was changed");
        }
        public string IdDepartment { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        private string telefonNumber;
        public string TelefonNumber { get { return telefonNumber; } set { telefonNumber = value; OnPropertyChanged("TelefonNumber"); } }
        private string pasportNumber;
        public string PasportNumber { get { return pasportNumber; } set { pasportNumber = value; OnPropertyChanged("PasportNumber"); } }
        public string DataChange { get; set; }
        public string WhoChange { get; set; }
        public string WhatChange { get; set; }



        public Client(
            string IdDepartment,
            string Surname,
            string Name,
            string Patronymic,
            string TelefonNumber,
            string PasportNumber,
            string DataChange,
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
            this.DataChange = DataChange;
            this.WhoChange = WhoChange;
            this.WhatChange = WhatChange;
        }
    }
}
