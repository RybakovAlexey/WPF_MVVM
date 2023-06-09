﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WPF_MVVM_12.ViewModels;

namespace WPF_MVVM_12.Models
{
    class BankRepo:BaseVM
    {
        public  ObservableCollection<Department> Departments { get; set; }
        private BindingList<Client> Clients { get; set; }



    public void ReadFromBase()
        {
            using (FileStream fs1 = new FileStream("bankDepartments.json", FileMode.OpenOrCreate))
            {
                if (fs1.Length != 0)
                {
                    Departments = JsonSerializer.Deserialize<ObservableCollection<Department>>(fs1);
                    Debug.Print("Data departments has been read");
                }
                else CreateBase();
            }
        }


        public void SaveInBase()
        {
            using (FileStream fs = new FileStream("bankDepartments.json", FileMode.Create))
            {
                JsonSerializer.Serialize<ObservableCollection<Department>>(fs, Departments);
                Debug.Print("Data Departments has been saved to file");
            }
        }
        public void CreateBase()
        {
            Departments = new ObservableCollection<Department>();
            int Count = 5;

            for (int d = 1; d < Count; d++)
            {
                Clients = new BindingList<Client>();

                for (int c = 1; c < 4; c++)
                {
                    Clients.Add(
                        new Client(
                            $"{d}",
                            $"Фамилия{d}{c}",
                            $"Имя{d}{c}",
                            $"Отчество{d}{c}",
                            $"899988877{d}{c}",
                            $"98765432{d}{c}",
                            $"{DateTime.Now}",
                            "admin",
                            "created"
                            ));
                }
                Departments.Add(new Department($"департамент{d}", d, Clients));
            }
            Debug.Print("Data Departments has been created");
        }
    }
}
