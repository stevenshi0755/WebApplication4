using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    //public class Customer
    //{
    //    public string CustomerName { get; set; }
    //    public string Address { get; set; }
    //}
    public class EmployeeController : Controller
    {
        //[NonAction]
        //public string GetCustomer()
        //{
        //    Customer c = new Customer();
        //    c.CustomerName = "Customer 1";
        //    c.Address = "Address 1";
        //    return c.CustomerName + "|" + c.Address;
        //}
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
        public string SaveEmployee(Employee e, string BtnSubmit)
        {
            //string mString = "";
            switch (BtnSubmit)
            {
                case "Save Employee":
                   // mString = e.FirstName + "|" + e.LastName + "|" + e.Salary;
                    //break;
                    return e.FirstName + "|" + e.LastName + "|" + e.Salary;
                case "Cancel":
                    return RedirectToAction("Index");
            }
            //return Content(mString);
            return new EmptyResult();

        }
            public ActionResult Index()
        {
            /*
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }
            
            //vmEmp.UserName = "Admin";
            return View("myview", vmEmp);
            //ViewData["Employee"] = emp;
            //ViewBag.Employee = emp;
            //return View("MyView",emp);
            */

            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            //employeeListViewModel.UserName = "Admin";
            return View("Index", employeeListViewModel);
        }

        //个人练习
        //public ActionResult aaa()
        //{
        //    Address adr = new Address();
        //    adr.CityName = "Shenzhen";
        //    adr.StateName = "Huagang Road";
        //    Customer cus = new Customer() { FName = "steven",address=adr };
        //    ViewBag.Cus = cus;
        //    return View("aaa",cus);
        //}

        
    }
}