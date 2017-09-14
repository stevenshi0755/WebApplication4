using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;
using WebApplication4.Data_Access_Layer;

namespace WebApplication4.Controllers
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            //3课
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();



            //2课
            //List<Employee> employees = new List<Employee>();
            //{
            //    new Employee {FirstName="Johnson",LastName="fernandes",Salary=14000 },
            //    new Employee {FirstName="Michael",LastName="Jackson",Salary=16000 },
            //    new Employee {FirstName="Robert",LastName="Pattinson",Salary=20000 },
            //};

            //Employee emp = new Employee();
            //emp.FirstName = "johnson";
            //emp.LastName = " fernandes";
            //emp.Salary = 14000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.FirstName = "michael";
            //emp.LastName = "jackson";
            //emp.Salary = 16000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.FirstName = "robert";
            //emp.LastName = " pattinson";
            //emp.Salary = 20000;
            //employees.Add(emp);

            //return employees;

        }
    }
}