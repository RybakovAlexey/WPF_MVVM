﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_12.ViewModels;

namespace WPF_MVVM_12.Models
{
    class Department
    {
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }

        public BindingList<Client> clients { get; set; }

        public Department(string DepartmentName, int DepartmentId, BindingList<Client> clients)
        {
            this.DepartmentName = DepartmentName;
            this.DepartmentId = DepartmentId;
            this.clients = clients;
        }
    }
}
