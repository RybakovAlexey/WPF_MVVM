using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_12.Models
{
    interface IBankWorker
    {
        public void ChangeTelefonNumber(int id, string number);

        public void ChangePassportNumber(int id, string number);


        public void ChangeFullName(int id, string fullName);


        public void AddClient(
            string idDepartment,
            string fullName,
            string telefonNumber,
            string pasportNumber);


        public void DelClient(int id);
    }
}

