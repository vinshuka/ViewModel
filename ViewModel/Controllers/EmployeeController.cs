﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;
using ViewModel.ViewModels;

namespace ViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };
            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };
            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };
            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }
    }

}
