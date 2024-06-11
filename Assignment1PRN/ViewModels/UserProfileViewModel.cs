using Assignment1PRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1PRN.ViewModels
{
    public class UserProfileViewModel:ViewModel
    {
        private Customer _customer;
        public Customer Customer { get => _customer; set => SetField(ref _customer,value); }
        public UserProfileViewModel(Customer customer)
        {
            Customer = customer;
        }
    }
}
