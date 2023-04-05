using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_12.Models
{
    class Manager:IBankWorker
    {
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

        public void AddClient(Department department, string name, string surname, string patronymic, string telefonNumber, string pasportNumber)
        {
            department.clients.Add(new Client(
                            $"{department.DepartmentId}",
                            surname,
                            name,
                            patronymic,
                            telefonNumber,
                            pasportNumber,
                            $"{DateTime.Now}",
                            "Manager",
                            "created"
                            ));
            
        }

        public void DelClient(int id)
        {
            throw new NotImplementedException();
        }

        public string WorkerToString()
        {
            return "Manager";
        }
    }
}
