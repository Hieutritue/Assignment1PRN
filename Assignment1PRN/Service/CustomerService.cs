using Assignment1PRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1PRN.Service
{
    public class CustomerService
    {
        public CustomerService() { }
        public List<Customer> GetAll() { return FuminiHotelManagementContext.Instance().Customers.ToList(); }
        public bool HasCustomer(String email, String password) {
            return GetAll().Any(c => c.EmailAddress .Equals(email)  && c.Password.Equals(password));
        }
        public Customer GetCustomer(String email, String password)
        {
            return GetAll().Where(c => c.EmailAddress .Equals(email)  && c.Password.Equals(password)).ToList()[0];
        }
    }
}
