using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_12.Models
{
    class Manager:IBankWorker
    {
        public void PrintClients()
        {
            throw new NotImplementedException();
        }

        public void ChangeTelefonNumber(int id, string number)
        {
            throw new NotImplementedException();
        }

        public void ChangePassportNumber(int id, string number)
        {
            throw new NotImplementedException();
        }

        public void ChangeFullName(int id, string fullName)
        {
            throw new NotImplementedException();
        }

        public void AddClient(string idDepartment, string fullName, string telefonNumber, string pasportNumber)
        {
            throw new NotImplementedException();
        }

        public void DelClient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
