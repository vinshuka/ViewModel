﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class Employee
    {
        public Employee()
        {
            Name = "";
            Gender = "";
            Department = "";

        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int AddressId { get; set; }
    }
}