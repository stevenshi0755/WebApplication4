using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    //个人练习
    public class Address
    {
        public string CityName { get; set; }
        public string StateName { get; set; }
    }
    public class Customer
    {
        public string FName { get; set; }
        public Address address { get; set; }
    }
}