using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_12.Models
{
    class Client
    {
        public string IdDepartment { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string TelefonNumber { get; set; }
        public string PasportNumber { get; set; }
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
